using System.Collections.Generic;

public class AiEmojiLoader
{
	private static List<int> listAiEmojiID;

	private static Dictionary<int, AiEmojiOriData> oriDatas;

	private static List<int> gameStartEmojiIds;

	private static List<int> playerShootEmojiIds;

	private static List<int> SetGameLineMyWin;

	private static List<int> SetGameLineOppWin;

	private static List<int> EnterFinalIds;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static List<int> GetAiEmojiKindIDs()
	{
		return null;
	}

	public static AiEmojiOriData GetAiEmojiOriData(int ID)
	{
		return null;
	}

	public static Dictionary<int, AiEmojiOriData> GetAllAiEmojiOriData()
	{
		return null;
	}

	public static int RandomGameStartEmojiId()
	{
		return 0;
	}

	public static int RandomPlayerShootEmojiId()
	{
		return 0;
	}

	public static int RandomSetGameLineMyWinEmojiId()
	{
		return 0;
	}

	public static int RandomSetGameLineOppEmojiId()
	{
		return 0;
	}

	public static int RandomEnterFinalEmojiId()
	{
		return 0;
	}
}
