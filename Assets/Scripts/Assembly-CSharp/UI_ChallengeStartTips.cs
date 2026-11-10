using UnityEngine;

public class UI_ChallengeStartTips : MonoInstance<UI_ChallengeStartTips>, UIBase
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btYes;

	public UIButton btContinue;

	public UIButton btNo;

	private string sprite;

	public UISprite sChallengeBg;

	public GameObject oStartTime;

	public UILabel lTips;

	public UILabel lTipsBg;

	public UILabel lTipsSmall;

	public UILabel lTipsSmallBg;

	public UILabel lStartTimeLeft;

	public UILabel lStartTimeLeftbg;

	public FlexibleRealTimeRegulator m_tRegulator;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void ShowTips()
	{
	}

	private void CheckChallengeState()
	{
	}

	private void Update()
	{
	}

	private void SetChallengeTime(bool isOpening, long LeftTimeMil)
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
}
