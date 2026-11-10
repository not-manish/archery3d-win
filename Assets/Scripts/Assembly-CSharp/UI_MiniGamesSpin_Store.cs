using System.Collections.Generic;
using UnityEngine;

public class UI_MiniGamesSpin_Store : MonoBehaviour
{
	public UIButton btBack;

	public List<UI_MiniGamesSpin_Store_Item> uiLists;

	public UI_AnimationCtrl uiAnimationCtrl;

	private UI_MiniGames_Spin uiMiniGamesSpin;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_MiniGames_Spin _uiMiniGamesSpin)
	{
	}

	public void UpdateItems()
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
