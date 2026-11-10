using UnityEngine;

public class UI_Matching : MonoInstance<UI_Matching>, UIBase
{
	public enum UIMatchingState
	{
		Null = 0,
		ShowingGuideReward = 1,
		WaitingFriendAnswer = 2,
		WaitingFriendSuccess = 3,
		WaitingFriendFailed = 4,
		Matching = 5,
		Rematching = 6,
		MatchedUpdatePlayerInfo = 7,
		MatchedDelGoldAni = 8,
		MatchedPlayingAni = 9,
		MatchedFinished = 10
	}

	public UIButton btBack;

	public GameObject oBack;

	private FlexibleRealTimeRegulator m_tRealtimeRegulator;

	public GameObject oTips;

	public UILabel lGameTips;

	public UI_AnimationCtrl uiTipShowAnim;

	public PlayerHeadShow sPhotoMy;

	public UILabel lNameMy;

	public UILabel lBetGoldMy;

	public UILabel lTrophyMy;

	public UILabel lSearching;

	public UILabel lNameOpp;

	public UILabel lBetGoldOpp;

	public UILabel lTrophyOpp;

	public UISprite sBetGoldMy;

	public UISprite sBetGoldOpp;

	public UISprite sSumPrize;

	public UILabel lSumPrize;

	private float sub_dec;

	private float temp_gold;

	private int beg_gold;

	private int sum_gold;

	public UISprite oMyTrophy;

	public UISprite oOtherTrophy;

	public GameObject oOtherGold;

	public GameObject oMyGold;

	public GameObject oSumGold;

	public UISprite sLogo;

	public GameObject oClassicMode;

	public GameObject oClassic_PanDian;

	public GameObject oClassic_HuiHe;

	public GameObject oRushMode;

	public GameObject oBingoMode;

	public GameObject oArenaMode;

	public GameObject oArena_PanDian;

	public GameObject oArena_HuiHe;

	public GameObject oArena_Rush;

	public GameObject oGameNormal;

	public GameObject oGameFrineds;

	public UILabel lFriendsWaitingWords;

	public UILabel lFriendsAcceptWords;

	public UILabel lFriendsDeclinedWords;

	public UI_Matching_OppPhoto uiOppPhoto;

	public TweenScale GoldTweenScale;

	public UI_AnimationCtrl uiBackBtnHideAnim;

	public UI_AnimationCtrl uiBackBtnShowAnim;

	public UI_AnimationCtrl uiGoldShowAnim;

	public UI_AnimationCtrl uiMyGoldDelAnim;

	public UI_AnimationCtrl uiOppGoldDelAnim;

	public UI_AnimationCtrl uiSumGoldAddAnim;

	public UI_AnimationCtrl uiAnimationCtrl;

	private UIMatchingState curState;

	private UIMatchParam uiMatchParam;

	private FlexibleTimeRegulator m_tTimeRegulator;

	private int SearchingPointNum;

	private float matchRequestUPdateTime;

	private float matchGuideUPdateTime;

	private FlexibleTimeRegulator m_tMatchingRequestUpdate;

	private float t;

	private float Animtime;

	private bool hasSetScale;

	private bool buttonEnable;

	private const int FRIEND_BET_MAX_COIN = 10000;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlayerTopAdd()
	{
	}

	public void SumAdd()
	{
	}

	public void Show(object param)
	{
	}

	public void AnimFinished()
	{
	}

	private void UpdateGameModeState(int levelIndex = -1)
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

	private void SetState(UIMatchingState state)
	{
	}

	public void SetHasFoundAdversaryUI()
	{
	}

	public static int GetBetNumber(MatchType matchType, GameType gameType, int levelID)
	{
		return 0;
	}

	public bool IsShowing()
	{
		return false;
	}

	public bool MatchResponse()
	{
		return false;
	}

	public bool MatchConfirmResponse()
	{
		return false;
	}

	public static bool GlobalMatchConfirmResponse()
	{
		return false;
	}

	public void SetBackBtnHide()
	{
	}

	public void RsetAnimValue()
	{
	}

	public void IsInMatchingResponse()
	{
	}

	public void OpenCoinGemAnim(int ShowObjCount)
	{
	}

	public void ShowTips(bool isShow)
	{
	}
}
