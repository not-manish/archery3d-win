using System.Collections.Generic;

public class OfflineData
{
	public static List<int> ScoresList;

	public static Dictionary<int, int> ServeIdScores;

	public static int CurRound;

	private static bool isTimeOver;

	public static int AllRound;

	public static void ClearData()
	{
	}

	public static bool IsGameOver(int levelID)
	{
		return false;
	}

	public static bool IsLastArrow(int levelID)
	{
		return false;
	}

	public static void SetNextRound()
	{
	}

	public static void SetIsTimeOver(bool over)
	{
	}

	public static void SetScore(int _score)
	{
	}

	public static int GetSumScore()
	{
		return 0;
	}

	public static int GetLastScore()
	{
		return 0;
	}

	public static void UpdateWind(int LevelID)
	{
	}
}
