using UnityEngine;

public class UI_ArenaLevel_Select : MonoBehaviour
{
	public UI_ArenaLevel_Select_RewardList uiRewardList;

	public UI_ArenaLevel_Select_Tap uiTap;

	public UI_ArenaLevel_Select_EntryFee uiEntryFee;

	public UI_AnimationCtrl AnimInfoTips;

	public UI_AnimationCtrl uiRuleShowAnim;

	public UIPanel pRule;

	public UIButton btSelect;

	public UIButton btBack;

	public UIButton btnInfo;

	public UIButton btnCloseRules;

	private UnLockGameModeLevel unLockGameModeLevel;

	private UI_ArenaLevel uiArenaLevel;

	private bool hasSetScale;

	private ArenaType arenaType;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_ArenaLevel _uiArenaLevel, object param)
	{
	}

	private void ShowWindow(ArenaType _arenaType)
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

	public void SetLimitedTimeBuy()
	{
	}

	public void TapClicked(ArenaType arenaType)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
