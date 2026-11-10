using System.Collections.Generic;
using UnityEngine;

public class UI_MiniGames_PrizeList : MonoBehaviour
{
	public UIButton btClose;

	public UI_AnimationCtrl ui_AnimationCtrl;

	public GameObject PayPrizeParent;

	public GameObject FreePrizeParent;

	public UIPanel PayPrizePanel;

	public UIPanel FreePrizePanel;

	private float startY;

	private float ItemHeight;

	public List<UI_MiniGames_PrizeList_Item> PayPrizeItemList;

	public List<UI_MiniGames_PrizeList_Item> FreePrizeItemList;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(GamblingRouletteCtrl.RouletteType Param)
	{
	}

	public void UpdateInfo(GamblingRouletteCtrl.RouletteType Param)
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

	public void ResetPosition(UIPanel uiScrollView)
	{
	}
}
