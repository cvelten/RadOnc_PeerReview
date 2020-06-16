using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using GemBox.Pdf;


namespace PeerReview
{
	sealed class PDFReader
	{
		private readonly PdfLoadOptions loadOptions = new PdfLoadOptions() { ReadOnly = true };

		static PDFReader()
		{
		}

		private PDFReader()
		{
			ComponentInfo.SetLicense("FREE-LIMITED-KEY");
			ParseErrors = new List<string>();
		}

		public static PDFReader Instance { get; } = new PDFReader();
		public List<string> ParseErrors { get; }

		public string Pdf2Txt(FileSystemInfo file)
		{
			var sb = new StringBuilder();
			using (var document = PdfDocument.Load(file.FullName, loadOptions))
				foreach (var page in document.Pages) sb.AppendLine(page.Content.ToString());

			return sb.ToString();
		}

		public async Task<string> Pdf2TxtAsync(FileSystemInfo file)
		{
			var sb = new StringBuilder();
			await Task.Run(() =>
				{
					using (var document = PdfDocument.Load(file.FullName, loadOptions))
						foreach (var page in document.Pages) sb.AppendLine(page.Content.ToString());
				}
			);
			return sb.ToString();
		}

	}

}