using System.Collections.Generic;
using UnityEngine;

public class UI_Equip_List_Case_Item : MonoBehaviour
{
	private UI_Equip_List_Case uiCase;

	public UI_Equip_Common_Color uiColor;

	public GameObject oSelected;

	public GameObject oNotSelected;

	public GameObject oUpArrow;

	public GameObject oUpgradeInfo;

	public GameObject oStartClub;

	public UIButton btItem;

	public UIButton btInfo;

	public UIButton btUpgrade;

	public UILabel lName1;

	public UILabel lName2;

	public UILabel lStarterEquipName;

	public UISprite sEquipSprite;

	public UILabel lCurLevel;

	public UILabel lEquipName;

	public GameObject oEliteIcon;

	public GameObject oEliteIcon_NotUp;

	public GameObject oEliteIcon_Get;

	public UILabel lCardProgressNum;

	public UISprite sCardProgress;

	private EquipOthersBase equipOthersBase;

	public List<UIDragScrollView> uiDragScrollViews;

	[HideInInspector]
	public EquipType equipType;

	private int typeID;

	private int equipID;

	private EquipState equipState;

	private bool isFocus;

	private bool buttonEnable;

	private SaleTypeItem saleTypeItem;

	public UIPanel uiPanel;

	public UI_LittleTips uiLittleTips_Select;

	public UI_LittleTips uiLittleTips_info;

	public GameObject oEquipTutorialBtn;

	public GameObject oEquipTutorialInfoBtn;

	private void Start()
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

	public void Show(UI_Equip_List_Case _uiCase, EquipType _equipType, bool _isFocus)
	{
	}

	public void SetFocus(bool _isFocus)
	{
	}

	private void UpdateID()
	{
	}

	public void UpdateState()
	{
	}

	private void UpdateEquip(EquipType equipType, EquipOthersBase _equipOtherBase)
	{
	}

	public bool IsEquipLimitedBuy()
	{
		return false;
	}

	private void SetEquipState(EquipState _equipState)
	{
	}

	private void SetUIEquipTutorialBtnPanel()
	{
	}

	private void SetUIEquipTutorialInfoBtnPanel()
	{
	}

	private void DestoryUIEquipTutorial()
	{
	}

	public void ShowInfo()
	{
	}

	public void ShowEquipInfoTutorial()
	{
	}

	public void ShowEquipSelectTutorial()
	{
	}

	public void ShowHand()
	{
	}

	public void SetDragScrollViewState(bool isEnable)
	{
	}

	public void OfflineHidePanel()
	{
	}
}
