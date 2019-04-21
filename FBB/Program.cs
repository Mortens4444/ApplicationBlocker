using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace FBB
{
	class Program
	{
		[DllImport("User32.dll")]
		static extern bool ShowWindow(IntPtr WindowHandle, nCmdShow nCmdShow);

        static readonly List<string> PageTitleParts = new List<string> { "aggress", "brutal", "facebook", "game", "gyilkos", "hardcore", "horoszkóp", "játék", "kill", "myvip", "ncore", "porn", "sex", "szex", "xxx", "youtube", "video", "vimeo" };

		static void Main(string[] args)
		{
			ShowWindow(Process.GetCurrentProcess().MainWindowHandle, nCmdShow.SW_HIDE);

            var processCloser = args.Length == 0 ? new ProcessCloser(PageTitleParts) : new ProcessCloser(args);
			while (true)
			{
                processCloser.CloseUnwantedWebPages();				
				Thread.Sleep(1000);
			}
		}
	}
}
