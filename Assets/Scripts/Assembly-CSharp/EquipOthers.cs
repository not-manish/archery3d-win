using com.simple.proto;

public class EquipOthers
{
	public int type;

	public int level;

	public int owned_card;

	public EquipOthers()
	{
	}

	public EquipOthers(CCEquipOthers equip)
	{
	}

	public int ID()
	{
		return 0;
	}

	public bool IsOwned(int typeID)
	{
		return false;
	}
}
