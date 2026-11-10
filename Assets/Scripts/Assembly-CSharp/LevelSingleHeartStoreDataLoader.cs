using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelSingleHeartStoreDataLoader : MonoBehaviour
{
	public static int MaxHeart;

	public static int EnterLenelDeleteHeart;

	private static Dictionary<int, LevelSingleHeartStoreOriData> oriHeartDatas;

	private static LevelSingleHeartRealtimeData realtimeHeartDatas;

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	public static void LoadLevelHeartRealTimeData()
	{
	}

	public static void SaveLevelHeartRealTimeData()
	{
	}

	public static LevelSingleHeartStoreOriData GetLevelHeartSingleOriData(int ID)
	{
		return null;
	}

	public static Dictionary<int, LevelSingleHeartStoreOriData> GetAllLevelSingleHeartOriData()
	{
		return null;
	}

	public static LevelSingleHeartRealtimeData GetLevelSingleHeartRealtimeData()
	{
		return null;
	}

	public static bool isRecoverHeart()
	{
		return false;
	}

	public static void SetLevelSingleHeartRealtimeData(int DelHeartCount)
	{
	}

	public static long GetMilliseconds(DateTime datetime)
	{
		return 0L;
	}
}
