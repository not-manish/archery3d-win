using UnityEngine;

public class UI_Sale_Special_Item : MonoBehaviour
{
	public UIButton btnInfo;

	public UISprite sItem;

	public UISprite sRewardBg;

	public UISprite sTopNameBg;

	public UISprite sItemBg;

	public UISprite sInfo;

	public GameObject oOtherReward;

	public UILabel lOtherRewardEquipCardCount;

	public UISprite sOtherRewardEquipCard;

	public UILabel lOtherEquipName;

	public UILabel lOtherEquipNamebg;

	public UILabel lOtherRewardCount;

	public UILabel lOtherNameOrNum;

	public GameObject oChestReward;

	public UILabel lChestNameOrNum;

	public UILabel lChestNameOrNumbg;

	public UISprite sChestCardTotal;

	public UILabel lChestRewardCardTotal;

	public UISprite sChestCard1;

	public UILabel lChestRewardCard1;

	public UISprite sChestCard2;

	public UILabel lChestRewardCard2;

	public UISprite sChestCard3;

	public UILabel lChestRewardCard3;

	public RewardType reward_type;

	private LimitedTimeBuyOriData oridata;

	public SaleItemType saleItemType;

	private int rewardID;

	private SaleSpecialItemData saleSpecialItemData;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(SaleSpecialItemData _saleSpecialItemData)
	{
	}

	public void UpdateState()
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

	private void UpdateState_Challenge()
	{
	}

	private static int GetCardExtraAdd(int Segment, int CardNum)
	{
		return 0;
	}

	public void KeyEscapeClicked()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void SetBgIconSprite()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
