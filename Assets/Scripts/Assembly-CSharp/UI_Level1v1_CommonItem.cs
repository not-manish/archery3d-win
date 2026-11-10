using System;
using UnityEngine;

public class UI_Level1v1_CommonItem : MonoBehaviour
{
	public UILabel lGrade;

	public UILabel lTrophyGetAndMax;

	public UILabel lWinPrize;

	public UILabel lWinTrophy;

	public UILabel lLoseTrophy;

	public UILabel lEntryFee;

	public UIButton btBackground;

	public UIButton btVideo;

	public GameObject oBestOf;

	public UILabel lBestOf;

	public GameObject oButtonVideo;

	private int index;

	private int levelID;

	private GameType gameType;

	private PvpType pvpType;

	private bool hasSetScale;

	private UI_Level1v1_Lock uiLock;

	[HideInInspector]
	public UI_Friends_LogIn_Item uiFriendsLogInItem;

	public GameObject oLockObject;

	public GameObject oUnLockLabel;

	public UILabel lLockGetTrophy;

	public UIButton btnTrophy;

	public GameObject oTrophyTips;

	public UI_AnimationCtrl uiAnimationCtrl;

	public UILabel liconTips;

	private float showTime;

	public FlexibleRealTimeRegulator m_tWaitTime;

	private TrophyTip trophyTip;

	public Transform sTrophyIcon;

	public Transform sWinTrophyIcon;

	public Transform sWinGoldIcon;

	public UI_Finger_Click uiFingerClick;

	public UI_Level1v1_Info uiInfo;

	public UI_Level1v1_Ani uiAni;

	private UIGameType1V1 gameType1v1;

	public UI_1v1_Level_UnlockAnimCtrl ui1v1LevelUnlockAnimCtrl;

	public LevelSprtieAtlasType levelSprtieAtlasType;

	public UI_Level_1v1_Common_SpriteCtrl uiLevelCommonSpriteCtrl;

	public UISprite sTrophyProgress;

	private Action ClickInfoAction;

	public UI_AnimationCtrl NumAddAnimCtrl;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public FlexibleRealTimeRegulator m_tRewardTimeRegulator;

	public FlexibleTimeRegulator m_tProgressTimeRegulator;

	public FlexibleRealTimeRegulator m_tDownloadTime;

	private UpdateTrophy updateTrophy;

	private bool isShowAddAnim;

	public UI_Downloading_Tips uiDownloadingTips;

	private string SceneName;

	private SingleFileState isNeedDown;

	private UIScrollView scrollView;

	private UIGrid uiGrid;

	private bool ShouldShowVideoButton;

	private UI_Level1v1_Unlock uiLevel1v1Unlock;

	private float t;

	public void Show(int _index, GameType _gameType, int _levelID, UIGameType1V1 _gameType1v1, bool _isShowAddAnim = false, Action _ClickInfoAction = null)
	{
	}

	public void UpdateState()
	{
	}

	private void UpdateState_Classic()
	{
	}

	private void UpdateState_Rush()
	{
	}

	private void UpdateState_Bingo()
	{
	}

	private void LoadAndShowLock()
	{
	}

	public void setProgressColor(bool isFull)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void UpdateScale()
	{
	}

	public void CheckIsDownloading()
	{
	}

	public void ShowUnlock(SingleFileState singleFileState)
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

	public void OnDragItem(GameObject go, Vector2 delta)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public string GetTips()
	{
		return null;
	}

	public void ShowTrophyTips(string tipString)
	{
	}

	public void AnimFinishHide()
	{
	}

	public void PlayerVideoFinish(bool isFinished)
	{
	}

	public bool GetRespones()
	{
		return false;
	}

	public int GetBetGold()
	{
		return 0;
	}

	public static int GetCommon1V1BetGold(MatchType matchType, GameType gameType, int levelID)
	{
		return 0;
	}

	public void GoToShopBuyGold()
	{
	}

	public LevelUIState GetUIState()
	{
		return LevelUIState.Normal;
	}

	public void SetLevelItemState(LevelUIState state, bool enforce)
	{
	}

	private void LoadUnLockAnimPlayShow()
	{
	}

	public void PlayerUnLockLevelAnim()
	{
	}

	public void PlayGameRewardData()
	{
	}

	private void LateUpdate()
	{
	}

	public void PlayerValueUpgrade(int AddValue, int ownedValue, int maxValue, float oldcardProgressValue, float cardProgressValue, float time)
	{
	}

	public void OpenCoinGemAnim(ChestRewardType rewardType, int ShowObjCount, Transform _endPosition, ref int moveCount)
	{
	}

	public void CheckLimitedTimeBuy()
	{
	}
}
