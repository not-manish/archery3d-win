using System.Collections.Generic;
using UnityEngine;

public class TargetCtrl : MonoBehaviour
{
	public TargetBase targetBase;

	public int serveID;

	[HideInInspector]
	public int targetScore;

	[HideInInspector]
	public TargetKind targetKind;

	[HideInInspector]
	public int TargetTypeID;

	private List<int> scoreSelf;

	private FlexibleTimeRegulator m_timeRegulatorSelf;

	private List<int> scoreOpp;

	private FlexibleTimeRegulator m_timeRegulatorOpp;

	public TargetLightShowCtrl targetLightShowCtrl;

	public bool IsBingoTarget()
	{
		return false;
	}

	public float GetTargetBarZ()
	{
		return 0f;
	}

	public Vector3 GetTargetBarCenter()
	{
		return default;
	}

	public Transform GetTargetTransform()
	{
		return null;
	}

	public Transform GetTargetArrowsParent()
	{
		return null;
	}

	public void ArrowArriveBar(ArrowFly arrowFly, Vector3 hitPosition)
	{
	}

	public void ShowScore(ArrowFly arrowFly, List<int> _score)
	{
	}

	private void Update()
	{
	}

	public void PlayLightAnim(List<int> score, float showTime, bool isLoop = false, bool isMyself = true)
	{
	}

	public void HideLightAnim()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}

	public int CalculateScore(Vector3 worldHitPos, Vector3 worldTargetForward, Vector3 worldTargetTop)
	{
		return 0;
	}

	public float PlayRecoverAni()
	{
		return 0f;
	}

	public float PlayAppearAni()
	{
		return 0f;
	}

	public float PlayDisappearAni()
	{
		return 0f;
	}
}
