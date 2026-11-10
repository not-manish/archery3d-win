using System.Collections.Generic;
using UnityEngine;

public class UI_Equip_Detail_Arrow_Fighting_List : MonoBehaviour
{
	public List<UI_Equip_Detail_Arrow_Fighting_Item> uiArrowList;

	public UIScrollView uiScrollView;

	public float StartX;

	public float WidthX;

	[HideInInspector]
	public UI_Equip_Detail_Arrow uiDetailArrow;

	private List<int> arrowTypeIDs;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Equip_Detail_Arrow _uiDetailArrow)
	{
	}

	private void UpdateArrowIds()
	{
	}

	private void CreateItems()
	{
	}

	private void ResetPositon()
	{
	}

	public void UpdateState(int _FocusTypeID)
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

	public void ClickedItem(int typeID)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
