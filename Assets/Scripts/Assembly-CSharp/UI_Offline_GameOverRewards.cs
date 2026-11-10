using UnityEngine;

public class UI_Offline_GameOverRewards : MonoBehaviour
{
	public UIButton btCollect;

	public UISprite sCard;

	public UILabel rewardsNum;

	public UISprite sChest;

	public int levelID;

	private RewardType rewardType;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(int _rewardType, int _levelID)
	{
	}

	private void UpdateState(RewardType RewardType)
	{
	}

	public void SetLevelMaterial(LevelPassStart levelPassStart)
	{
	}

	public void Hide()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void KeyEscapeClicked()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
