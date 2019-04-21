using System.Runtime.InteropServices;

namespace FBB
{
	[StructLayout(LayoutKind.Sequential)]
	public struct HARDWAREINPUT
	{
		public int uMsg;
		public short wParamL;
		public short wParamH;
	}
}