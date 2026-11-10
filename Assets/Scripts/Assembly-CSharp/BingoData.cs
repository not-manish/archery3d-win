using System.Collections.Generic;
using com.simple.proto;

public class BingoData
{
	public int sum_games;

	public int win_games;

	public int lose_games;

	public List<BingoLevel> level_infos;

	public void UpdateData(CCBingoData data)
	{
	}

	public BingoLevel GetLevelById(int ID)
	{
		return null;
	}
}
