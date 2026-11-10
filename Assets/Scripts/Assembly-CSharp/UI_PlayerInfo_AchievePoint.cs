using System.Collections.Generic;
using UnityEngine;

public class UI_PlayerInfo_AchievePoint : MonoBehaviour
{
	public UIButton btViewAchievement;

	public List<UI_PlayerInfo_AchievementItem> achievement;

	public UISprite sNewAchievementIcon;

	public UILabel lNewAchievementNum;

	public Dictionary<AchievementType, List<AchievementSubItem>> AllAcievementItem;

	public Dictionary<AchievementType, int> AllAcievementItemNewCount;

	private long ArenaStatsTotalGames;

	private long ArenaStats12WinGames;

	private long StatsRoyale10RingTimes;

	private long StatsRoyaleTotleRingTimes;

	private PlayerData playerData;

	public AchievementData achievementData;

	private void Start()
	{
	}

	public void UpdateAchieveInfo(object param)
	{
	}

	public void ShowAchieve(PlayerData playerData)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}
}
