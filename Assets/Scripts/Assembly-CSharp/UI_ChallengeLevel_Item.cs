using UnityEngine;

public class UI_ChallengeLevel_Item : MonoBehaviour
{
	private ChallengeLevelItemState state;

	private UI_ChallengeLevel_List uiLevelList;

	public GameObject objUnlockPassed;

	public GameObject objUnlockNotPlayed;

	public GameObject objLocked;

	public GameObject objPefect;

	public UIButton btUnlockedPassed;

	public UIButton btUnlockedNotPlayed;

	public UIButton btLocked;

	public UILabel lLevel1;

	public UILabel lLevel2;

	public UISprite sPassMedalIcon;

	private int index;

	[HideInInspector]
	public int levelID;

	private GameType gameType;

	private bool hasSetScale;

	public void Init(UI_ChallengeLevel_List _uiLevelList, GameType _gameType, int _levelID, int _index)
	{
	}

	public void UpdateState()
	{
	}

	private void Start()
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

	public void ShowLevelInfo()
	{
	}

	public void showPassLevelIcon(ChallengeLevel challengePassLevel)
	{
	}
}
