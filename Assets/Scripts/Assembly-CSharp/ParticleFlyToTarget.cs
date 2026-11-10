using System;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFlyToTarget : MonoBehaviour
{
	private Vector3 targetPosition;

	private ParticleSystem particleSys;

	private ParticleSystem.Particle[] particles;

	private Vector3[] particlePositionAry;

	private bool[] particleFinishFlyFlagAry;

	private List<Action> finishFlyCallBack;

	public float bounceTime;

	private float alphaTime;

	private Quaternion EndRotition;

	private float flySpeed;

	private void Awake()
	{
	}

	private void NewAry()
	{
	}

	public void SetSingleParticleFinishFlyCallBack(List<Action> callBack)
	{
	}

	public void SetParticleInfo(int maxParticles, float startLifeTime, float bTime, float alphaTime)
	{
	}

	public void SetParticleInfo(float startLifeTime, float bTime, float alphaTime)
	{
	}

	public void UpdateTargetTransform(Transform targetTransform)
	{
	}

	private void Update()
	{
	}

	private void ToCallBack(float time)
	{
	}

	public void PlayCallBackEnd()
	{
	}
}
