using UnityEngine;
using com.simple.proto;

public class UI_MiniGamesSpin_Result : MonoBehaviour
{
	public UIButton btGetReward;

	public UILabel lCollect;

	public UILabel lRewardName;

	public UISprite sReward;

	public UISprite sRewardbg;

	public UISprite sEquipBg;

	public UI_MiniGames_Spin uiMiniGamesSpin;

	public RouletteGiftsOriData rouletteGiftsOriData;

	public UI_AnimationCtrl ui_AnimationCtrl;

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

	public void ShowReward(RewardType rewardsNum)
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

	public void KeyEscapeClicked()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void GetRewardSuccess()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void OpenCoinGemAnim(ChestRewardType rewardType, int ShowObjCount)
	{
	}

	public int GetOpenCount(CCChestReward chestReward)
	{
		return 0;
	}
}
