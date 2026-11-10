using System;
using System.Collections.Generic;
using UnityEngine;

public class GoldParticleSc : MonoBehaviour
{
	public ParticleSystem goldParticleSys;

	public ParticleFlyToTarget goldFlyToTarget;

	public ParticleSystem starParticleSys;

	public ParticleFlyToTarget starFlyToTarget;

	private Transform targetTransform;

	public void GetObject()
	{
	}

	public void setParticleValue()
	{
	}

	public void SetParticleInfo(int goldMaxCnt, float startLifeTime, float bTime, float alphaTime)
	{
	}

	public void SetTargetTransform(Transform targetTransform)
	{
	}

	public void SetSingleParticleFinishFlyCallBack(List<Action> flyToTargetCallBack)
	{
	}

	public void Play()
	{
	}

	private void UpdateScaleAndTargetInfo()
	{
	}

	public void Hide()
	{
	}
}
