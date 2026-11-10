using System;
using UnityEngine;

public class BaseWindow : MonoBehaviour
{
	public enum WindowState
	{
		appearing = 0,
		finish_appearing = 1,
		disappearing = 2,
		disappeared = 3
	}

	public GameObject windowTopCollideGo;

	protected Action expectedRunnable;

	protected WindowState windowState;

	protected bool hasInitForOnce;

	protected bool exit;

	protected virtual void Awake()
	{
	}

	public virtual void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void InitForOnce()
	{
	}

	public void InitBaseWindow()
	{
	}

	public void SetWindowTouchable(bool value)
	{
	}

	public bool IsShowAble()
	{
		return false;
	}

	protected void BaseShow()
	{
	}

	public bool IsHideAble()
	{
		return false;
	}

	protected void BaseHide()
	{
	}

	private GameObject GetWindowTopCollideGo()
	{
		return null;
	}

	protected virtual void OnFinishAppearing()
	{
	}

	protected virtual void OnFinishDisappearing()
	{
	}

	public void SetDisappeared()
	{
	}

	public bool IsWindowNotNeedUpdate()
	{
		return false;
	}

	public virtual void Back()
	{
	}

	public void NullExpectedRunnable()
	{
	}

	protected bool IsUpdateable()
	{
		return false;
	}

	protected bool IsWindowTouchable()
	{
		return false;
	}

	public bool IsFinishAppearing()
	{
		return false;
	}

	public virtual void HideWithAction(Action action)
	{
	}

	public void ForceHide()
	{
	}

	public bool IsInNormalDisplay()
	{
		return false;
	}
}
