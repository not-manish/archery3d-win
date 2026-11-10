using UnityEngine;

public class UI_Equip_Handle : MonoBehaviour
{
	public UI_Equip_Handle_Model uiModel;

	public UI_AnimationCtrl uiAnimationCtrl;

	public UI_AnimationCtrl uiBackAnimationCtrl;

	public UIButton btBack;

	public UIButton btBackToPlay;

	public UIButton btclose;

	public UIPanel uiEquipDetailPanel;

	private int oldPanelDepth;

	[HideInInspector]
	public UI_Equip uiEquip;

	public EquipHandleParam equipHandleParam;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Equip _uiEquip, object param)
	{
	}

	public void ShowModels(UIModelKind uiModelKind, EquipType equipType, int typeID)
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

	public void AnimFinish()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
