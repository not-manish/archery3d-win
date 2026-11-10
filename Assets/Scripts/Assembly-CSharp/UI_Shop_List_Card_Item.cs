using UnityEngine;

public class UI_Shop_List_Card_Item : MonoBehaviour
{
	public UILabel lEquipTypeName;

	public UILabel lEquipName;

	public GameObject oUpgradeArrow;

	public GameObject oMoneyCost;

	public UISprite sEquip;

	public GameObject oSaleOut;

	public GameObject oLevelInfo;

	public GameObject oNewEquip;

	public UILabel lLevel;

	public UILabel lProgress;

	public UISprite sProgress;

	public UILabel lCostGemNum;

	public UIChangeWidgeColor uiChangeWidgetColor;

	private int typeID;

	private bool isGetDataFromServe;

	private bool isBuyedMaxTimes;

	private int buyTimes;

	public UIButton btBackground;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show()
	{
	}

	public void UpdateState(bool _isGetDataFromServe, int _typeID, int _buyTimes)
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
