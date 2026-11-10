using UnityEngine;

public class UI_ScreenTouch : MonoBehaviour
{
	public delegate void OnDragDelegate(Vector2 delta);

	public delegate void OnPressDelegate(bool isPress);

	public delegate void OnTouchPosDelegate(Vector2 screenPos);

	private bool useUICameraDrag;

	private OnDragDelegate dragDelegate;

	private OnPressDelegate pressDelegate;

	private OnTouchPosDelegate touchPosDelegate;

	public static int curTouchID;

	private const int InvalidTouchId = -10000;

	public bool UseUICameraDrag
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public OnDragDelegate DragDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public OnPressDelegate PressDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public OnTouchPosDelegate TouchPosDelegate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void ClearTouch()
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnPress(bool press)
	{
	}

	private void OnTouchPos(Vector2 curPos)
	{
	}
}
