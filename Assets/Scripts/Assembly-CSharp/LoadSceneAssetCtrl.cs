public class LoadSceneAssetCtrl
{
	private static string scenePath;

	private static string SceneAbSuffix;

	private static string SceneDlDir;

	public static bool isLoadScene2;

	public static string GetFightingSceneNames(SceneType sceneType, bool LoadScene2)
	{
		return null;
	}

	public static string GetSceneName(GameType gameType, int levelID, bool isScene2 = false)
	{
		return null;
	}

	public static void LoadScene(SceneType sceneType, bool LoadScene2)
	{
	}

	public static SingleFileState isSceneExisting(GameType gameType, int levelID, bool isScene2 = false)
	{
		return SingleFileState.None;
	}

	public static bool DownloadScene(GameType gameType, int levelID, bool isScene2 = false)
	{
		return false;
	}

	public static int OfflineLoadDefaultScene(int sceneType)
	{
		return 0;
	}
}
