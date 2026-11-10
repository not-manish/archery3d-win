using UnityEngine;

public class UI_ArenaLevel_Select_Tap : MonoBehaviour
{
	public GameObject oClassicSelected;

	public GameObject oClassicNotSelected;

	public GameObject oGrandSelected;

	public GameObject oGrandNotSelected;

	public UIButton btClassic;

	public UIButton btGrand;

	private UI_ArenaLevel_Select uiSelect;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_ArenaLevel_Select _uiSelect, ArenaType arenaType)
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
