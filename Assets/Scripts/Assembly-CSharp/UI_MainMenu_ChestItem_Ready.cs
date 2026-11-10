using UnityEngine;

public class UI_MainMenu_ChestItem_Ready : MonoBehaviour
{
	public UIButton btBackground;

	public UISprite sOpen;

	public UISprite sChestIconBack;

	public UILabel lChestName1;

	public UILabel lChestName2;

	public UILabel lChestGradeNum;

	public GameObject oChest;

	public UI_AnimationCtrl unMoveAnimationCtrl;

	public UI_LittleTips uiLittleTips;

	private int index;

	private ChestClassicSingle chestSingleData;

	private UI_MainMenu_ChestItem uiParent;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_MainMenu_ChestItem _uiParent, int _index, object param)
	{
	}

	private void UpdateState()
	{
	}

	private void UpdateState_Guide(int chestID)
	{
	}

	private bool IsTutorial(ChestClassicSingle _chestSingleData)
	{
		return false;
	}

	private void UpdateState_Classic(int chestID)
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
