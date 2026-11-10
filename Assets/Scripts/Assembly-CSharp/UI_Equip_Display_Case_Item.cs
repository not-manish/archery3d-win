using UnityEngine;

public class UI_Equip_Display_Case_Item : MonoBehaviour
{
	private UI_Equip_Display_Case uiCase;

	public UI_Equip_Display_Case_Color uiColor;

	public GameObject oUpArrow;

	public GameObject oUpgradeInfo;

	public GameObject oStartClub;

	public UIButton btItem;

	public UILabel lName1;

	public UILabel lName2;

	public UISprite sEquipSprite;

	public UILabel lCurLevel;

	public UILabel lEquipName;

	public UILabel lCardProgressNum;

	public UISprite sCardProgress;

	private EquipType equipType;

	private int equipID;

	private EquipState equipState;

	private bool buttonEnable;

	private void Start()
	{
	}

	private void Update()
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

	public void Show(UI_Equip_Display_Case _uiCase, EquipType _equipType, int _equipID)
	{
	}

	public void UpdateState()
	{
	}

	private void UpdateEquip(EquipType equipType, EquipOthersBase equipOtherBase)
	{
	}

	private void SetEquipState(EquipState _equipState)
	{
	}
}
