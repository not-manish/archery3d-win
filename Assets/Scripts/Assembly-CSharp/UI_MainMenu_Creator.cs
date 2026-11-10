using UnityEngine;

public class UI_MainMenu_Creator : MonoBehaviour, UIBase
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

	public void Hide(object param)
	{
	}

	public void CheckPopupWindow(bool isShowEquip = false)
	{
	}

	public void CheckLimitedPopupWindow()
	{
	}

	public void HideEnforce()
	{
	}

	public void UpdateTutorial()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public bool IsMainMenuShowing()
	{
		return false;
	}

	public void CheckDailyBonus()
	{
	}

	public void ShowNewTips(NewTipsType newTipsType, int NewTips = 0)
	{
	}
}
