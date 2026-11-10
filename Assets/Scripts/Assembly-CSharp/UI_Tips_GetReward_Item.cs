using UnityEngine;

public class UI_Tips_GetReward_Item : MonoBehaviour
{
	public UISprite sItemBg;

	public UIButton btnInfo;

	public UISprite sItem;

	public UILabel lRewardCount;

	public UILabel lNameOrNum;

	public RewardType reward_type;

	private TipRewardData oridata;

	private int rewardID;

	private bool hasSetScale;

	private float NameLeastY;

	private float RewardCountLeastY;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void UpdateState()
	{
	}

	public void UpdateStateGambling()
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

	public void SetPosition(int _rewardCount)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
