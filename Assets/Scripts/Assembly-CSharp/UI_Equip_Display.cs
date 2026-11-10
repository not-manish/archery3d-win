using UnityEngine;

public class UI_Equip_Display : MonoInstance<UI_Equip_Display>, UIBase
{
	public UI_Equip_Display_Ability uiAbilityDetail;

	public UI_Equip_Display_Model uiModel;

	public UIButton btTotalAbility;

	public UIButton btShopEquip;

	public UIButton btShopEquipbg;

	public UISprite sTotalAbility;

	public UI_AnimationCtrl AbilityDetailAnimationCtrl;

	public TweenPosition tweenPosition;

	private EquipAnimType equipAnimType;

	[HideInInspector]
	public UI_Equip uiEquip;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Equip _uiEquip, object param)
	{
	}

	private void ShowEquipModel()
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

	public void AbilityAnimCtrlShowFinish()
	{
	}

	public void AbilityAnimCtrlHideFinish()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void EquipButtonClicked(EquipType equipType)
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
}
