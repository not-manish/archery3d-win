using UnityEngine;

public class UIScrollViewDouble : MonoBehaviour
{
	public enum State
	{
		Judgeing = 0,
		DownVer = 1,
		HopHor = 2
	}

	public UIScrollViewMy DownVerScroll;

	public UIScrollViewMy TopHorScroll;

	public State state;

	public void OnPress(UIScrollViewMy touchLayer, bool Pressed)
	{
	}

	public void OnDrag()
	{
	}
}
