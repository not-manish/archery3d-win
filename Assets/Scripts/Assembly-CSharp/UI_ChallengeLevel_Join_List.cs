using System.Collections.Generic;
using UnityEngine;

public class UI_ChallengeLevel_Join_List : MonoBehaviour
{
	public UIScrollView uiScrollView;

	public UIWrapContentEx uiWrapContentEx;

	public List<UIChallengeLevelParam> uiChallengeLevelParams;

	private ChallengeGroup showGroup;

	private bool buttonEnable;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void UpdateState(ChallengeGroup group)
	{
	}

	private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
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
