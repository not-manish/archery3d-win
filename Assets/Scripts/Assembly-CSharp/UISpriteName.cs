using UnityEngine;

public class UISpriteName
{
	public enum FriendsButtonsColor
	{
		Blue = 0,
		Gray = 1,
		Green = 2,
		Orange = 3,
		Red = 4,
		ButtonGreen = 5,
		ButtonGray = 6,
		ButtonGreen1 = 7,
		GiveGiftsAllGreen = 8,
		GiveGiftsAllGray = 9,
		Button_Video_Gray = 10
	}

	public enum ColorType
	{
		DownTextColor = 0,
		DownTextOutLine = 1,
		MiddleDescribeColor = 2,
		GoldColor = 3
	}

	public static string trophySucces;

	public static string trophyFailed;

	public static string[] ScoreNumber;

	public static string FightingScoreZero;

	public static string[] FightingScoreNumber;

	public static string bingoScoreBlueBack;

	public static string bingoScoreRedBack;

	public static string bingoScoreWhiteBack;

	public static string bingoLineRed;

	public static string bingoLineBlue;

	public static string[] Emoji;

	public static Vector3 EquipArmLocalPos;

	public static Vector3 ShopArmLocalPos;

	public static Vector3 EquipNormalLocalPos;

	public static Vector3 EquipShopLocalPos;

	private const int ArmDefaultNum = 4;

	private const int BowDefaultNum = 7;

	private const int SightDefaultNum = 7;

	private const int StabilizerDefaultNum = 7;

	private const int ArrowDefaultNum = 7;

	public static string[] UIShopDiamond;

	public static string[] UIShopGold;

	public static string[] UIShopSpin;

	public static string UIPanDianNameHints;

	public static string UIHuiHeNameHints;

	private static string[] UIChestBig;

	public static string UIDiamond;

	public static string UIGold;

	public static string UICurLevelNonPercent;

	public static string UINextLevelNonPercent;

	public static string UICurLevelPercent;

	public static string UINextLevelPercent;

	public static Color BlueColor;

	public static Color PurpleColor;

	public static Color OrangeColor;

	public static Color WhiteColor;

	public static string MailCollected;

	public static string MailNotCollect;

	public static string SystemMailBlue;

	public static string SystemMailGray;

	public static string FriendsMail;

	public static string MailIconBlue;

	public static string MailIconBlack;

	public static string MailTabBlue;

	public static string MailTabGray;

	public static string[] ChallengeStatsIcon;

	public static string[] AchievementIcon;

	public static string[] Achievemet_OR_Quest_Top_State_Icon;

	public static string[] QuestDailyGiftArrows;

	public static string QuestDailyGiftNormal;

	public static string QuestDailyGiftCanCollect;

	public static string QuestDailyGiftCollected;

	private static string[] Friends_Buttons;

	public static string[] OnSaleTypeIcon;

	public static string[] OnSaleCommonTypeTopIcon;

	public static string SpinFree_PrizeList_Icon;

	public static string SpinPay_PrizeList_Icon;

	public static string SpinFree_line;

	public static string SpinPay_line;

	public static string SpinFreeArrow;

	public static string SpinFreeBigRing;

	public static string SpinFreeMoveBg;

	public static string SpinSuperArrow;

	public static string SpinSuperBigRing;

	public static string SpinSuperMoveBg;

	public static string SpinSuperFullProgress;

	public static string SpinSuperProgress;

	public static string SpinFreeProgress;

	public static string SpinFreeFullProgress;

	public static string Freetype;

	public static string Supertype;

	public static string FreeSpecialIcon;

	public static string SuperSpecialIcon;

	public static string FreeSpecialItem;

	public static string FreeNormalItem;

	public static string SuperSpecialItem;

	public static string SuperNormalItem;

	public static string ShowBtnOn;

	public static string ShowBtnOff;

	public static string BlueDot;

	public static string OrangeDot;

	public static string[] UIArenaWinBack;

	public static string[] UIArenaWinNum;

	public static string NormalDailyBonus;

	public static string CanCollectDailyBonus;

	public static Color winColor;

	public static string[] Cards;

	public static string[] Tickets;

	public static string Trophy;

	public static string LevelChoose_NotPassStar;

	public static string PassStar;

	public static string GameOver_NotPassStar;

	public static string black_LevelLock;

	public static string blue_LevelLock;

	public static string PlayerHeadMyBlue;

	public static string PlayerHeadOtherRed;

	public static string PlayerStarMyBlue;

	public static string PlayerStarOtherRed;

	public static Color32 PlayerTurnMyBlue;

	public static Color32 PlayerTurnOtherRed;

	public static string PlayerResultMyBlue;

	public static string PlayerResultOtherRed;

	public static string RuleBlackDot;

	public static string RuleOrangeDot;

	public static string GetSegmentLogo(ChallengeGroup challengeGroup)
	{
		return null;
	}

	public static string GetSegmentLogo(int Segment)
	{
		return null;
	}

	public static string GetTrophyLogo(ChallengeGroup challengeGroup)
	{
		return null;
	}

	public static string GetChallengeLevelMedal(ChallengeMedalType challengeMedalType)
	{
		return null;
	}

	public static bool GetSegmentArrow(int Segment, int index)
	{
		return false;
	}

	public static UIAtlas GetEquipArmUIAtlas(int index)
	{
		return null;
	}

	public static string GetEquipArmUISpriteName(int index)
	{
		return null;
	}

	public static UIAtlas GetEquipBowUIAtlas(int index)
	{
		return null;
	}

	public static string GetEquipBowUISpriteName(int index)
	{
		return null;
	}

	public static UIAtlas GetEquipSightUIAtlas(int index)
	{
		return null;
	}

	public static string GetEquipSightUISpriteName(int index)
	{
		return null;
	}

	public static UIAtlas GetEquipStabilizerUIAtlas(int index)
	{
		return null;
	}

	public static string GetEquipStabilizerUISpriteName(int index)
	{
		return null;
	}

	public static UIAtlas GetEquipArrowUIAtlas(int index)
	{
		return null;
	}

	public static string GetEquipArrowUISpriteName(int index)
	{
		return null;
	}

	public static string GetSceneLogo(SceneType sceneType)
	{
		return null;
	}

	public static string GetSceneBg(SceneType sceneType)
	{
		return null;
	}

	public static string GetSceneSmallBg(SceneType sceneType)
	{
		return null;
	}

	public static string GetSceneTrophyBg(SceneType sceneType)
	{
		return null;
	}

	public static string GetSceneGradeBg(SceneType sceneType)
	{
		return null;
	}

	public static string GetSceneRuleBg(SceneType sceneType)
	{
		return null;
	}

	public static string GetChestBackBigIcon(int index)
	{
		return null;
	}

	public static string GetArenaTicketSprite(ArenaType arenaType)
	{
		return null;
	}

	public static string GetChallengeLogo(ChallengeGroup group)
	{
		return null;
	}

	public static string GetChallengeGroupName(ChallengeGroup group)
	{
		return null;
	}

	public static string GetWindResistLevelSprite(int level)
	{
		return null;
	}

	public static Color GetWindResistLevelColor(int level)
	{
		return default;
	}

	public static string GetWinnerBonusLevelSprite(int level)
	{
		return null;
	}

	public static string GetCheerUpLevelSprite(int level)
	{
		return null;
	}

	public static string GetChallengeStatsIcon(int index, int Rank)
	{
		return null;
	}

	public static string GetFriendButtonType(FriendsButtonsColor friendsButtonsColor)
	{
		return null;
	}

	public static string GetSaleTypeIcon(LimitedTimeBuyCtrl.PackageType packageType)
	{
		return null;
	}

	public static string GetSaleCommonTypeTopIcon(LimitedTimeBuyCtrl.PackageType packageType)
	{
		return null;
	}

	public static string GetSaleSpecialIcon(LTB_UI_TYPE LimitedTimeBuyUiType)
	{
		return null;
	}

	public static void SetMoneyColor(UILabel label, long NeedMoney, long selfMoney)
	{
	}

	public static Color32 GetLimitedLevel(SceneType sceneType, ColorType colorType)
	{
		return default;
	}

	public static void SetIconBestPixel(UISprite sprite, int width, UIWidget.AspectRatioSource ratioSource = UIWidget.AspectRatioSource.BasedOnWidth)
	{
	}

	public static void SetIconPixelPerFect(UISprite sprite)
	{
	}

	public static void SetEquipIconBestPixel(UISprite sprite, EquipType equipType)
	{
	}

	public static void SetDistanceColor(Transform parentTransform)
	{
	}

	public static void setDistanceLableColor(UILabel lTargetDis)
	{
	}

	public static bool isDownloadAtlas(UIAtlas atlas)
	{
		return false;
	}

	public static bool isDownloadSaleAtlas()
	{
		return false;
	}

	public static void setSaleSprite(int ui_type_id, NewPlayerIconType newPlayerIconType, ref UISprite spriteName)
	{
	}
}
