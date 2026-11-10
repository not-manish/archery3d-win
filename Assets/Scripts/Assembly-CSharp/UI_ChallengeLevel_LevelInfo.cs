using UnityEngine;

public class UI_ChallengeLevel_LevelInfo : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btPlay;

	public UIButton btClose;

	public UILabel lLevel1;

	public UILabel lLevel2;

	public UILabel lGoalPassScore;

	public UILabel lGoalFullScore;

	public UILabel lGoalArrowNum;

	public UILabel lGoalSumTime;

	public UILabel lBestScore;

	public UILabel lBestTime;

	public GameObject oPerfect;

	public GameObject oPlayFree;

	public GameObject oPlayCost;

	public UILabel lPlayCostGoldWhite;

	public UILabel lPlayCostGoldRed;

	private bool isPassedLevel;

	private long RepeatCostGold;

	public UISprite sPassMedalIcon;

	private UI_ChallengeLevel uiChallengeLevel;

	private int levelIndex;

	private int levelID;

	private ChallengeLevelItemState levelState;

	public UI_Downloading_Tips uiDownloadingTips;

	private string SceneName;

	private SingleFileState isNeedDown;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_ChallengeLevel _uiChallengeLevel, int _levelID, int _levelIndex, ChallengeLevelItemState _state)
	{
	}

	private void UpdateState()
	{
	}

	public void Hide(bool enforce)
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

	public void GoToShopBuyGold()
	{
	}

	public void showPassLevelIcon(ChallengeLevel challengePassLevel)
	{
	}

	public void CheckIsDownloading()
	{
	}

	public void ShowUnlock(SingleFileState singleFileState)
	{
	}
}
