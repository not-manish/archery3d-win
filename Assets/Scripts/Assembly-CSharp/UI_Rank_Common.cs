using UnityEngine;

public class UI_Rank_Common : MonoBehaviour
{
	public UITexture BG;

	public GameObject oSelectedLeague;

	public GameObject oSelectedFriends;

	public GameObject oSelectedGlobal;

	public GameObject oSelectedChallenge;

	public GameObject oButtonGlobal;

	public GameObject oButtonLeague;

	public GameObject oButtonFriends;

	public GameObject oButtonChallenge;

	public UI_WaitLoading uiWaitLoading;

	public UIButton btChallenge;

	public UIButton btLeague;

	public UIButton btFriends;

	public UIButton btGlobal;

	private UI_Rank uiRank;

	private RankWindows rankWindows;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Rank _uiRank, RankWindows _rankWindows)
	{
	}

	public void ShowWindow(RankWindows _rankWindows)
	{
	}

	public void WaitingLoadCtrl(bool isActive)
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
