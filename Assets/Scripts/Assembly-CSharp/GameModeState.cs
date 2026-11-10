using com.simple.proto;

public class GameModeState
{
	public bool has_init_data;

	public bool ser_locked_classic;

	public bool ser_locked_rush;

	public bool ser_locked_bingo;

	public bool ser_locked_arena;

	public bool ser_locked_challenge;

	public bool pla_unloc_classic;

	public bool pla_unloc_rush;

	public bool pla_unloc_bingo;

	public bool pla_unloc_arena;

	public bool pla_unloc_challenge;

	public void ClearData()
	{
	}

	public void UpdateData(CCPlayerGameModeState data, CCPlayer ccplayer)
	{
	}

	public bool isMyGameUnlock(GameType gameType)
	{
		return false;
	}

	public void SaveGameModeUnLockData(UnLockGameMode unLockGameMode)
	{
	}
}
