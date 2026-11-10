using UnityEngine;

public class UI_DiamondStore_Item : MonoBehaviour
{
	public UILabel lGrade;

	public UILabel lMoney;

	public UILabel lDiamondCount;

	public UISprite sDiamondIcon;

	public UIButton btPay;

	public GameObject oEffect;

	public GameObject oFree;

	public UILabel lFreeNumber;

	public UILabel lFreeNumberbg;

	private bool hasSetScale;

	public RewardType buyType;

	private int shopID;

	private void Start()
	{
	}

	public void Show(RewardType _buyType, int _ID)
	{
	}

	public void UpdateState(int _ID)
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
}
