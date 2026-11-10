using UnityEngine;
using com.simple.proto;

public class UI_Quest_TotalPoint : MonoBehaviour
{
	public UIButton btCollect;

	public UILabel lQuestProgress;

	public UISprite sQuestProgress;

	public int NowPoint;

	public int MaxPoint;

	public UISprite sRewardIcon;

	public UILabel lPointChestName;

	public UILabel lPointChestNamebg;

	public UILabel lPointChestGrade;

	public int QuestItemId;

	public int chest_kind;

	public int chest_id;

	public QuestData ccQuestData;

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
