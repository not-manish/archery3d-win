using UnityEngine;

public class UI_Equip_Detail_Arrow_Fighting_Item : MonoBehaviour
{
	public UIButton btBackground;

	public UISprite sFrontArrow;

	public UISprite sBigBackground;

	public UISprite sSelectedBackground;

	public GameObject oSelected;

	public GameObject oFocus;

	public UILabel lNumber;

	private int typeID;

	private UI_Equip_Detail_Arrow_Fighting_List uiList;

	public void UpdateState(UI_Equip_Detail_Arrow_Fighting_List _uiList, int _typeID, int focusTypeID)
	{
	}

	public void UpdateColor(int quality)
	{
	}

	private void Start()
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
