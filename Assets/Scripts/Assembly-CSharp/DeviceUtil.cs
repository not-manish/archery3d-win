using UnityEngine;

public class DeviceUtil
{
	public static float fullscreenWidth;

	public static float fullscreenHeight;

	public static float ngui_Scale_Height;

	private static bool hasInit;

	public static float AdjustScaleX => 0f;

	public static float AdjustScaleY => 0f;

	public static bool IsStandardScreen()
	{
		return false;
	}

	public static void Init()
	{
	}

	public static Vector3 ResetPos(Vector3 pos)
	{
		return default;
	}

	public static Vector2 GetWidthHeightScale(Vector2 rect)
	{
		return default;
	}
}
