using com.simple.proto;

public class QuestData
{
	public long sys_quest_start_time_mil;

	public int scores_count;

	public int scores_reward_round;

	public int scores_reward_index;

	public bool today_has_changed_quest;

	public QuestItem quest_item_1;

	public QuestItem quest_item_2;

	public QuestItem quest_item_3;

	public long gifts_last_reward_time_mil;

	public int gifts_reward_round;

	public int gifts_rewarded_index;

	public void Update(CCQuestData questData, bool is_data_sync)
	{
	}
}
