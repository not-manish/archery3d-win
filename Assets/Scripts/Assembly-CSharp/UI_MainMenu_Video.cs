using UnityEngine;
using com.simple.proto;

public class UI_MainMenu_Video : MonoBehaviour
{
	private enum ShowInType
	{
		Null = 0,
		Video = 1,
		Challenge = 2
	}

	public UIButton btnPlayVideo;

	public UISprite sVideoItemIcon;

	public UILabel lRewardNum;

	public UILabel lRewardNumBg;

	private string sprite;

	public UISprite sChallengeBg;

	public UIButton btnPlayChallenge;

	public UILabel lChallengeTime;

	public UILabel lChallengeTimebg;

	public UI_AnimationCtrl uiAnimationCtrl;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public TweenPosition tweenPosition;

	public float DurationTime;

	public float WaitingTime;

	private bool isChallengeOpen;

	private ShowInType NowShowInType;

	private bool buttonEnable;

	private CCWatchVideoSuccessResponse WatchVideoSuccess;

	public float time;

	public bool isBack;

	private void Start()
	{
	}

	public bool isShowPlayVideo()
	{
		return false;
	}

	private void ChangeShowtype(ShowInType _nowShowInType, bool isPlayAnim = true)
	{
	}

	public void UpdateState()
	{
	}

	public void Show()
	{
	}

	private void ShowAnim(ShowInType showInType, bool isPlayAnim = true)
	{
	}

	public void HideAnim()
	{
	}

	public bool isShowing()
	{
		return false;
	}

	public bool isHide()
	{
		return false;
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

	public void GetDaily()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void PlayerVideoFinish(bool isFinished)
	{
	}

	public bool GetRespones()
	{
		return false;
	}

	private void Update()
	{
	}

	private void UpdateTimeLeft()
	{
	}

	public bool CheckIsChallengeStart()
	{
		return false;
	}

	public bool IsChallengeOpening()
	{
		return false;
	}
}
