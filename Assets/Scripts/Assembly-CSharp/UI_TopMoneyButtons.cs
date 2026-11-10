using UnityEngine;

public class UI_TopMoneyButtons : MonoBehaviour
{
	public UI_TopMoneyWithPlayerInfo uiWithPlayerInfo;

	private UICommonWindow _uiWindow;

	public static Transform tGoldIcon;

	public static Transform tDiamondIcon;

	public static Transform tTrophy;

	public UI_AnimationCtrl uiAnimationCtrl;

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public static void CommonButtonResponse(ButtonType buttonType)
	{
	}

	public void UpdatePlayerInfo(bool updateMoney = true)
	{
	}

	public void UpdatePlayerInfo_MoneyAdd()
	{
	}

	public void UpdatePlayerInfo_Quick()
	{
	}

	public void ResetGameOverGold(int DelGoldCount)
	{
	}

	public void StartGameOverGoldAdd()
	{
	}

	public void RequestMail()
	{
	}

	public bool isShowing()
	{
		return false;
	}
}
