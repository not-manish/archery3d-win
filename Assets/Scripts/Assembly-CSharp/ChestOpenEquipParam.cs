using System.Collections.Generic;
using com.simple.proto;

public class ChestOpenEquipParam
{
	public ChestRewardType chestRewardType;

	public int EquipCardKind;

	public int EquipCardCount;

	public List<CCChestReward> ListChestReward;

	public ChestOpenEquipParam(int _EquipCardKind, int _EquipCardCount, List<CCChestReward> _listChestReward = null)
	{
	}

	public ChestOpenEquipParam(ChestRewardType _chestRewardType, int _EquipCardKind, int _EquipCardCount, List<CCChestReward> _listChestReward = null)
	{
	}

	public int GetRewardCount(ChestRewardType _rewardType, int _rewardKind = -1)
	{
		return 0;
	}
}
