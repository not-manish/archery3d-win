using UnityEngine;

public class UI_MainMenu_MissonAndMiniGames : MonoBehaviour
{
	public UIButton btDailyMission;

	public UIButton btMiniGames;

	public UISprite sQuestNewTips;

	public UILabel lQuestNewTips;

	public UISprite sMiniGamesNewTips;

	public UILabel lMiniGamesNewTips;

	public UITexture tMiniGames;

	public UITexture tQuest;

	public Texture mGreenFlow;

	public Texture mYellowFlow;

	public UI_LogoScroll uiLogoScrollMiniGame;

	public UI_LogoScroll uiLogoScrollQuest;

	public UILabel lQuestValue;

	public UISprite sQuestValueProgress;

	public UISprite sQuestChest;

	public UI_mainMenu_TenGameChest uiMainMenuTenGameChest;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public UI_AnimationCtrl uiChestAnimationCtrl;

	public GameObject uiMinigameLight2;

	public UI_AnimationCtrl uiMinigameAnimationCtrl;

	private int minQuestPoint;

	private int maxQuestPoint;

	public void Show()
	{
	}

	public void ShowNewTips(NewTipsType newTipsType, bool isShow, int num = 1)
	{
	}

	public void Hide()
	{
	}

	public void ShowNewQuest(bool isShow, int num = 1)
	{
	}

	public void ShowNewMiniGames(bool isShow, int num = 1)
	{
	}

	private void Start()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void CheckQuest()
	{
	}

	public void CheckMiniGames()
	{
	}

	public void CheckWinChest()
	{
	}

	private void Update()
	{
	}
}
