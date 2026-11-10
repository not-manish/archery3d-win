using System;
using UnityEngine;

public class UI_Tips_Normal : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btMiddle;

	public UIButton btRight;

	public UIButton btClose;

	public UILabel lCode;

	public UILabel lDescribe;

	public UILabel lTips;

	public UILabel lTitle1;

	public UILabel lTitle2;

	public UILabel lButton1;

	public UILabel lButton2;

	public Transform tOldButton;

	public UILabel lRightButton1;

	public UILabel lRightButton2;

	private int ltipCode;

	private bool hasSetScale;

	private UITipParam uiParam;

	private bool buttonEnable;

	private Action BtMiddleAction;

	private Action BtCloseAction;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void UpdateState(UITipParam uiParam)
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

	public void SetButtonMiddleAction(Action action)
	{
	}

	public void SetButtonCloseAction(Action action)
	{
	}

	public void SetTipslableCode(int FontSize)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
