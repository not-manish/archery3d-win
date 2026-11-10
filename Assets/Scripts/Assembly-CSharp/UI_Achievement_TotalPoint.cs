using UnityEngine;
using com.simple.proto;

public class UI_Achievement_TotalPoint : MonoBehaviour
{
	public UIButton btCollect;

	public UILabel lAchievementProgress;

	public UISprite sAchievementProgress;

	public int NowPoint;

	public int MaxPoint;

	public UISprite sRewardIcon;

	public int AchievementItemId;

	public int chest_kind;

	public int chest_id;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void UpdateInfo()
	{
	}

	public void Hide(object param)
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void GotoNextAchievement()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void GetSuccess(CCChestReward cchestReward)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
