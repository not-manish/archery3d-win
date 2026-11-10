using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace LzmaAlone.Properties
{
	internal class Resources
	{
		private static ResourceManager _resMgr;

		private static CultureInfo _resCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager => null;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Resources()
		{
		}
	}
}
