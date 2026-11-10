using UnityEngine;

public class UI_Equip_Detail : MonoBehaviour
{
	public UI_Equip_Detail_Arrow uiDetailArrow;

	public UI_Equip_Detail_Normal uiDetailNormal;

	public UI_AnimationCtrl uiAnimationCtrl;

	public UIPanel uiEquipDetailPanel;

	public UIDetailParam uiParam;

	[HideInInspector]
	public UI_Equip uiEquip;

	private int oldPanelDepth;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Equip _uiEquip, object param)
	{
	}

	public void ShowModels(EquipType equipType, int typeID)
	{
	}

	public void ButtonCloseClicked()
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

	public void DestoryUIEquipTutorial()
	{
	}
}
