using UnityEngine;

public class UI_ChestInfo : MonoInstance<UI_ChestInfo>, UIBase
{
	public enum ButtonStates
	{
		Null = 0,
		Unlock = 1,
		BuyTime_Unlocked = 2,
		BuyTime_Locked = 3,
		ShopBuy = 4
	}

	public UI_AnimationCtrl uiAnimationCtrl;

	public UISprite sChestIconBack;

	public UI_AnimationCtrl uiChestShowAnimationCtrl;

	public UILabel lGradeNum;

	public UILabel lChestName;

	public Transform tForFullWindow;

	public UIWidget wBackFrame;

	public UILabel lTotalCards;

	public UILabel lTotalAddCards;

	public GameObject oGuaranteedAll;

	public GameObject oGuaranteedOrange;

	public GameObject oGuaranteedPurple;

	public UILabel lGOrangeNum;

	public UILabel lGOrangeAdd;

	public UILabel lGPurpleNum;

	public UILabel lGPurpleAdd;

	public GameObject oArrowsAll;

	public GameObject oArrow1;

	public UISprite sArrow1;

	public UILabel lArrowNumAndName1;

	public GameObject oArrow2;

	public UISprite sArrow2;

	public UILabel lArrowNumAndName2;

	public UIButton btArrow1;

	public UIButton btArrow2;

	public UIButton btExit;

	public GameObject oButtonsAll;

	public GameObject oButtonBuy;

	public UI_LittleTips uiLittleTips_Buy;

	public UIButton btBuy;

	public UILabel lBuyDiamondWhite;

	public UILabel lBuyDiamondRed;

	public UILabel lFree;

	public UISprite sShopBuyPrice;

	public GameObject oButtonStartUnlock;

	public UIButton btStartUnlock;

	public UILabel lStartUnlockTime;

	public UILabel lStartUnlockTimeTips;

	public UILabel lStartWaiting;

	public GameObject oButtonBuyTime;

	public UIButton btBuyTime;

	public UI_LittleTips uiLittleTips_BuyTime;

	public GameObject oAnotherUnlicked;

	public GameObject oUnlockTimeLeft;

	public UILabel lTimeLeft;

	public UILabel lBuyTimeCost;

	private int GemCost;

	public UIButton btnWatchVideo;

	public UISprite sBtnVideo;

	public UILabel lTimeReduce;

	public GameObject oChestTimeLeft;

	public UILabel lChestTimeLeft;

	public UI_AnimationCtrl lChestTimeLeftAnim;

	public FlexibleRealTimeRegulator m_tWaitResponseTimeRegulator;

	public FlexibleRealTimeRegulator m_tWaitShowTimeRegulator;

	public GameObject oGuideBack;

	private ChallengeChestOriData challengeChestOriData;

	private int waitPoint;

	private bool hasSetScale;

	private UIChestInfoParam uiParam;

	private ButtonStates buttonState;

	private float guaranteedCardYtop;

	private float guaranteedCardYmiddle;

	private float guaranteedCardYdown;

	private int BackMaxWidth;

	private int GuarranteedWidth;

	private int ArrowOneWidth;

	private int ButtonWidth;

	private bool buttonEnable;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Show(object param)
	{
	}

	public void PlayChestShowAnim()
	{
	}

	private void UpdateState()
	{
	}

	private void UpdateState_HideAll()
	{
	}

	private bool SetButtonState()
	{
		return false;
	}

	private void SetButtonState_MainMenu()
	{
	}

	private void SetButtonState_ShopBuy()
	{
	}

	private void UpdateState_Guide()
	{
	}

	private void UpdateState_Classic()
	{
	}

	private void UpdateState_League()
	{
	}

	private void UpdateState_Challenge()
	{
	}

	private void SetPosition(bool HasGuaranteedCard, int ArrowKindNum, bool hasButton)
	{
	}

	private void SetGuaranteedCardsNumAndPos(int Segment, int OrangeMinNum, int PurpleMinNum)
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

	public void PlayerVideo(bool isFinish)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	private bool IsGemEnough()
	{
		return false;
	}

	public void GoToShopBuyGem()
	{
	}

	public void GoToShopBuyGold()
	{
	}

	public void JumpToShopBuyGemFromMainMenu()
	{
	}

	private static int GetCardExtraAdd(int Segment, int CardNum)
	{
		return 0;
	}

	private bool IsTutorial()
	{
		return false;
	}

	private void HideTutorial()
	{
	}

	private void ShowTutorial()
	{
	}

	public void UpdateChestUnLockResponse()
	{
	}

	public void VideoSubChestTimeResponse()
	{
	}

	public SpinABShow ABShow()
	{
		return (SpinABShow)0;
	}

	public bool isCanPlayVideo(int ChestKind)
	{
		return false;
	}
}
