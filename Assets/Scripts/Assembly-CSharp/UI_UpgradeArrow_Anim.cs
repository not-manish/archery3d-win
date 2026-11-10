using System.Collections.Generic;
using UnityEngine;

public class UI_UpgradeArrow_Anim : MonoBehaviour
{
	[HideInInspector]
	public TweenScale ScaleAnims;

	[HideInInspector]
	public TweenPosition PositionAnims;

	public List<AnimationCurve> AnimCurve;

	private int TweenGroup;

	private float AnimTime;

	private float MoveHeight;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public FlexibleRealTimeRegulator m_tTimeRegulatorAnimEnd;

	public ArrowAnimType arrowAnimType;

	public bool isEnablePlayingAnim;

	private void Awake()
	{
	}

	public void GetMoveAnim()
	{
	}

	public float GetMovePosition(float MaxHeight)
	{
		return 0f;
	}

	public void SetAnimValue(UITweener tween, AnimationCurve animationCurve, float duration, float DeltyTime = 0f)
	{
	}

	private void Update()
	{
	}

	public void AnimPlayerFinish()
	{
	}

	private void OnEnable()
	{
	}

	public void PlayAnim()
	{
	}

	private void OnDisable()
	{
	}
}
