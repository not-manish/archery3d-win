using System.Collections.Generic;
using com.simple.proto;

public class ChestOpenCoinGemParam
{
	public ChestRewardType rewardType;

	public int rewardCount;

	public List<CCChestReward> ListChestReward;

	public ChestOpenCoinGemParam(ChestRewardType _rewardType, int _rewardCount, List<CCChestReward> _listChestReward = null)
	{
	}

	public int GetRewardCount(ChestRewardType _rewardType, int _rewardKind = -1)
	{
		return 0;
	}
}
