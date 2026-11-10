using com.simple.proto;

public class RushLevel
{
	public int id;

	public bool has_unlocked;

	public int get_trophy;

	public int sum_games;

	public int win_games;

	public int lose_games;

	public int ave_sum_count;

	public float ave_ring;

	public bool is_continue_win;

	public int continue_count;

	public RushLevel()
	{
	}

	public RushLevel(CCRushLevel levelInfo)
	{
	}
}
