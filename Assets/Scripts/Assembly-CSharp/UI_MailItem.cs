using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_MailItem : MonoBehaviour
{
	public UIButton btRead;

	public UILabel lTime;

	public UILabel lMaileName;

	public UISprite sGiftBox;

	public UISprite sMailType;

	public long mailId;

	public CCMailItem mailItemInfo;

	public PlayerHeadShow playerHeadShow;

	public int NowState;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	[HideInInspector]
	public UI_Mail uiMail;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void UpdateInfo()
	{
	}

	public void SetReadState(int type, int state)
	{
	}

	public void MoveReadToEnd(List<long> allId)
	{
	}

	private void UpdateTimeLeft()
	{
	}

	public void DestroyThis()
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

	public bool IsShowing()
	{
		return false;
	}

	private void Update()
	{
	}
}
