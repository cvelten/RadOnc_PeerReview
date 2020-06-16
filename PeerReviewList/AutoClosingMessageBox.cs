using System;
using System.Windows.Forms;

namespace PeerReview
{
	public class AutoClosingMessageBox
	{
		System.Threading.Timer _timeoutTimer;
		string _caption;

		public AutoClosingMessageBox(string text, string caption, int timeout, MessageBoxButtons buttons = MessageBoxButtons.OK,
			MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
		{
			_caption = caption;
			_timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
				null, timeout, System.Threading.Timeout.Infinite);
			using (_timeoutTimer)
				MessageBox.Show(text, caption, buttons, icon, defaultButton);
		}

		public static void Show(string text, string caption, int timeout)
		{
			new AutoClosingMessageBox(text, caption, timeout);
		}

		public static void Show(string text, string caption, int timeout, MessageBoxButtons buttons)
		{
			new AutoClosingMessageBox(text, caption, timeout, buttons);
		}

		public static void Show(string text, string caption, int timeout, MessageBoxIcon icon)
		{
			new AutoClosingMessageBox(text, caption, timeout, MessageBoxButtons.OK, icon);
		}

		public static void Show(string text, string caption, int timeout, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			new AutoClosingMessageBox(text, caption, timeout, buttons, icon);
		}

		public static void Show(string text, string caption, int timeout, MessageBoxButtons buttons, MessageBoxIcon icon,
			MessageBoxDefaultButton defaultButton)
		{
			new AutoClosingMessageBox(text, caption, timeout, buttons, icon, defaultButton);
		}

		void OnTimerElapsed(object state)
		{
			IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
			if (mbWnd != IntPtr.Zero)
				SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
			_timeoutTimer.Dispose();
		}

		const int WM_CLOSE = 0x0010;

		[System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
		static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
		static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
	}
}