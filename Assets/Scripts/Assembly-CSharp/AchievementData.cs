using com.simple.proto;

public class AchievementData
{
	public int points_count;

	public int reward_points;

	public AchievementSubData match_data;

	public AchievementSubData cup_data;

	public AchievementSubData rich_data;

	public AchievementSubData challenge_data;

	public void Update(CCAchievementData data, bool is_data_sync)
	{
	}
}
