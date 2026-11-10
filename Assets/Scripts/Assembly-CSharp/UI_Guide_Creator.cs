using UnityEngine;

public class UI_Guide_Creator : MonoBehaviour, UIBase
{
	public UICreator creator;

	private string prefabName;

	private static object _lock;

	public void Init()
	{
	}

	public void Show(object param)
	{
	}

	public void ShowGuideWindow(UIGuideWindows uiGuideWindows)
	{
	}

	public void SetCancelButtonActive(bool active)
	{
	}

	public void ShowCurWindAni()
	{
	}

	public void ShowHasShootTarget(int index)
	{
	}

	public void ShowHasShootScore()
	{
	}

	public void Hide(object param)
	{
	}

	public void HideEnforce()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void ShowCurScore(int Score, bool isMove = false)
	{
	}

	public bool IsPrizeShowing()
	{
		return false;
	}
}
