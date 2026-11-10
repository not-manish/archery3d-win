using System.Collections.Generic;
using com.simple.proto;

public class ChallengeData
{
	public bool last_season_has_reward;

	public int last_season_challenge_id;

	public int last_season_challenge_group;

	public int last_season_challenge_reward_chest_id;

	public int last_season_challenge_rank;

	public int last_season_challenge_rank_estimate;

	public int challenge_id;

	public bool has_join;

	public int challenge_group;

	public bool this_season_has_unlocked;

	public long this_season_start_time;

	public long this_season_end_time;

	public int sum_score;

	public int sum_time;

	public List<ChallengeLevel> pass_level_info;

	public bool has_best_rank;

	public int best_challenge_group;

	public int best_challenge_rank;

	public bool showld_show_chal_rank;

	public int showld_show_chal_id;

	public int showld_show_chal_group;

	public bool unlocked_level_1;

	public bool unlocked_level_2;

	public bool unlocked_level_3;

	public bool unlocked_level_4;

	public void UpdateData(CCChallengeData data)
	{
	}

	public ChallengeLevel GetPassInfoByID(int ID)
	{
		return null;
	}

	public ChallengeGroup GetMaxChallengeGroup()
	{
		return (ChallengeGroup)0;
	}
}
