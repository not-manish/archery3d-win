using UnityEngine;

public class UI_AchievementItem : MonoBehaviour
{
	public UIButton btCollect;

	public UILabel lTitle;

	public UILabel lDescribe;

	public UILabel lPointNum;

	public UILabel lAchievementProgress;

	public UISprite sAchievementProgress;

	public UISprite sAchievementPoint;

	public long NowPoint;

	public long MaxPoint;

	public GameObject oCollect;

	public GameObject oRewardIcon;

	public GameObject oDown;

	public UILabel lRewardNum;

	public UISprite sRewardIcon;

	public int AchievementItemId;

	public AchievementType achievementType;

	public AchieveItem achieve_Item;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void UpdateInfo(AchieveItem achieveItem)
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

	public bool GotoNextAchievement()
	{
		return false;
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void GetSuccess(AchieveItem achieveItem)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
