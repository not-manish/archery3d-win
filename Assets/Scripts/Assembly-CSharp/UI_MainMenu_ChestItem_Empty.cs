using UnityEngine;

public class UI_MainMenu_ChestItem_Empty : MonoBehaviour
{
	public UIButton btBacground;

	public GameObject sChestIconBack;

	private int index;

	private UI_MainMenu_ChestItem uiParent;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_MainMenu_ChestItem _uiParent, int _index, object param)
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
