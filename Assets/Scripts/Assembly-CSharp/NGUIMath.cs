using System.Diagnostics;
using UnityEngine;

public static class NGUIMath
{
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static float Lerp(float from, float to, float factor)
	{
		return 0f;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int ClampIndex(int val, int max)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int RepeatIndex(int val, int max)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static float WrapAngle(float angle)
	{
		return 0f;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static float Wrap01(float val)
	{
		return 0f;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static int HexToDecimal(char ch)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static char DecimalToHexChar(int num)
	{
		return '\0';
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string DecimalToHex(int num)
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static int ColorToInt(Color c)
	{
		return 0;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static Color IntToColor(int val)
	{
		return default;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string IntToBinary(int val, int bits)
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static Color HexToColor(uint val)
	{
		return default;
	}

	public static Rect ConvertToTexCoords(Rect rect, int width, int height)
	{
		return default;
	}

	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round)
	{
		return default;
	}

	public static Rect MakePixelPerfect(Rect rect)
	{
		return default;
	}

	public static Rect MakePixelPerfect(Rect rect, int width, int height)
	{
		return default;
	}

	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea)
	{
		return default;
	}

	public static Bounds CalculateAbsoluteWidgetBounds(Transform trans)
	{
		return default;
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform trans)
	{
		return default;
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive)
	{
		return default;
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content)
	{
		return default;
	}

	public static Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive)
	{
		return default;
	}

	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime)
	{
		return default;
	}

	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime)
	{
		return default;
	}

	public static float SpringLerp(float strength, float deltaTime)
	{
		return 0f;
	}

	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		return 0f;
	}

	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime)
	{
		return default;
	}

	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		return default;
	}

	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		return default;
	}

	public static float RotateTowards(float from, float to, float maxAngle)
	{
		return 0f;
	}

	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b)
	{
		return 0f;
	}

	public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos)
	{
		return 0f;
	}

	public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam)
	{
		return 0f;
	}

	public static Vector2 GetPivotOffset(UIWidget.Pivot pv)
	{
		return default;
	}

	public static UIWidget.Pivot GetPivot(Vector2 offset)
	{
		return UIWidget.Pivot.TopLeft;
	}

	public static void MoveWidget(UIRect w, float x, float y)
	{
	}

	public static void MoveRect(UIRect rect, float x, float y)
	{
	}

	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight)
	{
	}

	public static void ResizeWidget(UIWidget w, UIWidget.Pivot pivot, float x, float y, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top)
	{
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight)
	{
	}

	public static void AdjustWidget(UIWidget w, float left, float bottom, float right, float top, int minWidth, int minHeight, int maxWidth, int maxHeight)
	{
	}

	public static int AdjustByDPI(float height)
	{
		return 0;
	}

	public static Vector2 ScreenToPixels(Vector2 pos, Transform relativeTo)
	{
		return default;
	}

	public static Vector2 ScreenToParentPixels(Vector2 pos, Transform relativeTo)
	{
		return default;
	}
}
