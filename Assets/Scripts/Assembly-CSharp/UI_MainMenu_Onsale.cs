using System.Collections.Generic;
using UnityEngine;

public class UI_MainMenu_Onsale : MonoBehaviour
{
	public UIButton btnOnSaleShow;

	public UISprite sLimitedTimeBuyItemIcon;

	public UILabel lSaleItemName;

	public UILabel lSaleItemNamebg;

	public UILabel lTime;

	public UILabel lTimebg;

	public UI_AnimationCtrl uiAnimationCtrl;

	public UILabel lSaleSpeicItemName;

	public UILabel lSaleSpeicItemNamebg;

	public UISprite oSaleNewPlayer;

	public GameObject oSaleOther;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public float DurationTime;

	public float WaitingTime;

	private int moveIndex;

	private List<SaleTypeItem> AllSaleTypeItem;

	public float time;

	public bool isBack;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show()
	{
	}

	public void UpdateState()
	{
	}

	private void Update()
	{
	}

	private void UpdateTimeLeft()
	{
	}

	public void Hide(object param)
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}
}
