using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack.Dialogs;

using AddressBook = PeerReview.AddressBookSection.AddressBook;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace PeerReview
{
	public partial class MainForm : Form
	{
		private readonly CommonOpenFileDialog _openDirectoryDialog;

		private List<System.Diagnostics.Process> _childProcesses = new List<System.Diagnostics.Process>();

		private readonly Dictionary<DirectoryInfo, ReviewPatientCollection> _data =
			new Dictionary<DirectoryInfo, ReviewPatientCollection>();

		private readonly Dictionary<DirectoryInfo, DataTable> _dataTables = new Dictionary<DirectoryInfo, DataTable>();

		public AddressBook AddressBook { get; private set; }

		private ProcessManager _processManager;

		public MainForm()
		{
			LoadConfiguration();

			InitializeComponent();

			var pwd = Directory.GetCurrentDirectory();
			_openDirectoryDialog = new CommonOpenFileDialog
			{
				IsFolderPicker = true,
				InitialDirectory = pwd
			};
			textBoxPWD.Text = pwd;

			saveFileDialogExcel.InitialDirectory = pwd;

			UpdatePath(null, null);

			_processManager = new ProcessManager();
		}


		private void LoadConfiguration()
		{
			AddressBook = new AddressBook(ConfigurationManager.GetSection("addressbook") as List<AddressBook.Card>);
		}

		#region Logging
		public enum LogType
		{
			Info,
			Warning,
			Error
		};

		public void LogMessage(string message, LogType type = LogType.Info)
		{
			string _type;
			switch (type)
			{
				case LogType.Error:
					_type = "  ERROR";
					break;
				case LogType.Warning:
					_type = "WARNING";
					break;
				default:
					_type = "   INFO";
					break;
			}

			RTFBoxLog.AppendText($"{DateTime.Now.ToLongTimeString()} | {_type}: {message}\n");
		}

		private void ButtonLogCopy_Click(object sender, EventArgs e)
		{
			RTFBoxLog.SelectAll();
			RTFBoxLog.Copy();
		}

		private void ButtonLogClear_Click(object sender, EventArgs e)
		{
			RTFBoxLog.Clear();
		}
		#endregion

		#region FindDirectories
		public async Task FindDirectoriesAsync()
		{
			var generalNodes = treeViewDirs.Nodes["nodeGeneral"].Nodes;
			var specialNodes = treeViewDirs.Nodes["nodeSpecial"].Nodes;
			var cornwallNodes = treeViewDirs.Nodes["nodeCornwall"].Nodes;

			treeViewDirs.CollapseAll();
			generalNodes.Clear();
			specialNodes.Clear();
			cornwallNodes.Clear();

			var dirInfo = new DirectoryInfo(textBoxPWD.Tag.ToString());

			if (!dirInfo.Exists)
				return;

			var foldersGeneral = new SortedList<string, DirectoryInfo>();
			var foldersSpecial = new SortedList<string, DirectoryInfo>();
			var foldersCornwall = new SortedList<string, DirectoryInfo>();

			if (dirInfo.Name.StartsWith("general", StringComparison.InvariantCultureIgnoreCase))
				foldersGeneral.Add(dirInfo.Name, dirInfo);
			if (dirInfo.Name.StartsWith("special", StringComparison.InvariantCultureIgnoreCase))
				foldersSpecial.Add(dirInfo.Name, dirInfo);
			if (dirInfo.Name.StartsWith("cornwall", StringComparison.InvariantCultureIgnoreCase))
				foldersCornwall.Add(dirInfo.Name, dirInfo);

			foreach (var dir in dirInfo.GetDirectories())
			{
				LogMessage($"Found: {dir.Name}");

				if (dir.Name.StartsWith("general", StringComparison.InvariantCultureIgnoreCase))
					foldersGeneral.Add(dir.Name, dir);
				else if (dir.Name.StartsWith("special", StringComparison.InvariantCultureIgnoreCase))
					foldersSpecial.Add(dir.Name, dir);
				else if (dir.Name.StartsWith("cornwall", StringComparison.InvariantCultureIgnoreCase))
					foldersCornwall.Add(dir.Name, dir);
			}

			LogMessage("Processing folders:");
			foreach (var pair in foldersGeneral)
			{
				LogMessage($"- '{pair.Key}'");
				generalNodes.Add(new TreeNode(pair.Key) {Tag = pair.Value});
				await ScanDirectoryAsync(pair.Value);
			}

			foreach (var pair in foldersSpecial)
			{
				LogMessage($"- '{pair.Key}'");
				specialNodes.Add(new TreeNode(pair.Key) {Tag = pair.Value});
				await ScanDirectoryAsync(pair.Value);
			}

			foreach (var pair in foldersCornwall)
			{
				LogMessage($"- '{pair.Key}'");
				cornwallNodes.Add(new TreeNode(pair.Key) {Tag = pair.Value});
				await ScanDirectoryAsync(pair.Value);
			}

			treeViewDirs.ExpandAll();
		}

		private void ScanDirectory(DirectoryInfo directory)
		{
			_data.Remove(directory);
			_data[directory] = ReviewPatientCollection.ReadDirectory(directory);
		}

		private async Task ScanDirectoryAsync(DirectoryInfo directory)
		{
			if (_data.ContainsKey(directory)) _data.Remove(directory);
			_data[directory] = await ReviewPatientCollection.ReadDirectoryAsync(directory);
			foreach (var msg in _data[directory].Errors)
				LogMessage(msg, LogType.Error);
		}

		private async void UpdatePath(object sender, EventArgs e)
		{
			if (!(textBoxPWD.Tag is null))
				if (textBoxPWD.Text == textBoxPWD.Tag.ToString())
					return;
			Enabled = false;
			textBoxPWD.Tag = textBoxPWD.Text;

			await FindDirectoriesAsync();
			Enabled = true;
		}
		#endregion

		#region Selecting Directory
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.O))
			{
				ButtonDirBrowse_Click(null, null);
				return true;
			}

			if (keyData == (Keys.Control | Keys.P))
			{
				PrintToolStripMenuItem_Click(null, null);
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void ButtonDirBrowse_Click(object sender, EventArgs e)
		{
			_openDirectoryDialog.InitialDirectory = textBoxPWD.Tag?.ToString();
			if (_openDirectoryDialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				textBoxPWD.Text = _openDirectoryDialog.FileName;
				UpdatePath(sender, e);
			}
		}

		private void TextBoxPWD_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int) Keys.Enter || e.KeyChar == (int) Keys.Return)
				UpdatePath(sender, e);
			else if (e.KeyChar == (int) Keys.Escape)
				textBoxPWD.Text = textBoxPWD.Tag.ToString();
		}
		#endregion

		private void CreateDataTable(DirectoryInfo directory)
		{
			if (!_data.ContainsKey(directory)) return;

			var dt = new DataTable(directory.Name);

			dt.Columns.Add("Attending");
			dt.Columns.Add("MRN");
			dt.Columns.Add("Patient Name");
			dt.Columns.Add("Diagnosis");
			dt.Columns.Add("GUID");

			foreach (DataColumn col in dt.Columns) col.ReadOnly = true;

			foreach (var item in _data[directory])
			{
				var row = dt.NewRow();
				row["Attending"] = item.MD;
				row["MRN"] = item.MRN;
				row["Patient Name"] = item.Name;
				row["Diagnosis"] = item.Diagnosis;
				row["GUID"] = item.Guid;
				dt.Rows.Add(row);
			}

			_dataTables[directory] = dt;
		}

		private void TreeViewDirs_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node == treeViewDirs.Nodes["nodeGeneral"]
				|| e.Node == treeViewDirs.Nodes["nodeSpecial"]
				|| e.Node == treeViewDirs.Nodes["nodeCornwall"]) return;

			toolStripLabelCurrentNode.Text = "Selected: " + e.Node.Text;
			var directory = e.Node.Tag as DirectoryInfo;

			if (!_dataTables.ContainsKey(directory))
				CreateDataTable(directory);

			if (!_dataTables.ContainsKey(directory)) return;
			dataGridView.DataSource = _dataTables[directory];
			dataGridViewRun.DataSource = dataGridView.DataSource;

			dataGridView.Columns["GUID"].Visible = false;
			dataGridViewRun.Columns["GUID"].Visible = false;

			dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
			if (!(dataGridView.Columns["Patient Name"] is null))
				dataGridView.Columns["Patient Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			if (!(dataGridView.Columns["Attending"] is null))
				dataGridView.Sort(dataGridView.Columns["Attending"], ListSortDirection.Ascending);

			dataGridViewRun.Columns["Patient Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewRun.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

			if (_data[directory].Errors.Count > 0)
				MessageBox.Show(@"There were errors reading files for this node, check the log!",
					@"Error Reading Files", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void TimerTime_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
		}

		#region ToolStrip
		private void NavigateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var item = sender as ToolStripMenuItem;
			if (item == startupDirectorypwdToolStripMenuItem)
			{
				textBoxPWD.Text = Directory.GetCurrentDirectory();
				UpdatePath(sender, e);
			}
			else if (item == montefioreorgRADPRODFAToolStripMenuItem)
			{
				textBoxPWD.Text = @"\\montefiore.org\RADPRODFA\RADPRODFA";
				UpdatePath(sender, e);
			}
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void PrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			printPreviewDialog.ShowDialog();
		}

		private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			/* From: https://docs.microsoft.com/en-us/dotnet/framework/winforms/advanced/how-to-print-a-multi-page-text-file-in-windows-forms */
			var font = new Font("Consolas", 10);
			var stringToPrint = DataGridToString();

			e.Graphics.MeasureString(stringToPrint, font, e.MarginBounds.Size, StringFormat.GenericTypographic,
				out var charactersOnPage, out _);
			e.Graphics.DrawString(stringToPrint, font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
			stringToPrint = stringToPrint.Substring(charactersOnPage);
			e.HasMorePages = (stringToPrint.Length > 0);
		}

		private void PrintSetupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pageSetupDialog.ShowDialog();
		}

		private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var result = printDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AutoClosingMessageBox.Show("not yet implemented", "Sorry!", 2000);
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var about = new AboutBox();
			about.ShowDialog();
		}
		#endregion

		#region Send E-Mail

		private async Task SendEMailTo(IEnumerable<string> recipients)
		{
			if (treeViewDirs.SelectedNode is null)
			{
				AutoClosingMessageBox.Show("First select a folder!", "Error", 3000, MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			var emailSubject = treeViewDirs.SelectedNode.Text;

			var emailBody = DataGridToString();
			if (emailBody == string.Empty)
			{
				AutoClosingMessageBox.Show("Stopping right here, since the message would be empty!", "Error", 3000,
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
				return;
			}

			if (treeViewDirs.SelectedNode.Tag is DirectoryInfo directory && _data[directory].Errors.Count > 0)
			{
				emailBody += "\n\nThere have been errors for the selected folder:\n";
				foreach (var x in _data[directory].Errors)
					emailBody += $"% {x}\n";
			}

			await Task.Run(() =>
			{
				Outlook.Application app;
				Outlook.MailItem email;
				try
				{
					app = new Outlook.Application();
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(@"Cannot open Outlook!\n\n" + ex.Message, @"Error!", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				try
				{
					email = app.CreateItem(Outlook.OlItemType.olMailItem) as Outlook.MailItem;
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(@"Cannot create E-Mail!\n\n+" + ex.Message, @"Error!", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				if (email is null) return;
				email.Subject = "Peer Review List";
				foreach (var recipient in recipients) email.Recipients.Add(recipient);
				email.Recipients.ResolveAll();

				email.BodyFormat = Outlook.OlBodyFormat.olFormatRichText;

				const string html = "<html>\n<head><title>Peer Review: {0}</title>\n</head>\n<body>" +
				                    "<span><font face=\"Consolas, Courier, Monospace\">\n{1}\n</font></span>\n</body>\n</html>";
				email.HTMLBody = string.Format(html, emailSubject,
					emailBody.Replace(" ", "&nbsp;").Replace("\n", "<br />\n"));
				email.Display(true);

				System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
				GC.Collect();
			});
		}

		private async void SendEMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Enabled = false;
			await SendEMailTo(AddressBook.GetEMails());
			Enabled = false;
		}

		private async void SendEMailToToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var sendEMailForm = new SendEMailForm(AddressBook);

			if (sendEMailForm.ShowDialog() == DialogResult.OK)
			{
				Enabled = false;
				AddressBook = sendEMailForm.AddressBook;
				await SendEMailTo(AddressBook.FromSelected().GetEMails());
				Enabled = true;
			}
		}
		#endregion

		private string DataGridToString()
		{
			if (dataGridView.Columns["Attending"] is null ||
			    dataGridView.Columns["MRN"] is null ||
			    dataGridView.Columns["Patient Name"] is null ||
			    dataGridView.Columns["Diagnosis"] is null) return string.Empty;

			var em = dataGridView.DefaultCellStyle.Font.SizeInPoints;
			var wAttending = (int) System.Math.Ceiling(dataGridView.Columns["Attending"].Width / em) + 1;
			var wMRN = (int) System.Math.Ceiling(dataGridView.Columns["MRN"].Width / em);
			var wName = (int) System.Math.Ceiling(dataGridView.Columns["Patient Name"].Width / em);
			var wDiag = (int) System.Math.Ceiling(dataGridView.Columns["Diagnosis"].Width / em) + 1;
			var wFull = wAttending + wMRN + wName + wDiag + 13;

			var sb = new System.Text.StringBuilder();
			var format = $"| {{0,{wAttending}}} | {{1,{wMRN}}} | {{2,{wName}}} | {{3,{wDiag}}} |";

            sb.AppendLine("REMINDER: This list is NOT exhaustive and does not assume completeness - it is merely a starting point for Peer Review prep.");
            sb.AppendLine("");
			sb.AppendLine(new string('-', wFull));
			sb.AppendLine(string.Format($"|{{0,{wFull - 3}}} |", treeViewDirs.SelectedNode.Text));
			sb.AppendLine(new string('-', wFull));
			sb.AppendLine(string.Format(format, "Attending", "MRN", "Patient Name", "Diagnosis"));
			sb.AppendLine(new string('-', wAttending + wMRN + wName + wDiag + 13));
			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				sb.AppendLine(string.Format(format, row.Cells["Attending"].Value, row.Cells["MRN"].Value,
					row.Cells["Patient Name"].Value, row.Cells["Diagnosis"].Value.ToString().Replace(": ", "")));
			}

			sb.AppendLine(new string('-', wFull));

			sb.AppendLine("");

			if (treeViewDirs.SelectedNode.Tag is DirectoryInfo directory && _data[directory].Errors.Count > 0)
			{
				sb.AppendLine("There have been errors for the selected folder:");
				foreach (var x in _data[directory].Errors)
					sb.AppendLine($"% {x}\n");
			}

			return sb.ToString();
		}

		private void TextOutputToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var popup = new RichTextPopUp
			{
				FormTitle = treeViewDirs.SelectedNode?.Text,
				TextBoxValue = DataGridToString()
			};
			popup.ShowDialog();
		}

		private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

			var s = sender as DataGridView;

			var directory = treeViewDirs.SelectedNode.Tag as DirectoryInfo;
			var row = s.Rows[e.RowIndex].Cells;

			ReviewPatient reviewPatient = _data[directory].Collection.Find(x => x.Guid == Guid.Parse(row["GUID"].Value.ToString()));
			_childProcesses.Add(System.Diagnostics.Process.Start(reviewPatient.FilePDF.FullName));
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			_processManager.Clear();
		}

		private void ToExcelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialogExcel.InitialDirectory = textBoxPWD.Text;

			if (saveFileDialogExcel.ShowDialog() == DialogResult.OK)
			{

				try
				{
					((DataTable)dataGridView.DataSource).ExportToExcel(saveFileDialogExcel.FileName);
					System.Diagnostics.Process.Start(saveFileDialogExcel.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Something went wrong:\n{ex.Message}", $@"Error: {ex.Source}", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void DataGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
		{
			var dgv = sender as DataGridView;

			if (e.RowIndex == -1 || e.ColumnIndex == -1)
				return;

			e.ContextMenuStrip = cmsDGVRun;
		}

		private void CMSRunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var s = sender as ToolStripMenuItem;
			var directory = treeViewDirs.SelectedNode.Tag as DirectoryInfo;

			var rows = new List<DataGridViewRow>();
			foreach(DataGridViewCell cell in dataGridViewRun.SelectedCells)
			{
				if (!rows.Contains(dataGridViewRun.Rows[cell.RowIndex]))
					rows.Add(dataGridViewRun.Rows[cell.RowIndex]);
			}

			if (s == radialogicaToolStripMenuItem && rows.Count > 2)
			{
				if (MessageBox.Show("You have selected more than two patients. Radialogica is unstable and/or takes a " +
					"long time when opening multiple packages. Hit OK to continue, otherwise Cancel", "Many Packages selected!",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.OK)
					return;
			}

			foreach (DataGridViewRow row in rows)
			{
				ReviewPatient reviewPatient = _data[directory].Collection.Find(x => x.Guid == Guid.Parse(row.Cells["GUID"].Value.ToString()));
				try
				{
					if (s == pDFToolStripMenuItem && reviewPatient.FilePDF.Exists)
						_processManager?.Add(new ReviewProcess(reviewPatient.FilePDF.FullName) { ProcessType = ProcessType.PDF });
					if (s == radialogicaToolStripMenuItem && reviewPatient.FileRadialogica.Exists)
						_processManager?.Add(new ReviewProcess(reviewPatient.FileRadialogica.FullName) { ProcessType = ProcessType.Radialogica });
				}
				catch(System.ComponentModel.Win32Exception ex)
				{
					MessageBox.Show($"I did not find one of the files!\n'{ex.Message}'", @"File Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void ButtonRun_Click(object sender, EventArgs e)
		{
			var s = sender as Button;
			var directory = treeViewDirs.SelectedNode.Tag as DirectoryInfo;

			if (s == buttonRunSelectAll)
			{
				dataGridViewRun.SelectAll();
				return;
			}

			var patients = new List<ReviewPatient>();
			var rows = new List<DataGridViewRow>();
			foreach (DataGridViewCell cell in dataGridViewRun.SelectedCells)
			{
				ReviewPatient reviewPatient = _data[directory].Collection.Find(x => x.Guid == Guid.Parse(cell.OwningRow.Cells["GUID"].Value.ToString()));
				if (!patients.Contains(reviewPatient)) patients.Add(reviewPatient);
			}

			if (s == buttonRunRadialogica && patients.Count > 2)
			{
				if (MessageBox.Show("You have selected more than two patients. Radialogica is unstable and/or takes a " +
					"long time when opening multiple packages. Hit OK to continue, otherwise Cancel", "Many Packages selected!", 
					MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.OK)
					return;
			}

			foreach (var patient in patients)
			{
				if (s == buttonRunPDF)
				{
					_processManager.Add(new ReviewProcess(patient.FilePDF.FullName, ProcessType.PDF));
				}
				else if (s == buttonRunRadialogica)
				{
					_processManager.Add(new ReviewProcess(patient.FileRadialogica.FullName, ProcessType.Radialogica));
				}
			}
		}

		private void TimerProcesses_Tick(object sender, EventArgs e)
		{
			timerProcesses.Stop();
			_processManager?.UpdateRunningProcesses();
			timerProcesses.Start();
		}
	}
}