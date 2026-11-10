using UnityEngine;

public class UI_Shop_ChestDetail : MonoBehaviour
{
	public UISprite sChest;

	public UILabel lGrade;

	public UILabel lChestGold;

	public UILabel lTotalCards;

	public UILabel lTotalAddCards;

	private float Ytop;

	private float Ymiddle;

	private float Ydown;

	public GameObject oGuaranteedAll;

	public GameObject oGuaranteedOrange;

	public GameObject oGuaranteedPurple;

	public UILabel lGOrangeNum;

	public UILabel lGOrangeAdd;

	public UILabel lGPurpleNum;

	public UILabel lGPurpleAdd;

	public UIButton btBuy;

	public UIButton btExit;

	public UILabel lBuyDiamondWhite;

	public UILabel lBuyDiamondRed;

	public UIWidget wBackFrame;

	private bool hasSetScale;

	private int ChestId;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(int _ChestId)
	{
	}

	private void UpdateState()
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

	public bool IsShowing()
	{
		return false;
	}
}
