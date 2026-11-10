using System;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
	public static float scaletimeSinceStart;

	public static float realtimeSinceStartup;

	private TimeManager instance;

	private static bool hasGetServeTime;

	private static long nativeMilTimeGetServeTime;

	private static long serverTimeMil;

	public static float requestTime;

	private static double Tick2DataTime;

	private static double Seconds2Tick;

	private static double Tick2Seconds;

	private static double Mills2Tick;

	private static double Tick2Mills;

	private static DateTime Jan1st1970;

	public TimeManager Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public static void SetServeTime(long _serverTime, float _requestTime)
	{
	}

	public static bool HasGetServeTime()
	{
		return false;
	}

	public static long GetServeTimeMil()
	{
		return 0L;
	}

	public static long GetServeTimeSecond()
	{
		return 0L;
	}

	public static long GetNativeTimeSecond()
	{
		return 0L;
	}

	public static long GetNativeTimeMil()
	{
		return 0L;
	}
}
