using UnityEngine;

public class UI_GameMode : MonoInstance<UI_GameMode>, UIBase
{
	public UIButton btBack;

	public UIButton btSingle;

	public UIButton btClassicMode;

	public LabelFlashScroll SClassNew;

	public UIButton btTimeMode;

	public LabelFlashScroll STimeNew;

	public UIButton btBingo;

	public LabelFlashScroll SBingoNew;

	public UIButton btArena;

	public UIButton btChallenge;

	public UILabel lArenaWinNum;

	public UILabel lArenaLoseNum;

	public UI_GameMode_Lock uiRushGameModeLock;

	public UI_GameMode_Lock uiBingoGameModeLock;

	public UI_GameMode_Lock uiArenaGameModeLock;

	public UI_GameMode_Lock uiChallengeGameModeLock;

	public UI_LittleTips uiRushLittleTips;

	public UI_LittleTips uiBingoLittleTips;

	public UI_LittleTips uiArenaLittleTips;

	public UI_LittleTips uiChallengeLittleTips;

	private float UnlockAnimtime;

	private float ChangeAnimPanelLeveltime;

	private float MaxUnlockAnimtime;

	public UI_GameMode_Challenge uiChallenge;

	public UI_AnimationCtrl uiAnimationCtrl;

	public UILabel lSingleModeStat;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private UnLockGameMode unLockGameMode;

	private UnLockGameModeLevel unLockGameModeLevel;

	public UI_Finger_Click uiFingerClick;

	private UIGameModeState uiGameModeState;

	private PlayerData playerData;

	private bool hasSetScale;

	private bool ShowClassic;

	private int count;

	private UIGameModeState last;

	public UIPanel MaxTopPanel;

	public UIPanel uiPanel;

	public GameObject oOfflinePanel;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void getPlayerAnimCount()
	{
	}

	public void CheckGameModeIsLock()
	{
	}

	public void ChangeState(UIGameModeState _uiGameModeState)
	{
	}

	private void Update()
	{
	}

	private void SetUIOfflinePanel()
	{
	}

	private void SetMaxTopPanel(bool isActive)
	{
	}

	public void RefreshPanel()
	{
	}

	public void ShowHand()
	{
	}

	private void UpdateState()
	{
	}

	public string GetSingleMode()
	{
		return null;
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

	public bool IsShowing()
	{
		return false;
	}

	public void UpdatePlayerInfo(bool updateMoney)
	{
	}
}
