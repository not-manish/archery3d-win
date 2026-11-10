using System;
using UnityEngine;

public class TargetBrokenAni : MonoBehaviour
{
	public Animation ani;

	public ParticlePlayCtrl particlePlayCtrl;

	public float durationTime;

	private Action<TargetBrokenAni> FinishedListener;

	private FlexibleTimeRegulator m_tRegulator;

	[HideInInspector]
	public TargetKind targetKind;

	[HideInInspector]
	public int targetType;

	public void PlayAnimation(TargetKind _targetKind, int _targetType, Action<TargetBrokenAni> _FinishedListener)
	{
	}

	private void Update()
	{
	}
}
