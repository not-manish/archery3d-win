using System.Collections.Generic;
using com.simple.proto;

public class ArenaData
{
	public bool has_join;

	public ArenaType arena_type;

	public int sum_games;

	public int win_games;

	public int lose_games;

	public int arena_finished_times;

	public float average_wins;

	public List<ArenaLevel> level_infos;

	public void UpdateData(CCArenaData data)
	{
	}
}
