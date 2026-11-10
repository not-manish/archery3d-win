using UnityEngine;

public class UI_PlayerInfo : MonoInstance<UI_PlayerInfo>, UIBase
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btBack;

	public UI_PlayerInfo_Info uiplayerInfo;

	public UI_PlayerInfo_AchievePoint uiAchievePoint;

	public UI_PlayerInfo_ArenaStats uiArenaStats;

	public UI_PlayerInfo_ChallengeStats uiChallengeStats;

	public UI_PlayerInfo_StatsRoyale uiStatsRoyale;

	public UIPanel uiScrollView;

	public UI_WaitLoading uiWaitLoading;

	public UserHeadData UserHeadData;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void UpdateState(PlayerData playerData)
	{
	}

	public void ResetPosition()
	{
	}

	public void UpdateAchievePoint()
	{
	}

	public void ShowStatsRoyale(PlayerInfoStatsRoyale playerInfoStatsRoyale)
	{
	}

	public void ShowArenaStats(PlayerInfoArenaStats playerInfoArenaStats)
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

	private void GetSuccess()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void ResPonse()
	{
	}
}
