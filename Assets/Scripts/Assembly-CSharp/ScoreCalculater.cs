using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculater
{
	private static float ScoreDis;

	private static int[] bingo_score_1;

	private static int[] bingo_score_2;

	private static int[] bingo_score_3;

	private static int[] bingo_score_4;

	public static float GetBarRadius()
	{
		return 0f;
	}

	public static int GetNormalTargetScore(Vector3 centerWorldPos, Vector3 hitWorldPos, Vector3 tarWorldForward)
	{
		return 0;
	}

	public static int GetNormalTargetScore(float length)
	{
		return 0;
	}

	public static Vector3 GetNormalTargetShootLocalPos(int score, TargetNormalType normalType, Transform targetTrans = null)
	{
		return default;
	}

	private static Vector3 GetNormalShootLocalPos_Normal(int score, TargetNormalType normalType, Transform targetTrans)
	{
		return default;
	}

	public static int getIndexScoreBingo(Vector3 HitPos, Vector3 VecTarCenter, Vector3 VecTarForward, Vector3 VecTarTop)
	{
		return 0;
	}

	private static Vector2 GetNormalShootLocalPos_Bingo(int score, TargetNormalType normalType, Transform targetTrans)
	{
		return default;
	}

	public static List<int> GetIndexOfTargetByScore_Bingo(List<int> score, TargetNormalType normalType)
	{
		return null;
	}
}
