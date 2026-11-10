using System;
using UnityEngine;

public class UI_MiniGamesSpin_LuckyPoint : MonoBehaviour
{
	public UILabel lPoint;

	public UILabel lPointTips;

	public UISprite SProgress;

	private float t;

	private float startPoint;

	private float endPoint;

	public GameObject uiThumb;

	public ParticleSystem uiThumbParticle;

	public UISlider uiSlider;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public FlexibleRealTimeRegulator m_tTimeAddRegulator;

	private GamblingRouletteCtrl.RouletteType ToRouletteType;

	private Action action;

	public void Show()
	{
	}

	public void SetLuckyPoint(GamblingRouletteCtrl.RouletteType toRouletteType, float point, bool isShowAddAnim = false, Action _action = null)
	{
	}

	public void PlayerAction()
	{
	}

	public void UpdateTips(float endValue)
	{
	}

	public void SetParticle(float endValue)
	{
	}

	public void SetSprite(float endValue)
	{
	}

	private void Update()
	{
	}

	public void PlayerValueUpgrade(float AddCard, float ownedCard, float time)
	{
	}

	public void Hide()
	{
	}
}
