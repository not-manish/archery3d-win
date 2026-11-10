using UnityEngine;

public class UI_Equip : MonoInstance<UI_Equip>, UIBase
{
	public UI_Equip_List uiList;

	public UI_Equip_Detail uiDetail;

	public UI_Equip_Compare uiCompare;

	public UI_Equip_Upgrade uiUpgrade;

	public UI_Equip_Handle uiEquipHandle;

	public UI_Equip_IconTips uiEquipIconTips;

	public UI_Equip_SkillGuide uiEquipSkillGuide;

	public UIPanel uiPanel;

	public UIModelCtrl uiModelCtrl;

	private EquipWindows equipWindow;

	private bool hasSetScale;

	private UIEquipParam uiParam;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
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

	private void ButtonCommonClicked(ButtonType buttonType)
	{
	}

	public void ShowWindow(EquipWindows type, object param, bool isShowinfo = false, UIModelKind _uiModelKind = UIModelKind.EquipAll)
	{
	}

	public void UpdatePlayerInfo(bool updateMoney)
	{
	}

	public void EquipOperateResponse()
	{
	}

	public void ReconnectLoginSuccess()
	{
	}

	private void HideTutorial()
	{
	}

	public bool isCheckEquip()
	{
		return false;
	}

	public void ShowTutorial()
	{
	}

	public void ShowTutorialTips()
	{
	}

	public void ShowListSelectBowTutorialTips()
	{
	}

	public bool IsNotShowOtherPanel()
	{
		return false;
	}
}
