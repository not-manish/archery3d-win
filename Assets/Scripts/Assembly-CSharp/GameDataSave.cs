public class GameDataSave : GameDataSaveBase
{
	public static bool isFirstOpenDailyBonus;

	public static bool isOneDayFirstTimeStartGame;

	public static bool isFirstStartShowLeague;

	private static string FirstInstallGame_Name;

	public static bool FirstInstallGame;

	private static string PlayerUid_Name;

	private static string PlayerToken_Name;

	private static string PlayerGuestUid_Name;

	private static string PlayerGuestToken_Name;

	private static string PlayerIsGuest;

	private static string SaveLocalPhotoNum_Name;

	public static int SaveLocalPhotoNum;

	private static string Playerinfo;

	private static readonly string SettingDataName;

	private static string LevelRealTimeData_Name;

	private static string PlayerIsRate;

	private static string OfflineLevelHeartRealTimeData_Name;

	private static string PlayerData_Account;

	private static string PlayerData_User;

	private static string GameMode_UnLock;

	private static string GameMode_UnLockLevel;

	private static string Facebook_Link_Tips;

	private static string ShowChallengeTips;

	private static bool isFirstOpenShowChallengeTips;

	private static string ShowUpgradeVersion;

	private static string isCurrentVersionNewPlayer;

	private static string Contact_Us_ClickData;

	private static string LeagueRankData;

	private static string NewPlayerLimitedShowData;

	public static void AwakeLoad()
	{
	}

	public static void SaveDatas()
	{
	}

	public static void InitFirstInstallGame()
	{
	}

	public static bool ReadFirstInstallGame()
	{
		return false;
	}

	public static void SaveFirstInstallGame(bool value)
	{
	}

	public static string ReadPlayerUid()
	{
		return null;
	}

	public static void SavePlayerUid(string value)
	{
	}

	public static string ReadPlayerToken()
	{
		return null;
	}

	public static void SavePlayerToken(string value)
	{
	}

	public static void SavePlayerGuestUid(string value)
	{
	}

	public static string ReadPlayerGuestUid()
	{
		return null;
	}

	public static string ReadPlayerGuestToken()
	{
		return null;
	}

	public static void SavePlayerGuestToken(string value)
	{
	}

	public static bool ReadPlayerGuest(bool value)
	{
		return false;
	}

	public static void SavePlayerGuest(bool value)
	{
	}

	public static void InitSaveLocalPhotoNum()
	{
	}

	public static int ReadSaveLocalPhotoNum()
	{
		return 0;
	}

	public static void SaveSaveLocalPhotoNum(int value)
	{
	}

	public static string ReadPlayerinfo()
	{
		return null;
	}

	public static void SavePlayerinfo(string value)
	{
	}

	public static void SaveSettingData(string value)
	{
	}

	public static string ReadSettingData()
	{
		return null;
	}

	public static string ReadLevelRealTimeData(int ID)
	{
		return null;
	}

	public static void SaveLevelRealTimeData(int ID, string value)
	{
	}

	public static bool ReadPlayerRate(bool value)
	{
		return false;
	}

	public static void SavePlayerRate(bool value)
	{
	}

	public static string ReadOfflineLevelHeartRealTimeData()
	{
		return null;
	}

	public static void SaveOfflineLevelHeartRealTimeData(string value)
	{
	}

	public static string ReadPlayerAccountData()
	{
		return null;
	}

	public static void SavePlayerAccountData(string value)
	{
	}

	public static string ReadPlayerUserData()
	{
		return null;
	}

	public static void SavePlayerUserData(string value)
	{
	}

	public static string ReadGameModeUnLock()
	{
		return null;
	}

	public static void SaveGameModeUnLock(string value)
	{
	}

	public static string ReadGameModeUnLockLevel()
	{
		return null;
	}

	public static void SaveGameModeUnLockLevel(string value)
	{
	}

	public static string ReadFacebookLinkTips()
	{
		return null;
	}

	public static void SaveFacebookLinkTips(string value)
	{
	}

	public static bool ReadShowChallengeTips()
	{
		return false;
	}

	public static void SaveShowChallengeTips(bool value)
	{
	}

	public static string ReadUpgradeVersion()
	{
		return null;
	}

	public static void SaveUpgradeVersion(string value)
	{
	}

	public static bool ReadisNewPlayer(bool value)
	{
		return false;
	}

	public static void SaveisNewPlayer(bool value)
	{
	}

	public static string ReadContactUsClickData()
	{
		return null;
	}

	public static void SaveContactUsClickData(string value)
	{
	}

	public static string ReadLeagueRankData()
	{
		return null;
	}

	public static void SaveLeagueRankData(string value)
	{
	}

	public static string ReadNewPlayerLimitedShowData()
	{
		return null;
	}

	public static void SaveNewPlayerLimitedShowData(string value)
	{
	}
}
