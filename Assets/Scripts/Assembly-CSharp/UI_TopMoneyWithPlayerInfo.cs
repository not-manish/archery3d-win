using System;
using UnityEngine;

public class UI_TopMoneyWithPlayerInfo : MonoBehaviour
{
	public static bool isGetMail;

	public UIButton BtTopDiamond;

	public UIButton BtTopGold;

	public UIButton BtTopMenu;

	public UI_TopMoney_SettingAndMail uiTopMoneySettingAndMail;

	public UILabel lGold;

	public UILabel lDiamond;

	public UILabel lTrophy;

	public UISprite sMailNewTips;

	public UILabel lMailNewTips;

	public UI_TopMoneyAniCtrl uiTopAniCtrl;

	public TweenPosition PlayerInfoAnim;

	public Transform PlayerInfo;

	private long gold;

	private long diamond;

	private long trophy;

	public UISprite sGold;

	public UISprite sDiamond;

	public UISprite sTrophy;

	public PlayerHeadShow playerHeadshow;

	public UI_AnimationCtrl uiAnimationCtrl;

	private Action<ButtonType> ButtonCommonDelegate;

	public FlexibleRealTimeRegulator m_tWaitTime;

	private UITopMoneyParam uiParam;

	public UIPanel uiPanel;

	public GameObject oOfflinePanel;

	private int NewMailCount;

	private long GoldCount;

	private long GemCount;

	private PlayerData _playerData;

	private float t;

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnScreenResize()
	{
	}

	public void Show(object param)
	{
	}

	private void SetUIOfflinePanel()
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

	private void Update()
	{
	}

	public void RequestMail()
	{
	}

	public void UpdateMailState()
	{
	}

	public void UpdatePlayerInfo(PlayerData playerData, TopUpdateGoldType topUpdateGoldType, bool updateMoney = true)
	{
	}

	public void PlayerAddCoinAnim()
	{
	}

	public void ResetGameOverGold(int DelGoldCount)
	{
	}

	public void StartGameOverGoldAdd()
	{
	}

	public bool isShowing()
	{
		return false;
	}
}
