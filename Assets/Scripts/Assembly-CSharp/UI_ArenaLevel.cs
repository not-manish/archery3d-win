using UnityEngine;

public class UI_ArenaLevel : MonoInstance<UI_ArenaLevel>, UIBase
{
	public UI_ArenaLevel_Select uiSelect;

	public UI_ArenaLevel_Join uiJoin;

	public UI_ArenaLevel_Success uiSuccess;

	private bool hasSetScale;

	private bool buttonEnable;

	public bool isJoinArena;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void ShowJoin(ArenaType arenaType)
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

	public void ButtonClickedLevel(int levelGrade)
	{
	}

	public void UpdateItems()
	{
	}

	private void ButtonCommonClicked(ButtonType buttonType)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void ArenaJoinResponse()
	{
	}

	public void GoToShopBuyGem()
	{
	}
}
