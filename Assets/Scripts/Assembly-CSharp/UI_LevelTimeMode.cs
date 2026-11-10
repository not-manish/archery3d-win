using UnityEngine;

public class UI_LevelTimeMode : MonoInstance<UI_LevelTimeMode>, UIBase
{
	public UIButton btBack;

	public UIButton btInfo;

	public UI_LevelTimeMode_List uiLevelList;

	public UI_AnimationCtrl btInfoTips;

	private UnLockGameModeLevel unLockGameModeLevel;

	public UI_AnimationCtrl uiAnimationCtrl;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void KeyEscapeClicked()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	private void ButtonCommonClicked(ButtonType buttonType)
	{
	}

	private void CreateItems(object param, UnLockGameModeLevel _unLockGameModeLevel)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
