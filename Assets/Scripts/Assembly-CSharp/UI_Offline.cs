using UnityEngine;

public class UI_Offline : MonoInstance<UI_Offline>, UIBase
{
	public UI_Offline_ScoreCtrl uiScoreCtrl;

	public UI_Offline_GameOver uiGameOver;

	public UI_Offline_BuyArrows uiBuyArrows;

	public UI_Offline_BuyTimes uiBuyTimes;

	private int LevelID;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public void HideFighting()
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

	public void CommonButtonClicked(ButtonType buttonType)
	{
	}

	public void OnPressScreen(bool press)
	{
	}

	public void OnTouchScreen(Vector2 pos)
	{
	}

	public void ShowCurScore(int score)
	{
	}

	public void ShowReady()
	{
	}

	public void ShowGO()
	{
	}

	public void UpdateScore(int levelID)
	{
	}

	public void AfterBuyObj_UpdateData(int levelID, int objCount)
	{
	}

	public void UpdateWind()
	{
	}

	public void ShowGameOver()
	{
	}

	public void ShowBuyArrows()
	{
	}

	public void ShowBuyTimes()
	{
	}

	public void SetAimingCircleActive(bool active, object uiParam)
	{
	}

	public SelectGameOverState isSelectGameOver(int levelID)
	{
		return SelectGameOverState.waitSelecting;
	}

	public void SetTimeEnable(bool enable)
	{
	}

	public void UpdateDistance(string targetDis = "")
	{
	}

	public void SetCancelButton(bool active)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
