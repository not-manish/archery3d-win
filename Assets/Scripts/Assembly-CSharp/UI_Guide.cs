using UnityEngine;

public class UI_Guide : MonoInstance<UI_Guide>, UIBase
{
	public UI_AnimationCtrl WelcomeAniCtrl;

	public GameObject WelcomeGO;

	public UI_AnimationCtrl HintPressAniCtrl;

	public GameObject HintPressGO;

	public GameObject HintPress_Bottom;

	public GameObject HintPress_LAim;

	public GameObject HintPress_LLearnShoot;

	public UI_AnimationCtrl HitTargetTwiceAniCtrl;

	public GameObject HitTargetTwiceGO;

	public UILabel lHitTargetWindSpeed;

	public UILabel lHitTargetWindSpeedbg;

	public UISprite sHitTargetWindAngle;

	public UI_AnimationCtrl oHitTargetWindAni;

	public GameObject oHitTarget1Before;

	public GameObject oHitTarget1After;

	public UI_AnimationCtrl oHitTarget1AfterAni;

	public GameObject oHitTarget2Before;

	public GameObject oHitTarget2After;

	public UI_AnimationCtrl oHitTarget2AfterAni;

	public UI_AnimationCtrl FingerAniCtrl;

	private FlexibleRealTimeRegulator FingerRegulatorIn;

	public UI_AnimationCtrl GreatJobAniCtrl;

	public GameObject GreatJobGO;

	public UIButton btGreatJobGO;

	public UI_AnimationCtrl PrizeAniCtrl;

	public GameObject PrizeGO;

	public UI_Guide_Prize uiPrize;

	public UI_AnimationCtrl RetryAniCtrl;

	public GameObject RetryGO;

	public UI_AnimationCtrl WindHintsAniCtrl;

	public GameObject WindHintsGO;

	public UILabel lWindSpeed;

	public UILabel lWindSpeedbg;

	public UISprite sWindAngle;

	public UIButton btWindContinues;

	public UI_Guide_ScoreCtrl uiGuideScoreCtrl;

	public UIButton btStart;

	public UICancelButton uiCancelButton;

	public UITexture[] GuideAllBg;

	private PlayerData playerdata;

	private UIGuideParam uiParam;

	private bool hasSetScale;

	private UIGuideWindows guideState;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void HideConstantSub()
	{
	}

	private void HideAllSub()
	{
	}

	public void ShowGuideWindow(UIGuideWindows _guideState)
	{
	}

	public void SetCancelButtonActive(bool active)
	{
	}

	public void ShowCurWindAni()
	{
	}

	public void ShowHasShootScore()
	{
	}

	public void FingerShowEnd()
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

	public void OnPressScreen(bool press)
	{
	}

	public void OnTouchScreen(Vector2 pos)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void ShowCurScore(int score, bool isMove)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public bool IsPrizeShowing()
	{
		return false;
	}
}
