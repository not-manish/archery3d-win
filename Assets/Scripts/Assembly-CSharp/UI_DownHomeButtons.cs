using System;
using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_DownHomeButtons : MonoBehaviour
{
	public UIButton BtDownStore;

	public UIButton BtDownEquip;

	public UIButton BtDownHome;

	public UIButton BtDownChat;

	public UIButton BtDownRank;

	public UISprite sHome;

	public UISprite sSelect;

	public UISprite sRankUp;

	public UISprite sRankDown;

	public UI_AnimationCtrl uiAnimationCtrl;

	private Action<ButtonType> ButtonCommonDelegate;

	public UI_Finger_Click uiFingerClick;

	public UI_LittleTips uiLittleTips_Chest;

	public UIPanel LittleTipsChestPanel;

	public static object ResoponseObj;

	private UIDownButtonParam uiParam;

	public UILabel lNewEquipUpgradeNum;

	public GameObject oNewEquipUpgradeNum;

	public UILabel lShopCardNum;

	public GameObject oShopCardNum;

	public GameObject oEquipTutorialBtn;

	public UI_LittleTips uiLittleTips_Equip;

	public UIPanel uiPanel;

	public GameObject oOfflinePanel;

	public Transform tCenterObject;

	public Transform[] oDividingLine;

	public Transform[] tButtonObject;

	public GameObject[] oButtonName;

	private float speed;

	private const float minX = -363f;

	private const float maxX = 363f;

	private const float normalWidth = 130f;

	private const float focusWidth = 206f;

	private int focusIndex;

	private float[] DividingLineTarget;

	private float[] ButtonTarget;

	private float focusPos;

	public UI_AnimationCtrl DownStoreAnimationCtrl;

	public UI_AnimationCtrl DownRankAnimationCtrl;

	public UI_AnimationCtrl DownChatAnimationCtrl;

	public UI_AnimationCtrl DownEquipAnimationCtrl;

	public UI_AnimationCtrl DownHomeAnimationCtrl;

	public Dictionary<ButtonType, UI_AnimationCtrl> allButtonAnimCtrl;

	private List<ButtonType> allKeys;

	private CCSevenDailyBonusResponse res;

	private CCVideoNewResponse VideoNewResponse;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void SetNewEquip()
	{
	}

	public void SetShopCard()
	{
	}

	public void ShowNewTips(NewTipsType newTipsType, bool isShow, int num = 1)
	{
	}

	public void ShowNewEquip(bool isShow, int num = 1)
	{
	}

	public void ShowUpgardeEquip(bool isShow, int num = 1)
	{
	}

	public void ShowNewShopCard(bool isShow, int num = 1)
	{
	}

	private void SetUIEquipTutorial()
	{
	}

	public void Finish()
	{
	}

	private void DestoryUIEquipTutorial()
	{
	}

	public void ShowEquipTutorial()
	{
	}

	public void ShowHomeTutorial()
	{
	}

	public void ShowNewChestTips()
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

	public static void CommonButtonResponse(ButtonType buttonType)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public int GetButtonIndex(ButtonType buttonType)
	{
		return 0;
	}

	public void SetButtonFocus(ButtonType buttonType, bool enforce)
	{
	}

	private void Update()
	{
	}

	public void SetallButtonAnimCtrl()
	{
	}

	public void PlayButtonAnimCtrl(ButtonType buttonType, bool isPlayreward)
	{
	}

	public bool isShowing()
	{
		return false;
	}

	public void CheckLeagueRank()
	{
	}

	public void LeagueRankResponse()
	{
	}

	public void ShowRankUpOrDownIcon()
	{
	}

	public bool BuyShopResponse()
	{
		return false;
	}

	public int TipRewardType(int reward_type)
	{
		return 0;
	}

	public void LimitedTimeBuyResponse()
	{
	}

	public bool MailHandleRespones()
	{
		return false;
	}

	public void ChestOpenResponse()
	{
	}

	public void RouletteGiftsResponse()
	{
	}

	public bool GetDailyBonusRespone()
	{
		return false;
	}

	public void IsWatchVideo()
	{
	}

	public bool GetVideoNewResponse()
	{
		return false;
	}

	public void IsGiftWatchVideo()
	{
	}

	public bool GetQuestRespones()
	{
		return false;
	}

	public bool VideoExtraResponse()
	{
		return false;
	}

	public int GetTipRewardType(int reward_type)
	{
		return 0;
	}

	private void clearData()
	{
	}
}
