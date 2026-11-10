using System;
using System.Collections.Generic;
using UnityEngine;

public class TargetLightShowCtrl : MonoBehaviour
{
	public Transform LightParent;

	public List<GameObject> AllTargetLights;

	private Action<TargetLightShowCtrl> FinishedListener;

	private FlexibleTimeRegulator m_tRegulator;

	private bool isShowAnim;

	private bool IsLoop;

	private int count;

	private float time;

	private float Changetime;

	private float BingoChangetime;

	public void PlayEffect(List<int> childcoun, float showtime, Action<TargetLightShowCtrl> _FinishedListener, bool isLoop = false)
	{
	}

	private void Update()
	{
	}

	private void Play(List<int> childcount, float showtime, bool isLoop = false)
	{
	}

	public void HideAllTargetLights()
	{
	}

	public void LoadAllTargetLights()
	{
	}

	public void StopEffect()
	{
	}
}
