using Pool3D.TimerUtil;

namespace AssetUpdate
{
	public class ConfigFileInfo : FileInfo
	{
		protected string localPath;

		public static string LocalResourcesPath;

		public string RemoteUrl { get; set; }

		public long Size { get; set; }

		public int DlPriority { get; set; }

		public bool Updated { get; set; }

		public int DownloadTimes { get; set; }

		public Timer OverTimer { get; set; }

		public virtual string UncompressPath => null;

		public virtual string LocalPath => null;

		public static string ConfigFileDir => null;

		public static string AtlasFileDir => null;

		public static string TextureFileDir => null;

		public static string ModelFileDir => null;

		public static string SceneFileDir => null;

		public static string AudioFileDir => null;

		public static string PrefabFileDir => null;

		public static string MaterialFileDir => null;

		public virtual void OnOverTime()
		{
		}

		public virtual float GetMaxTimeOver()
		{
			return 0f;
		}

		public static string ConfigFile__(FileType fileType)
		{
			return null;
		}
	}
}
