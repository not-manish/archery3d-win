using System.Collections.Generic;
using UnityEngine;

public class UI_Equip_List : MonoInstance<UI_Equip_List>, UIBase
{
	public UIScrollView uiScrollView;

	public UIPanel uiScrollPanel;

	public UI_Equip_Display uiEquipDisplay;

	public UI_Equip_List_Case uiCase;

	public UI_Equip_List_EquipList[] uiEquipList;

	public UIWidget widgetDisplay;

	public UIWidget widgeTopFree;

	public UIWidget widgeDownFree;

	private float StartY;

	private List<EquipType> EquipListsOrder;

	public Transform DrapPanel;

	private UI_Equip uiEquip;

	private EquipType focusEquip;

	public EquipListTutorial equipListTutorial;

	private bool buttonEnable;

	public bool isUpToShow;

	private void Start()
	{
	}

	public void Show(UI_Equip _uiEquip, EquipType _focusEquip, bool isShowInfo = false, object Param = null)
	{
	}

	public void UpdateState()
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

	public void EquipButtonClicked(EquipType equipType)
	{
	}

	public void EquipInfoClicked(EquipType equipType, int typeID)
	{
	}

	public void EquipCompare(WhichCallEquip whichCallEquip, EquipType equippedType, int equipedTypeId, int compareTypeId)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	private void SetPositon(bool enfore)
	{
	}

	private void Update()
	{
	}

	public void OnPress(GameObject obj, bool state)
	{
	}

	public void SetDrapPanelPosition(float x, float y)
	{
	}

	public void SetDrapPanelPosition()
	{
	}

	public void UpdatePlayerInfo()
	{
	}

	public void EquipOperateResponse()
	{
	}

	public void SetTutorialStart()
	{
	}

	public void RecoveDragScrollViewState()
	{
	}

	public void OfflineHidePanel()
	{
	}

	public void ShowHand()
	{
	}
}
