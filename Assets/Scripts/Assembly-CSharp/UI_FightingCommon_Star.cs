using System.Collections.Generic;
using UnityEngine;

public class UI_FightingCommon_Star : MonoBehaviour
{
	public List<UI_AnimationCtrl> uiRightStar;

	public List<UI_AnimationCtrl> uiLeftStar;

	public Transform StarParent;

	private TweenPosition tweenPosition;

	private UIStarParam uiStarParam;

	private FlexibleRealTimeRegulator realTimeRegulatorLeft;

	private FlexibleRealTimeRegulator realTimeRegulatorRight;

	public void Show(object param)
	{
	}

	public Vector3 MoveAnimPosition(Vector3 position, Transform target)
	{
		return default;
	}

	private void Update()
	{
	}

	public void UpdateStar(object param)
	{
	}

	public void Hide(object param)
	{
	}

	private void LeftAnimationFinished()
	{
	}

	private void RightAnimationFinished()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
