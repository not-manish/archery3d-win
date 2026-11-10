using System;
using System.Collections.Generic;
using UnityEngine;

public class CoinGemAnimCtrData
{
	public ChestRewardType rewardType;

	public int LeftCoinGemCount;

	public Transform LeftgoldStartTf;

	public Transform LeftgoldFlyTargetTf;

	public int RightCoinGemCount;

	public Transform RightgoldStartTf;

	public Transform RightgoldFlyTargetTf;

	public float startLifetime;

	public float bounceTime;

	public float alphaTime;

	public List<Action> AnimationInListener;

	public CoinGemAnimCtrData()
	{
	}

	public CoinGemAnimCtrData(ChestRewardType _rewardType, int _LeftCoinGemCount, Transform _LeftgoldStartTf, Transform _LeftgoldFlyTargetTf, int _RightCoinGemCount, Transform _RightgoldStartTf, Transform _RightgoldFlyTargetTf, float _startLifetime, float _bounceTime, float _alphaTime, Action _AnimationInListener = null)
	{
	}

	public void SetLeftCoinGemAnimCtrData(ChestRewardType _rewardType, int _LeftCoinGemCount, Transform _LeftgoldStartTf, Transform _LeftgoldFlyTargetTf, float _startLifetime, float _bounceTime, float _alphaTime, Action _AnimationInListener = null)
	{
	}

	public void SetRightCoinGemAnimCtrData(ChestRewardType _rewardType, int _RightCoinGemCount, Transform _RightgoldStartTf, Transform _RightgoldFlyTargetTf, float _startLifetime, float _bounceTime, float _alphaTime, Action _AnimationInListener = null)
	{
	}

	public bool isPlayLeft()
	{
		return false;
	}

	public bool isPlayRight()
	{
		return false;
	}
}
