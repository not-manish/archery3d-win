using System;

namespace SevenZip
{
	internal class LzmaAlone
	{
		private enum Key
		{
			Help1 = 0,
			Help2 = 1,
			Mode = 2,
			Dictionary = 3,
			FastBytes = 4,
			LitContext = 5,
			LitPos = 6,
			PosBits = 7,
			MatchFinder = 8,
			EOS = 9,
			StdIn = 10,
			StdOut = 11,
			Train = 12
		}

		private static void PrintHelp()
		{
		}

		private static bool GetNumber(string s, out int v)
		{
			v = default;
			return false;
		}

		private static int IncorrectCommand()
		{
			return 0;
		}

		private static int Main2(string[] args)
		{
			return 0;
		}

		[STAThread]
		private static int Main(string[] args)
		{
			return 0;
		}
	}
}
