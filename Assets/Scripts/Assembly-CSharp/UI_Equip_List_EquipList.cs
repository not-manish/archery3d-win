using System.Collections.Generic;
using UnityEngine;

public class UI_Equip_List_EquipList : MonoBehaviour
{
	public UIWidget uiWidget;

	public UILabel lEquipTile1;

	public UILabel lEquipTile2;

	private List<UI_Equip_List_EquipItem> uiItems;

	public static int TitleHeight;

	public static int ItemWidth;

	public static int ItemHeight;

	private UI_Equip_List uiEquipList;

	public EquipType equipType;

	private List<int> types;

	private float moveSpeed;

	private Vector3 targetPosition;

	public void Show(UI_Equip_List _uiEquipList, EquipType _equipType)
	{
	}

	private List<int> GetEquipTypes(EquipType _equipType)
	{
		return null;
	}

	public List<int> CheckIsShowEquipItem(EquipType _equipType, List<int> AllType)
	{
		return null;
	}

	private void CreateItems(List<int> types)
	{
	}

	private void Update()
	{
	}

	public void UpdateItems()
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public void SetLocalPosition(bool enfore, float yPosition)
	{
	}

	public void EquipItemClicked(EquipType equipType, int typeID)
	{
	}

	public void RecoveDragScrollViewState()
	{
	}

	public void ShowHand()
	{
	}
}
