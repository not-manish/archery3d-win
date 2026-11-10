using UnityEngine;

public class UI_Equip_Detail_Arrow : MonoBehaviour
{
	public UI_Equip_Detail_Model uiModel;

	public UIButton btClose;

	public UIButton btShouEquip;

	public UISprite sBackGround;

	public int backgroundBig;

	public int backgroundSmall;

	public int backgroundForFighting;

	public float WindowPosYBig;

	public float WindowPosYSmall;

	public GameObject oAllBuys;

	public GameObject oCanSelect;

	public GameObject oSelected;

	public UISprite oResistWind;

	public UIButton btnWind;

	public GameObject oAimingSpeed;

	public GameObject oArrowSpeed;

	public GameObject[] oEquipProperties;

	public UILabel lArrowName;

	public UILabel lResistWindLevel;

	public UILabel[] lPropertiesName;

	public UILabel[] lPropertiesValue;

	public UISprite[] sProperties;

	public UILabel lAmount;

	public UIButton btSelect;

	public UISprite sEquipFront1;

	public UILabel lNumber1;

	public UILabel lPrice1;

	public UISprite sPrice1;

	public UIButton btBuy1;

	public UISprite sEquipFront2;

	public UILabel lNumber2;

	public UILabel lPrice2;

	public UISprite sPrice2;

	public UIButton btBuy2;

	public UISprite sEquipFront3;

	public UILabel lNumber3;

	public UILabel lPrice3;

	public UISprite sPrice3;

	public UIButton btBuy3;

	private EquipOperate equipOperate;

	public UI_Equip_Detail_Arrow_Fighting_List uiFightingList;

	private UIDetailArrowParam uiParam;

	private UI_Equip_Detail uiDetail;

	private EquipArrowsOriData arrowOriData;

	private PlayerData playerData;

	private ShopArrowOriData shopArrowData;

	private int showingTypeID;

	private bool buttonEnable;

	private float lastClickTime;

	private void Start()
	{
	}

	public void Show(UI_Equip_Detail _uiDetail, object param)
	{
	}

	public void UpdateState()
	{
	}

	private void UpdateState_Common(int typeID)
	{
	}

	private void UpdateState_Equip_OnlyInfo()
	{
	}

	private void UpdateState_Equip()
	{
	}

	private void UpdateState_Shop()
	{
	}

	private void UpdateState_Fighting(int typeID)
	{
	}

	private float GetProgress(int CurNum, int MaxNum)
	{
		return 0f;
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

	public void ShopScrollGem()
	{
	}

	public void GoToShopBuyGem()
	{
	}

	public void ClickedFocus(int ClickedTypeID)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void UpdatePlayerInfo()
	{
	}

	public void EquipOperateResponse()
	{
	}
}
