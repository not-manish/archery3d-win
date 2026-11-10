using System.Collections.Generic;
using UnityEngine;

public class UI_MiniGames_Spin : MonoBehaviour
{
	private float requestTime;

	private float MaxWaitRequestTime;

	public UIPanel pMainPanel;

	public UIButton btBack;

	public UIButton btSpinShop;

	public UIButton btSpinFree;

	public UIButton btSpin;

	public UIButton btChangeSpinFreeType;

	public UIButton btChangeSpinSpinType;

	public UISprite sSpinFreeType;

	public UISprite sSpinSuperType;

	public UISprite sLine;

	public UITexture texFreeBtnTop;

	public UITexture texFreeBtnMiddle;

	public UITexture texSuperBtnTop;

	public UITexture texSuperBtnMiddle;

	public GameObject btSpinWhite;

	public GameObject btSpinFreeWhite;

	public GameObject btSpinFreeGary;

	public UISprite sFreeVideoGray;

	public UISprite sFreeSpinGray;

	public GameObject btSpinGray;

	public GameObject oFreeGems;

	public UILabel lFreeGems;

	public UISprite sVideoTips;

	public UI_LittleTips uiLittleTips;

	public UISprite sFreeVideo;

	public UILabel lSpin;

	public UILabel FreeSpinTips;

	public GameObject oFreeTicket;

	public UILabel lFreeTime;

	public GameObject oFreeRoulette;

	public GameObject oPayRoulette;

	public Transform tGoldIcon;

	public Transform tDiamondIcon;

	public UILabel lGoldCount;

	public UILabel lDiamondCount;

	public UISprite RoulettSpinArrow;

	public UISprite RoulettSpinBigBg;

	public UISprite RoulettSpinMoveBg;

	public UIButton btnFreePrizeList;

	public UIButton btnSpinPrizeList;

	public UI_MiniGamesSpin_LuckyPoint FreeLuckyPoint;

	public UI_MiniGamesSpin_LuckyPoint SpinLuckyPoint;

	public UI_AnimationCtrl FreeShowAnimCtrl;

	public UI_AnimationCtrl SpinShowAnimCtrl;

	public UI_AnimationCtrl FreeHideAnimCtrl;

	public UI_AnimationCtrl SpinHideAnimCtrl;

	public GameObject FreeNormal;

	public GameObject FreeCircle;

	public GameObject FreeClickEffect;

	public GameObject FreeVideo;

	public UI_AnimationCtrl FreeNormalAnimCtrl;

	public UI_AnimationCtrl FreeCircleAnimCtrl;

	public UI_AnimationCtrl FreeClickAnimCtrl;

	public UI_AnimationCtrl FreeVideoAnimCtrl;

	public GameObject SpinNormal;

	public GameObject SpinCircle;

	public GameObject SpinClickEffect;

	public GameObject SpinCanRound;

	public UI_AnimationCtrl SpinNormalAnimCtrl;

	public UI_AnimationCtrl SpinCircleAnimCtrl;

	public UI_AnimationCtrl SpinClickAnimCtrl;

	public UI_AnimationCtrl SpinCanRoundAnimCtrl;

	public UI_AnimationCtrl ResultEffectAnimCtrl;

	public GameObject ResultEffect;

	public UI_AnimationCtrl SpinBtnAnimCtrl;

	public UI_AnimationCtrl FreeBtnAnimCtrl;

	public List<UI_MiniGames_PrizeItem> FreePrizeItemList;

	public List<UI_MiniGames_PrizeItem> SpinPrizeItemList;

	public Texture texTureFreeNormal;

	public Texture texTureFreeViedo;

	public Texture texTureFreeNormalFull;

	public Texture texTureFreeGem;

	public Texture texTureFreeGemFull;

	public Texture texTureFreeMiddleBlue;

	public Texture texTureFreeMiddleGreen;

	public Texture texTureSpinNormal;

	public Texture texTureSpinFull;

	public Texture texTureSpinMiddleRed;

	public Texture texTureSpinMiddleYellow;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public FlexibleRealTimeRegulator m_tWaitTime;

	public FlexibleRealTimeRegulator m_tShowAnimWaitTime;

	public FlexibleRealTimeRegulator m_tWaitErrorWaitTime;

	public long reqTransId;

	public FlexibleRealTimeRegulator m_tRequestWaitTimeRegulator;

	public FlexibleRealTimeRegulator m_tFlyPointWaitTime;

	public List<ParticleSystem> EffectGetSpinReward;

	public UI_MiniGamesSpin_Store uiMiniGamesSpinStore;

	public UI_MiniGamesSpin_Result uiMiniGamesSpinResult;

	public UI_MiniGames_PrizeList uiMiniGamesPrizeList;

	private GamblingRoulette gamblingRoulette;

	public UI_MiniGamesSpin_VideoTips uiMiniGamesSpinVideoTips;

	public UI_AnimationCtrl ui_AnimationCtrl;

	public ParticleSystem Spin_Free_PointFly;

	public UI_AnimationCtrl FreePointFlyAnimCtrl;

	public ParticleSystem Spin_Super_PointFly;

	public UI_AnimationCtrl SuperPointFlyAnimCtrl;

	public ParticleSystem SuperFull_BtnParticle;

	public ParticleSystem FreeFull_BtnParticle;

	public LuckyTurntable FreeluckyTurntable;

	public LuckyTurntable SpinluckyTurntable;

	public UI_LogoScroll uiFreeLogoScroll;

	public UI_LogoScroll uiSpinLogoScroll;

	public bool isFreeVideo;

	public GamblingRouletteCtrl.RouletteType RouletteType;

	private bool hasSetScale;

	private PlayerData playerdata;

	private long GoldCount;

	private long GemCount;

	private float t;

	private bool buttonEnable;

	public SpinType spinType;

	private bool isSetGary;

	public bool isFreeTimeEnd;

	private int index;

	public bool NotRespons;

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void ShowAnim()
	{
	}

	public void ShowAnimEnd()
	{
	}

	public void UpdatePlayerdate(TopUpdateGoldType topUpdateGoldType, PlayerData _playerdata = null)
	{
	}

	public void PlayerAddCoinAnim()
	{
	}

	public void UpdateInfo()
	{
	}

	public void isShowVideoTips()
	{
	}

	public void ChangeAltes(UIAtlas atlas)
	{
	}

	private void Update()
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

	public void ChangeRouletteType(GamblingRouletteCtrl.RouletteType toRouletteType)
	{
	}

	public void ChangeFreeSpinBtn(SpinType _spinType)
	{
	}

	public void SetFreePointFlyEnd()
	{
	}

	public void SetSpinPointFlyEnd()
	{
	}

	private void ButtonOnPress(GameObject button, bool down)
	{
	}

	public void GoToShopBuyGem()
	{
	}

	public void SpinClickAnimEnd()
	{
	}

	public void PlayerVideoFinish(bool isFinished)
	{
	}

	public void FreeVideoClickAnimEnd()
	{
	}

	public void FreeClickAnimEnd()
	{
	}

	public void AnimFinishBtnShowGary()
	{
	}

	public void PlayerVideo()
	{
	}

	public void CloseFreeVideo()
	{
	}

	public void AfterGetRewardChangeBtn()
	{
	}

	public void ChangeBtnTexture()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	private void UpdateTimeLeft()
	{
	}

	public bool GetRewardSuccess()
	{
		return false;
	}

	public void WaitErroTime()
	{
	}

	public void SetTipAction()
	{
	}

	public void AnimEnd()
	{
	}

	public void GetRewardEffect(bool isShow)
	{
	}

	public void HideEffect()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void RestFreeNormalAnim()
	{
	}

	public void RestSpinNormalAnim()
	{
	}

	public void RestFreeMoveAnim()
	{
	}

	public void RestSpinMoveAnim()
	{
	}

	public void RestAnim(object RestAnimType = null)
	{
	}

	public bool GetRespons()
	{
		return false;
	}

	public SpinABShow ABShow()
	{
		return (SpinABShow)0;
	}
}
