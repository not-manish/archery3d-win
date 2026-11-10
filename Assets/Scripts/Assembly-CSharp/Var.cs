public class Var
{
	public static int VERSION;

	public static int TIME_HEAR_BEAT_SOCKET;

	public static int TIMEOUT_LOGIN;

	public static int MAX_TRYTIMES_LOGIN;

	public static int MAX_TRYTIMES_RECONNECT;

	public const int RESULT_OK = 0;

	public const int RESULT_ERR_COIN_NOT_EH = 1;

	public const int RESULT_ERR_GEM_NOT_EH = 2;

	public const int RESULT_ERR_METRAIL_NOT_EH = 3;

	public const int RESULT_ERR_OWNED = 4;

	public const int RESULT_ERR_BAD_DATA = 5;

	public const int RESULT_ERR_USER_NOT_FOUND = 6;

	public const int RESULT_ERR_INVALID = 7;

	public const int RESULT_ERR_OTHER = 8;

	public const int RESULT_ERR_NOT_OWNED = 9;

	public const int RESULT_ERR_FACEBOOK_AUTH_FAILED = 10;

	public const int RESULT_ERR_FACEBOOK_LINK_FAILED = 11;

	public const int RESULT_ERR_FACEBOOK_NOT_LINKED = 12;

	public const int RESULT_ERR_FACEBOOK_UNLINK_FAILED = 13;

	public const int RESULT_ERR_FACEBOOK_UNLINK_NOTMATCH = 14;

	public const int RESULT_OK_INSTEAD = 100;

	public const int RESULT_OK_FACEBOOK_ALREADY_LINKED = 101;

	public const int RESULT_OK_FACEBOOK_ALREADY_TAKEN = 102;

	public const string INVALID_STRING = "undefined";

	public const string INVALID_FACEBOOK_ID = "undefined";

	public const string DELETE = "DELETE";

	public const int STATUS_OK = 1;

	public const int STATUS_ERROR = 0;

	public const int PVP_TYPE_ERROR = -1;

	public const int PVP_TYPE_NONE = 0;

	public const int PVP_TYPE_AIMING = 1;

	public const int PVP_TYPE_SHOOT = 2;

	public const int MAX_SCORE = 1000000;

	public const int GAME_RESULT_WIN = 1;

	public const int GAME_RESULT_DRAW = 2;

	public const int GAME_RESULT_LOSE = 3;

	public const int ROOM_GAME_LOADING_ASSET = 0;

	public const int ROOM_GAME_WAITING = 1;

	public const int ROOM_GAME_PLAYING = 2;

	public const int ROOM_GAME_END = 3;

	public const int PVP_EXCHANGE_TIME = 30;

	public const int CHONG_CI_GAME_NORMAL_TIME = 45;

	public const int CHONG_CI_GAME_FINALS_TIME = 15;

	public const int CHONG_CI_GAME_BEGIN_WAITING_TIME = 6;

	public const int CHONG_CI_GAME_FINALS_WAITING_TIME = 3;

	public const int CHALLENGE_GAME_TIME = 120;

	public const int CHALLENGE_LEVEL_COUNT = 30;

	public const long CHALLENGE_TIME_BITS = 10000000L;

	public const int BINGO_MAX_ROUND = 30;

	public const int FRIENDS_VS_MAX_BET = 10000;

	public const int ERR_FRIEND_ID_NOT_EXIST = 0;

	public const int PVP_SHOOT_OK = 0;

	public const int ERR_PVP_EQUIP_ID = 1;

	public const int ERR_PVP_TARGET_NOT_EXIST = 2;

	public const int ERR_PVP_SHOOT_POS = 3;

	public const int ERR_PVP_TARGET_POS = 4;

	public const int ERR_PVP_GAME_NOT_PLAYING = 5;

	public const int ERR_PVP_ROUND_ERROR = 6;

	public const int ERR_PVP_ROOM_PID_NOT_EXIST = 7;

	public const int ERR_PVP_WIND_ERROR = 8;

	public const int ERR_PVP_TARGET_TIME_ERROR = 9;

	public const int RETRY_FAIL_ROOM_NOT_EXIST = 0;

	public const int RETRY_FAIL_HEART_NOT_ENOUGH = 1;

	public const int RETRY_FAIL_OTHERS = 2;

	public const int ARENA_LOW_LEVEL = 0;

	public const int ARENA_HIGH_LEVEL = 1;

	public const int PLAYER_STATE_NULL = -1;

	public const int PLAYER_STATE_IN_ROOM_NOT_REMATCH = 0;

	public const int PLAYER_STATE_IN_ROOM_REMATCHED = 1;

	public const int PLAYER_STATE_LEAVE_ROOM = 2;

	public const int EQUIP_OPERATE_UPGRADE = 0;

	public const int EQUIP_OPERATE_SELECT = 1;

	public const int EQUIP_OPERATE_BUY_ARROW = 2;

	public const int EQUIP_REASON_GOLD_NOT_ENOUGH = 0;

	public const int EQUIP_REASON_DIAMOND_NOT_ENOUGH = 1;

	public const int EQUIP_REASON_CARD_NOT_ENOUGH = 2;

	public const int EQUIP_REASON_EQUIP_NOT_OWNED = 3;

	public const int EQUIP_REASON_GAME_PLAYING_NOT_ALLOWING = 4;

	public const int EQUIP_REASON_IS_MAX_LEVEL = 5;

	public const int EQUIP_REASON_ARROW_NOT_ALLOW_BUY = 6;

	public const long SHOP_UPDATE_BETWEEN_TIME_MIL = 86400000L;

	public const int CHALLENGE_START_WEEK_ID = 5;

	public const int CHALLENGE_END_WEEK_ID = 7;

	public const int CHALLENGE_OPEN_DAYS = 3;

	public const int CHALLENGE_CLOSE_DAYS = 4;

	public const int SEGMENT_MIN = 1;

	public const int SEGMENT_MAX = 13;

	public const float ScreenWidth = 720f;

	public const float screenHeight = 1280f;

	public const ChestKind TUTORIAL_CHEST_KIND = ChestKind.chest_guide;

	public const int TUTORIAL_CHEST_ID = 1;

	public const int TUTORIAL_EQUIP_BOW_TYPE = 1002;

	public const int TUTORIAL_EQUIP_BOW_LEVEL = 2;

	public const int VERSION_STATE_VALID = 0;

	public const int VERSION_STATE_INVALID = 1;

	public const int VERSION_STATE_COMPATITABLE = 2;

	public static int version_state;

	public static int last_resumeState;

	public const int RESUME_STATE_BILLING = 0;

	public const int RESUME_STATE_WATCH_VIDEO = 1;

	public const int RESUME_STATE_OTHER = -1;

	public const int third_type_social_facebook = 0;

	public const int third_type_social_google = 1;

	public const int third_type_mail = 2;

	public const int third_type_phone = 3;

	public const int MAX_NAME_LENGTH = 14;

	public const int RATE_GAME_WIN_NUMBER = 2;

	public const int QUEST_DAILY_HOURS = 4;

	public const int CHANGE_NAME_DAYS = 60;

	public const int Show_Main_Hand_GAME_Count = 2;

	public const int Show_Class_Hand_GAME_Count = 3;

	public const int Show_Grade_Hand_GAME_Count = 1;

	public const int Show_Grade_Hand_Grade_Number = 1;

	public const int FINISH_GAME_NUMBER = 1;
}
