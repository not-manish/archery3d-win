using System;
using UnityEngine;

public class UI_Tips_Creator : MonoBehaviour, UIBase
{
	public UICreator creator;

	private string prefabName;

	private static object _lock;

	public void Init()
	{
	}

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public void HideEnforce()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void ShowReward(object res)
	{
	}

	public void SetTipsFontSize(int FontSize)
	{
	}

	public void SetButtonMiddleAction(Action action)
	{
	}

	public void SetButtonCloseAction(Action action)
	{
	}

	public bool isShowShopBuy()
	{
		return false;
	}
}
