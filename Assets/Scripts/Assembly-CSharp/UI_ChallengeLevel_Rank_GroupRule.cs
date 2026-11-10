using System.Collections.Generic;
using UnityEngine;

public class UI_ChallengeLevel_Rank_GroupRule : MonoBehaviour
{
	public UIButton btBack;

	public UIWidget sForTopPlayer;

	public List<Transform> tDivisionList;

	public List<UI_ChallengeLevel_Rank_GroupRule_Item> uiList;

	public UIPanel uiScrollPanel;

	private bool hasSetScale;

	private UI_ChallengeLevel_Rank uiRank;

	private bool buttonEnable;

	private float Ystart;

	private float StartForSPlayer;

	private float ItemHeight;

	private float ArrowHeight;

	private void Start()
	{
	}

	public void Show(UI_ChallengeLevel_Rank _uiChallengeRank)
	{
	}

	private void UpdateState()
	{
	}

	public void GetMoveToTarget(int x)
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

	private void SetPositon(bool IsSplayerTop)
	{
	}
}
