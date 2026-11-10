using UnityEngine;

public class UI_Equip_Compare : MonoInstance<UI_Equip_Compare>, UIBase
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UI_Equip_Compare_Part uiPartLeft;

	public UI_Equip_Compare_Part uiPartRight;

	public UI_Equip_Compare_Common uiCompareCommon;

	public UILabel lEquipKindName1;

	public UILabel lEquipKindName2;

	public UIButton btBack;

	private UICompareParam uiParam;

	[HideInInspector]
	public UI_Equip uiEquip;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Equip _uiEquip, object param)
	{
	}

	private void ShowModels(UICompareParam uiParam)
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

	private void UpdateState()
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
