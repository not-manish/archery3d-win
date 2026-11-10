using UnityEngine;

public class UI_Sale_Common_Item : MonoBehaviour
{
	public UISprite sItemBg;

	public UIButton btnInfo;

	public UISprite sItem;

	public UILabel lRewardCount;

	public UILabel lNameOrNum;

	public RewardType reward_type;

	private LimitedTimeBuyOriData oridata;

	public int index;

	private int rewardID;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(LimitedTimeBuyOriData _oridata, int childCount)
	{
	}

	public void UpdateState(int childCount)
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
