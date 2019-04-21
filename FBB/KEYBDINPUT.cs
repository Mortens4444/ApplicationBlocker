using System;
using System.Runtime.InteropServices;

namespace FBB
{
	[StructLayout(LayoutKind.Sequential)]
	public struct KEYBDINPUT
	{
		public VirtualKeyCodes wVk;
		public ScanCodeShort wScan;
		public KEYEVENTF dwFlags;
		public int time;
		public UIntPtr dwExtraInfo;
	}
}