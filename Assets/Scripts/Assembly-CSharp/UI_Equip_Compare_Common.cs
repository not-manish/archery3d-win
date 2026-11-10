using System.Collections.Generic;
using UnityEngine;

public class UI_Equip_Compare_Common : MonoBehaviour
{
	public GameObject[] oPropertyCommonItems;

	public GameObject[] oEquipPropertiesAddNumLeft;

	public GameObject[] oEquipPropertiesAddNumRight;

	public GameObject oWinnerItem;

	public GameObject oCheerupItem;

	public UISprite[] oWinnerItemBoth;

	public UISprite[] oCheerupItemBoth;

	public GameObject[] oWinnerUpgrade;

	public GameObject[] oCheerupUpgrade;

	public UILabel[] lPropNameCommon;

	public UILabel[] lPropCurNumLeft;

	public UILabel[] lPropAddNumLeft;

	public UISprite[] sPropCurProgressLeft;

	public UISprite[] sPropNextProgressLeft;

	public UISprite[] sPropFullProgressLeft;

	public UILabel[] lPropCurNumRight;

	public UILabel[] lPropAddNumRight;

	public UISprite[] sPropCurProgressRight;

	public UISprite[] sPropNextProgressRight;

	public UISprite[] sPropFullProgressRight;

	public UILabel[] lWinnerLevel;

	public UILabel[] lCheerupLevel;

	public UILabel[] lWinnerUpgrade;

	public UILabel[] lCheerupUpgrade;

	public UIChangeWidgeColor[] colorWinner;

	public UIChangeWidgeColor[] colorCheerup;

	public UIButton btnLeftWinner;

	public UIButton btnLeftCheerUp;

	public UIButton btnRightWinner;

	public UIButton btnRightCheerUp;

	private float LeftWinnerLevel;

	private float LeftCheerUpLevel;

	private float RightWinnerLevel;

	private float RightCheerUpLevel;

	private UICompareParam uiParam;

	private UI_Equip_Compare uiCompare;

	private bool buttonEnable;

	private float lastClickUpgrade;

	private void Start()
	{
	}

	public void Show(UI_Equip_Compare _uiCompare, object param)
	{
	}

	public void UpdateState()
	{
	}

	private void UpdateWinnerProperties(int _index, bool canUpgrade, List<EquipPropertiesType> curPropertiesType, List<int> curPropertiesValue, List<EquipPropertiesType> maxPropertiesType, int curID, int maxID)
	{
	}

	private void UpdateWinnerProperties(int _index, bool canUpgrade, List<EquipPropertiesType> curPropertiesType, List<int> curPropertiesValue, List<EquipPropertiesType> nextPropertiesType, List<int> nextPropertiesValue)
	{
	}

	private void UpdateCheerupProperties(int _index, bool canUpgrade, List<EquipPropertiesType> curPropertiesType, List<int> curPropertiesValue, List<EquipPropertiesType> maxPropertiesType, int curID, int maxID)
	{
	}

	private void UpdateCheerupProperties(int _index, bool canUpgrade, List<EquipPropertiesType> curPropertiesType, List<int> curPropertiesValue, List<EquipPropertiesType> nextPropertiesType, List<int> nextPropertiesValue)
	{
	}

	private float GetProgress(int CurNum, int MaxNum)
	{
		return 0f;
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
