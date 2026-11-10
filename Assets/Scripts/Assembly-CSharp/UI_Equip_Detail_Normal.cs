using UnityEngine;

public class UI_Equip_Detail_Normal : MonoBehaviour
{
	public UI_Equip_Detail_Model uiModel;

	public UIButton btClose;

	public UIButton btUpgrade;

	public UIButton btShouEquip;

	public UILabel lTitleName;

	public UIButton btEliteUp;

	public GameObject oLockElite;

	public UILabel lEliteUpTime;

	public UISprite sEliteTopName;

	public UISprite sEliteDownName;

	public GameObject oEliteIcon;

	public GameObject oEliteIcon_NotUp;

	public UI_AnimationCtrl EliteLightAnim;

	public GameObject oUpgradeArrow;

	public GameObject oWordsCollectedMore;

	public GameObject oWordsUpgrade;

	public GameObject oWordsFullLevel;

	public UISprite sWinnerBonus;

	public UISprite sCheerupBonus;

	public GameObject[] oEquipProperties;

	public GameObject[] oEquipPropertiesAddNum;

	public GameObject oButtonUpgrade;

	public GameObject oSelected;

	public UILabel lEquipKindName;

	public UILabel lEquipName;

	public UILabel lCurLevel;

	public UILabel lCardProgressNum;

	public UISprite sCardProgress;

	public UILabel lUpgradeNeedCard;

	public UILabel lUpgradeNeedCardbg;

	public UILabel lButtonGold;

	public UILabel[] lPropName;

	public UILabel[] lPropCurNum;

	public UILabel[] lPropAddNum;

	public UISprite[] sPropCurProgress;

	public UISprite[] sPropNextProgress;

	public UISprite[] sPropFullProgress;

	public UILabel lWinnerLevel;

	public UILabel lWinnerUpgradeInfo;

	public UILabel lCheerupLevel;

	public UILabel lCheerupUpgradeInfo;

	public UIChangeWidgeColor colorWinner;

	public UIChangeWidgeColor colorCheerup;

	public UIButton btnWinner;

	public UIButton btnCheerUp;

	public GameObject oOwnedByEquip;

	public GameObject oOwnedByShop;

	public UIButton btShopCompare;

	public UIButton btShopBuy;

	public UILabel lShopBuyWhite;

	public UILabel lShopBuyRed;

	public GameObject oShopForUpgrade;

	public GameObject oShopUnlock;

	public UILabel lShopCardLeftNum;

	public UI_AnimationCtrl NumAddAnimation;

	private float WinnerLevel;

	private float CheerUpLevel;

	public UI_Equip_Info_Color uiEquipInfoColor;

	private PlayerData playerData;

	private EquipOthersBase equipOriDataCur;

	private bool isBuyCard;

	private UIDetailNormalParam uiParam;

	private UI_Equip_Detail uiDetail;

	private int CostGemNormal;

	private SaleTypeItem saleTypeItem;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public bool isCool;

	private bool buttonEnable;

	private float lastClickUpgrade;

	public UIPanel uiPanel;

	public UI_LittleTips uiLittleTips;

	public GameObject oEquipTutorialBtn;

	private void Start()
	{
	}

	public void Show(UI_Equip_Detail _uiDetail, object param)
	{
	}

	public void SetEquipName(EquipType equipType)
	{
	}

	public void UpdateState(bool isBuy = false)
	{
	}

	private void UpdateState_Common()
	{
	}

	private void UpdateState_Equip()
	{
	}

	private void UpdateState_Shop(bool isBuy = false)
	{
	}

	private void UpdateState_Equip_OnlyInfo()
	{
	}

	public bool IsEquipLimitedBuy()
	{
		return false;
	}

	private void Update()
	{
	}

	private void UpdateTimeLeft()
	{
	}

	private float GetProgress(int CurNum, int MaxNum)
	{
		return 0f;
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

	public void GoToShopBuyGold()
	{
	}

	public void ShopScrollGem()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void UpdatePlayerInfo()
	{
	}

	public void EquipOperateResponse()
	{
	}

	private void SetUIEquipTutorialPanel()
	{
	}

	public void DestoryUIEquipTutorial()
	{
	}

	public void ShowEquipTutorial()
	{
	}

	public void ShowEliteIcon()
	{
	}
}
