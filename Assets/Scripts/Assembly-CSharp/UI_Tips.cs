using System;

public class UI_Tips : MonoInstance<UI_Tips>, UIBase
{
	public UI_Tips_Normal uiTipsNormal;

	public UI_Tips_GetBuyReward uiTipsGetBuyReward;

	private bool hasSetScale;

	private UITipParam uiParam;

	private bool buttonEnable;

	public void Show(object param)
	{
	}

	public void ShowReward(object res)
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

	public void SetButtonMiddleAction(Action action)
	{
	}

	public void SetButtonCloseAction(Action action)
	{
	}

	public void SetTipsFontSize(int fontsize)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public bool isShowShopBuy()
	{
		return false;
	}
}
