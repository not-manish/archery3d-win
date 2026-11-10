using UnityEngine;

public class InputPool
{
	public static bool IsTouchBegin;

	public static bool IsToucing;

	public static Vector2 TouchStartPos;

	public static Vector2 LastTouchPos;

	public static Vector2 CurTouchPos;

	public static bool IsTouchEnd;

	public static bool IsFocusCancel;

	public static void ClearTouch()
	{
	}
}
