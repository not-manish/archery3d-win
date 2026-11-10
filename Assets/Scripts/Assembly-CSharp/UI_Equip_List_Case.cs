using UnityEngine;

public class UI_Equip_List_Case : MonoBehaviour
{
	private UI_Equip_List uiList;

	public UI_Equip_List_Case_Item[] uiEquipOthersItems;

	public UIWidget uiWidge;

	public UIButton btArrow;

	public UILabel lArrowNum;

	private EquipType forcusEquip;

	private bool buttonEnable;

	public void Show(UI_Equip_List _uiList, EquipType _forcusEquip, bool isShowInfo = false, object Param = null)
	{
	}

	public void UpdateState()
	{
	}

	private void UpdateArrow(int arrowId)
	{
	}

	public void Hide()
	{
	}

	private void Start()
	{
	}

	private void Update()
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

	public void EquipButtonClicked(EquipType equipType)
	{
	}

	public void EquipInfoClicked(EquipType equipType, int typeID)
	{
	}

	public void SetFocus(EquipType equipType, bool focus)
	{
	}

	public float GetHeight()
	{
		return 0f;
	}

	public void SetLocalPosition(bool enfore, float yPosition)
	{
	}

	public void SetTutorialStart()
	{
	}

	public void SetDragScrollViewState()
	{
	}

	public void OfflineHidePanel()
	{
	}

	public void ShowHand()
	{
	}
}
