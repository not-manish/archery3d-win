using System.Collections.Generic;
using UnityEngine;

public class UI_Equip_List_EquipItem : MonoBehaviour
{
	private UI_Equip_List_EquipList uiList;

	public UI_Equip_Common_Color uiColor;

	public GameObject oSelected;

	public GameObject oLocked;

	public GameObject oUpArrow;

	public GameObject oUpgradeInfo;

	public GameObject oStartClub;

	public GameObject oArrowNum;

	public GameObject oLockElite;

	public UILabel lNotFound;

	public UISprite sEliteTopName;

	public UISprite sEliteDownName;

	public GameObject oEliteIcon;

	public GameObject oEliteIcon_NotUp;

	public GameObject oEliteIcon_Get;

	public UILabel lEliteUpTime;

	public UIButton btEliteUp;

	public UI_AnimationCtrl EliteLightAnim;

	public UILabel lStarterEquipName;

	public UIButton btItem;

	public UISprite sEquipSprite;

	public UILabel lCurLevel;

	public UILabel lEquipName;

	public UILabel lCardProgressNum;

	public UISprite sCardProgress;

	public UILabel lLockGradeLevel;

	public UILabel lArrowNum;

	public UI_LittleTips uiLittleTips;

	private EquipType equipType;

	private int typeID;

	public List<UIDragScrollView> uiDragScrollViews;

	private bool buttonEnable;

	private EquipOthersBase equipOthersBase;

	private SaleTypeItem saleTypeItem;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public bool isCool;

	public GameObject oEquipTutorialBtn;

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

	public void Show(UI_Equip_List_EquipList _uiList, EquipType _equipType, int _typeID)
	{
	}

	public void UpdateState()
	{
	}

	private void UpdateArrow(EquipType equipType, EquipArrowsOriData arrowOriData)
	{
	}

	private void UpdateEquipOthers(EquipType equipType, EquipOthersBase equipOtherBase)
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

	public void ShowTutorial()
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

	public void SetDragScrollViewState(bool isEnable)
	{
	}

	public void ShowHand()
	{
	}

	public void ShowEliteIcon()
	{
	}
}
