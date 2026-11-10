using UnityEngine;

public class UI_Equip_Compare_Part : MonoBehaviour
{
	public UI_Equip_Compare_Model uiModel;

	public GameObject oUpgradeArrow;

	public GameObject oWordsCollectedMore;

	public GameObject oCanUpgrade;

	public GameObject oWordsFullLevel;

	public GameObject oWordsCollectedUnlocked;

	public GameObject oSelected;

	public GameObject oButtonSelected;

	public GameObject oButtonCanNotSelected;

	public UIButton btUpgrade;

	public UIButton btSelect;

	public UIButton btShowEquip;

	public UILabel lEquipName;

	public UILabel lCurLevel;

	public UILabel lCardProgressNum;

	public UISprite sCardProgress;

	public UILabel lUpgradeNeedCard;

	public UILabel lUnlockGrade;

	public UILabel lBtUpgradeGold;

	public UI_Equip_Info_Color uiEquipInfoColor;

	public UIButton btEliteUp;

	public GameObject oLockElite;

	public UILabel lEliteUpTime;

	public UISprite sEliteTopName;

	public UISprite sEliteDownName;

	public GameObject oEliteIcon;

	public GameObject oEliteIcon_NotUp;

	public UI_AnimationCtrl EliteLightAnim;

	private UIComparePartParam uiParam;

	private UI_Equip_Compare uiCompare;

	private PlayerData playerData;

	private EquipOthersBase equipOriDataCur;

	private SaleTypeItem saleTypeItem;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public bool isCool;

	private bool buttonEnable;

	private float lastClickUpgrade;

	public UI_LittleTips uiLittleTips;

	public UIPanel uiPanel;

	public GameObject oEquipTutorialBtn;

	private void Start()
	{
	}

	public void Show(UI_Equip_Compare _uiCompare, object param)
	{
	}

	public void UpdateState()
	{
	}

	private float GetProgress(int CurNum, int MaxNum)
	{
		return 0f;
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

	public void ShopScrollBuyGoldByOnsale()
	{
	}

	public void ShopScrollGem()
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

	public bool IsShowing()
	{
		return false;
	}
}
