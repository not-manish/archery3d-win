using System.Collections.Generic;
using com.simple.proto;

public class PlayerData
{
	public bool data_sync;

	public string id;

	public string token;

	public Account account;

	public string name;

	public bool is_robot;

	public long gold;

	public long gem;

	public int arena_low_card;

	public int arena_high_card;

	public long get_trophy;

	public bool hide_facebook_photo;

	public string pur_token;

	public bool is_ad_free;

	public bool guide_finished;

	public bool has_shown_rate;

	public long last_change_name_mil;

	public EquipData equip_data;

	public ArenaData arena_data;

	public ChallengeData challenge_data;

	public ClassicData classic_data;

	public RushData rush_data;

	public BingoData bingo_data;

	public ChestClassicData chest_classic_data;

	public ShopData shop_data;

	public LeagueData league_data;

	public SingleData single_data;

	public AchievementData achievement_data;

	public VideoFreeData video_free_data;

	public StatisticData statistic_data;

	public PlayerStateData player_state_data;

	public PlayerFriendsData player_friend_data;

	public SevenDailyBonus seven_daily_bonus;

	public GamblingRoulette gambling_roulette;

	public LimitedTimeBuyData limited_time_buy;

	public QuestData quest_data;

	public int match_times;

	public GameModeState game_mode_state;

	public PlayerActionStats player_action_stats;

	public ConWin10Chest con_win_10_chest;

	public List<int> ltb_equip_type_ids;

	public VideoFreeNewData video_free_new_data;

	public void Update(CCPlayer player, bool updateToken = false, bool isMydata = true)
	{
	}

	public void UpdateEquipData(CCEquipData equipData)
	{
	}

	public void UpdateEquipCurArrowId(int CurArrowId)
	{
	}

	public void UpdateEquipArrowNum(int ArrowId, int ArrowNum)
	{
	}

	public void UpdateThirdAccount(CCUserAccount ccAccount)
	{
	}

	public void SetHasShowRate(bool hasShown)
	{
	}

	public void SetHasShownLTB()
	{
	}

	public EquipIds GetEquipIds()
	{
		return null;
	}

	public bool IsEquipEffect(int EquipTypeId)
	{
		return false;
	}

	public ChallengeGroup GetCurChallengeGroup()
	{
		return (ChallengeGroup)0;
	}
}
