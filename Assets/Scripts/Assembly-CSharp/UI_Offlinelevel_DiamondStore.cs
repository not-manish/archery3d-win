using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_Offlinelevel_DiamondStore : MonoInstance<UI_Offlinelevel_DiamondStore>, UIBase
{
	public UIButton btBack;

	public List<UI_DiamondStore_Item> uiLists;

	public UI_OfflineLevel_DiamondDetail uiMoneyDetail;

	public UIScrollView uiScrollView;

	public UIWidget widgetAll;

	private int ItemHeight;

	private float ItemStartLocalX;

	private float ItemWidth;

	public Transform tItemParent;

	public UI_AnimationCtrl uiAnimationCtrl;

	private ShowBuyDiamData showBuyDiamData;

	private bool hasSetScale;

	private bool buttonEnable;

	public Action ResPonseAction;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void CreateItems(List<int> ItemIDs)
	{
	}

	public void UpdateItems()
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

	public void KeyEscapeClicked()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void SetResPonseAction(Action action)
	{
	}

	public bool GetRespons()
	{
		return false;
	}
}
