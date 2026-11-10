public class VersionMgr
{
	public enum VersionState
	{
		upgrade_none = 0,
		upgrade_opt = 1,
		upgrade_force = 2
	}

	public static string[] IGNORE_SERVER_VERSION;

	public static bool IsVersionValid()
	{
		return false;
	}
}
