public class TipRewardData
{
	public int rewardCount;

	public int rewardID;

	public RewardType reward_type;

	public int childCount;

	public bool isShop;

	public ChestKind chestKind;

	public TipRewardData(RewardType _reward_type, int _reward_count, int _reward_number, int _childCount, bool _isShop = false, ChestKind _chestKind = ChestKind.chest_challenge)
	{
	}
}
