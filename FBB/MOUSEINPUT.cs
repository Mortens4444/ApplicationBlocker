using System;
using System.Runtime.InteropServices;

namespace FBB
{
	[StructLayout(LayoutKind.Sequential)]
	public struct MOUSEINPUT
	{
		public int dx;
		public int dy;
		public int mouseData;
		public MOUSEEVENTF dwFlags;
		public uint time;
		public UIntPtr dwExtraInfo;
	}
}