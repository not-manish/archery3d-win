using System.Collections.Generic;
using com.simple.proto;

public class EquipData
{
	public int bow_id;

	public int arrow_id;

	public int arm_id;

	public int sight_id;

	public int stabilizer_id;

	public List<EquipArrow> equip_arrow;

	public List<EquipOthers> equip_arm;

	public List<EquipOthers> equip_bow;

	public List<EquipOthers> equip_sight;

	public List<EquipOthers> equip_stabilizer;

	public void UpdateData(CCEquipData data)
	{
	}

	public void UpdateEquipCurArrowId(int CurArrowId)
	{
	}

	public void UpdateEquipArrowNum(int ArrowId, int ArrowNum)
	{
	}

	public EquipOthers GetEquipOthersItem(EquipType quipType, int type)
	{
		return null;
	}

	public EquipArrow GetEquipArrowItemById(int ID)
	{
		return null;
	}

	public EquipArrow GetEquipArrowItemByType(int typeId)
	{
		return null;
	}

	public bool IsEquiped(EquipType equipType, int typeID)
	{
		return false;
	}

	public int GetEquippedId(EquipType equipType)
	{
		return 0;
	}

	public int GetEquippedType(EquipType equipType)
	{
		return 0;
	}
}
