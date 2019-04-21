using System;

namespace FBB
{
	[Flags]
	public enum KEYEVENTF : uint
	{
		KEYDOWN = 0x0000,
		EXTENDEDKEY = 0x0001,
		KEYUP = 0x0002,
		SCANCODE = 0x0008,
		UNICODE = 0x0004
	}
}
