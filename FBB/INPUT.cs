using System.Runtime.InteropServices;

namespace FBB
{
	[StructLayout(LayoutKind.Sequential)]
	public struct INPUT
	{
		public InputType type;
		public InputUnion inputs;

		public static int Size
		{
			get { return Marshal.SizeOf(typeof(INPUT)); }
		}
	}
}