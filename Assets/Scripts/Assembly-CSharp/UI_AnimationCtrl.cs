using UnityEngine;

public class UI_AnimationCtrl : MonoBehaviour
{
	public delegate void AnimationInFinishListener();

	public delegate void AnimationOutFinishListener();

	public UI_AnimationCtrl uiChildAni;

	public UI_AnimationCtrl[] uiMoreChildAni;

	private TweenAlpha tweenAlpha;

	private TweenColor tweenColor;

	private TweenScale tweenScale;

	private TweenTransform tweenTransform;

	private TweenPosition tweenPosition;

	private TweenRotation tweenRotation;

	private UIAnimationType animationType;

	private FlexibleRealTimeRegulator realTimeRegulatorIn;

	private FlexibleTimeRegulator timeRegulatorIn;

	private FlexibleRealTimeRegulator realTimeRegulatorOut;

	private FlexibleTimeRegulator timeRegulatorOut;

	private AnimationInFinishListener AnimationInListener;

	private AnimationOutFinishListener AnimationOutListener;

	private float totalTime;

	private UITweener maxTimeAnim;

	private bool HideSetFalse;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Show(UIAnimationType _animationType = UIAnimationType.All, AnimationInFinishListener _AnimationInListener = null, AnimationOutFinishListener _AnimationOutListener = null)
	{
	}

	public void Hide(bool SetActive, AnimationOutFinishListener _AnimationOutListener = null)
	{
	}

	private void PlayInAnimation()
	{
	}

	public void OnFinishedIn()
	{
	}

	private void PlayOutAnimation()
	{
	}

	public void OnFinishedOut()
	{
	}

	public void SetActive(bool active)
	{
	}

	public void SetAniEnable(bool Enable)
	{
	}

	public void ResetAniToBegin()
	{
	}

	public void setAniSample(float value, bool isChildSample = true)
	{
	}

	public void ClearAnimData()
	{
	}
}
