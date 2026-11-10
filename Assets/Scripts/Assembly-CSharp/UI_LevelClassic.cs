using UnityEngine;

public class UI_LevelClassic : MonoInstance<UI_LevelClassic>, UIBase
{
	public UIButton btBack;

	public UIButton btInfo;

	public UI_LevelClassic_List uiLevelList;

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

	private void CreateItems(object param, UnLockGameModeLevel _unLockGameModeLevel)
	{
	}

	private void ButtonCommonClicked(ButtonType buttonType)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
