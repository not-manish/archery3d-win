using System;

public class TimeUtil
{
	private static DateTime Jan1st1970;

	private static bool UseServeTime;

	private static double ServerTime2DataTime;

	private static double Tick2DataTime;

	private static double Seconds2Tick;

	private static double Tick2Seconds;

	private static double Mills2Tick;

	private static double Tick2Mills;

	public static bool isServerTimeValid;

	public static long TIMEGAPMILLS;

	public static long GetTicksBySeconds(long second)
	{
		return 0L;
	}

	public static bool CheckNewDay(long curTime, long lastTime)
	{
		return false;
	}

	public static long CurrentDayTime()
	{
		return 0L;
	}

	public static long CurrentTimeSeconds()
	{
		return 0L;
	}

	public static long CurrentTimeMills()
	{
		return 0L;
	}

	public static long CurrentTimeMills_Server()
	{
		return 0L;
	}

	public static void UpdateTimeGapMills(long serverTimeMills)
	{
	}

	public static string GetTimeString_hms(long time)
	{
		return null;
	}

	public static string GetTimeString_ms(float time)
	{
		return null;
	}

	public static string GetTimeLeft(long secondsLeft)
	{
		return null;
	}

	public static string GetTimeLeftMainMenu(long timeLeftSecond)
	{
		return null;
	}

	public static string GetTimesNotShowDay(long timeLeftSecond)
	{
		return null;
	}

	public static string GetTimeLeftHaveDay(long timeLeftSecond)
	{
		return null;
	}

	public static long GetDays(long times)
	{
		return 0L;
	}

	public static long Get48Hour_Mills()
	{
		return 0L;
	}

	public static long GetWeek_Mills()
	{
		return 0L;
	}

	public static long GetTime_Day_Mills(int dayCount)
	{
		return 0L;
	}

	public static long GetHour_Mills(int dayCount)
	{
		return 0L;
	}

	public static string GetTimeByFormat(long times, string format)
	{
		return null;
	}
}
