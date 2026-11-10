using System.Collections.Generic;
using UnityEngine;

public class UI_FightingCommon : MonoBehaviour
{
	public delegate void CommonButtonOnClicked(ButtonType buttonType);

	public Transform tMoveParent;

	public Transform tForNormal;

	public Transform tForBingo;

	public UI_Chat uiChat;

	public UI_TurnTips uiTurnTips;

	public UI_HintsTips uiHintsTips;

	public UI_ScoreCtrl uiScoreCtrl;

	public UI_Fighting_Playerinfo uiFightingPlayerinfo;

	public UI_TargetPoint uiTargetPoint;

	public UI_WindCtrl uiWindCtrl;

	public UI_FightingCommon_Star uiFightingCommonStar;

	public UI_AimCircleCtrl uiAimCircleCtrl;

	public UI_Commom_Fighting_ForbidTouch uiForbidTouch;

	public UI_Commom_Fighting_PullBowFullAnim uiPullBowFullAnim;

	public UI_Commmon_Fighting_LastTimeTips uiFightingLastTimeTips;

	public UICancelButton uiCancelButton;

	public UIButton btEquip;

	public UILabel lArrowWhite;

	public UILabel lArrowRed;

	public UIButton btExit;

	private CommonButtonOnClicked ButtonCancelDelegate;

	private CommonButtonOnClicked ButtonEquipDelegate;

	private CommonButtonOnClicked ButtonExitDelegate;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(FightingCommonPosType posType, List<FightingCommonWindow> windowList, List<object> paramList)
	{
	}

	public void SetPos(FightingCommonPosType posType)
	{
	}

	public void Hide(List<FightingCommonWindow> windowList)
	{
	}

	public void Show(FightingCommonWindow windowPart, object param)
	{
	}

	public void Hide(FightingCommonWindow windowPart)
	{
	}

	public void HideAll()
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

	public void CommonButtonClicked(ButtonType buttonType)
	{
	}

	public void HandleChatResopnse(int chatId, bool isMySelf)
	{
	}

	public void UpdatePlayerInfo(bool updateMoney)
	{
	}

	private void UpdateEquip()
	{
	}

	public void ResetShootingTime(float duration, float timeLeft, OnlineNormalState PlayerState)
	{
	}

	public void CloseShootingTime(bool isClearProgress, OnlineNormalState PlayerState)
	{
	}

	public void CloseShootingTime(bool isClearProgress, float duration, float timeLeft, OnlineNormalState PlayerState)
	{
	}

	public void SetChatButton(bool isShow)
	{
	}
}
