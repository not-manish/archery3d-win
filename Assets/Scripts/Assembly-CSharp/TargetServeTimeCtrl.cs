public class TargetServeTimeCtrl
{
	public static bool HasGetServeTime;

	public static int serveTargetMoveTime;

	public static float realTimeGet;

	public static float deltaTimeGet;

	public static void ClearServeTime()
	{
	}

	public static void SaveTargetMoveTime(int _serveTargetMoveTime, bool enforce = false)
	{
	}

	public static void SaveTargetMoveTime(int _serveTargetMoveTime, float _deltaTime)
	{
	}

	public static bool ShouldUpdateTarget(float nativeTargetTime)
	{
		return false;
	}

	public static float GetTargetMoveTime()
	{
		return 0f;
	}
}
