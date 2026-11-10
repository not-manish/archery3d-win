using System.Collections.Generic;
using UnityEngine;

public class UI_ArenaLevel_Select_RewardList : MonoBehaviour
{
	public Transform tParent;

	public UIScrollView uiScrollView;

	public List<UI_ArenaLevel_Select_RewardItem> items;

	private const int MAX_COUNT = 13;

	private bool hasSetScale;

	private UI_ArenaLevel_Select uiSelect;

	private ArenaType arenaType;

	private float Ystart;

	private float ItemHeight;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_ArenaLevel_Select _uiSelect, ArenaType _arenaType)
	{
	}

	private void CreateItems()
	{
	}

	private void UpdateState(ArenaType arenaType)
	{
	}

	private void SetPositon()
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
