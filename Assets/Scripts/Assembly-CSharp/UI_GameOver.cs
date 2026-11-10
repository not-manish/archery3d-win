using UnityEngine;

public class UI_GameOver : MonoInstance<UI_GameOver>, UIBase
{
	public UI_GO_Common uiCommon;

	public UI_GO_PanDian uiPanDian;

	public UI_GO_HuiHe uiHuiHe;

	public UI_GO_ChongCi uiChongCi;

	public UI_GO_Bingo uiBingo;

	public UI_GO_Single uiSingle;

	public UI_GO_Reward uiReward;

	public UIButton PlayAnim;

	private UIGameOverParam uiParam;

	private GameOverWindow goWindow;

	private bool hasSetScale;

	private FlexibleTimeRegulator m_tTimeRegulator;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void PlayerWinAnim()
	{
	}

	public void PlayerRewardAnim()
	{
	}

	public void PlayerTrophy(bool iswin)
	{
	}

	public void PlayerWinAnimFinish()
	{
	}

	public void Update()
	{
	}

	public void PlayerHeadAnimFinish()
	{
	}

	public void HideShowingPanel()
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

	public static void SetSceneLogo(UISprite sLogo, GameType gameType, int levelID)
	{
	}

	public void ShowWindow(GameOverWindow type)
	{
	}

	public void CheckLeagueRank()
	{
	}
}
