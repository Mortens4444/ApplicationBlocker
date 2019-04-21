using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FBB
{
	public class KeySender
	{
        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        readonly IntPtr windowHandle;

        public KeySender(IntPtr windowHandle)
        {
            this.windowHandle = windowHandle;
        }

		public void SendAltF4To()
		{
			Send(windowHandle, "%{F4}");
		}

		public void SendCtrlF4To()
		{
			Send(windowHandle, "^{F4}");
		}

        static void Send(IntPtr windowHandle, string message)
		{
			SetForegroundWindow(windowHandle);
			SendKeys.SendWait(message);
		}
	}
}
