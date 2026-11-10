using com.simple.proto;

public class LimitedTimeBuyOriData
{
	public int id;

	public int type;

	public int price_type;

	public float original_price;

	public float discount_price;

	public string describe;

	public int reward_type1;

	public int reward_number1;

	public int reward_count1;

	public int reward_type2;

	public int reward_number2;

	public int reward_count2;

	public int reward_type3;

	public int reward_number3;

	public int reward_count3;

	public int reward_type4;

	public int reward_number4;

	public int reward_count4;

	public string title;

	public string content;

	public int scene_id;

	public int ui_type_id;

	public int ui_type_id_b;

	public int ui_type_id_a;

	public string particle_name;

	public string special_name_bg;

	public string reward_bg_name;

	public string special_icon;

	public int show_num;

	public bool ContainChest()
	{
		return false;
	}

	public int GetChestId()
	{
		return 0;
	}

	public CCChestReward GetChestReward(CCChestReward ChestRewardAll)
	{
		return null;
	}

	public bool ContainCard()
	{
		return false;
	}

	public CCChestReward GetCardReward(CCChestReward ChestRewardAll)
	{
		return null;
	}
}
