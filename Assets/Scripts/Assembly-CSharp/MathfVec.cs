using UnityEngine;

public class MathfVec
{
	private const float DESKTOP_SCREEN_STANDARD_DPI = 96f;

	private const float INCHES_TO_CENTIMETERS = 2.54f;

	private const float CENTIMETERS_TO_INCHES = 50f / 127f;

	private static float screenDPI;

	private static long NativeTimeDayDivisor;

	private static long NativeTimeSecondDivisor;

	private static long ServeTimeDayDivisor;

	public static float ScreenDPI
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static Vector2 PerpturnRight(Vector2 a)
	{
		return default;
	}

	public static Vector2 PerpturnLeft(Vector2 a)
	{
		return default;
	}

	public static Vector3 TurnVec3WithAngle(Vector3 vec, float angle, RotatePlane whichPlane)
	{
		return default;
	}

	public static float GetAngleBetweenVec3(Vector3 from, Vector3 to)
	{
		return 0f;
	}

	public static float ChangeAngleIn180(float angle)
	{
		return 0f;
	}

	public static Vector3 ChangeAngleIn180(Vector3 angle)
	{
		return default;
	}

	public static bool IsTimeValid(int minHour, int maxHour)
	{
		return false;
	}

	public static float Convert(float distance, DistanceUnit fromUnit, DistanceUnit toUnit)
	{
		return 0f;
	}

	public static Vector2 ScreenPosCM(Vector2 scrreenPos)
	{
		return default;
	}

	public static bool GetLinesJoint(Vector3 L1P1, Vector3 L1P2, Vector3 L2P1, Vector3 L2P2, ref Vector3 joint)
	{
		return false;
	}

	public static Vector3 GetLinePlaneJoint(Vector3 startPoint, Vector3 endPoint, float Zaxis)
	{
		return default;
	}

	public static float FloatRem(float curT, float T)
	{
		return 0f;
	}

	public static int GetNativeDayTime()
	{
		return 0;
	}

	public static long GetNativeSeconds()
	{
		return 0L;
	}

	public static string Vector3ToString(Vector3 vec)
	{
		return null;
	}
}
