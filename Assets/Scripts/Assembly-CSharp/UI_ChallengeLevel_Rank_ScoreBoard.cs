using System.Collections.Generic;
using UnityEngine;

public class UI_ChallengeLevel_Rank_ScoreBoard : MonoBehaviour
{
	public UI_ChallengeLevel_Rank_ScoreBoard_Total uiTotal;

	public UIButton btClose;

	public Transform tParent;

	public UIScrollView uiScrollView;

	public List<UI_ChallengeLevel_Rank_ScoreBoard_Item> items;

	public UI_WaitLoading uiWaitLoading;

	private int index;

	private UIChallengeBoardParam uiParam;

	private float Ystart;

	private float ItemHeight;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void AskRank()
	{
	}

	private void CreateItems()
	{
	}

	private void UpdateState()
	{
	}

	private void GetLevelScore(bool isMy, int challenge_id, ref bool isExist, ref long score)
	{
	}

	private void SetPositon()
	{
	}

	public void Hide()
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

	public void ChallengeBoardResponse()
	{
	}

	public void ResPonse()
	{
	}

	public void ReconnectLoginSuccess()
	{
	}

	public void ShowWaiting()
	{
	}

	public void HideWaitiing()
	{
	}
}
