using UnityEngine;

public class UI_Challenge : MonoInstance<UI_Challenge>, UIBase
{
	public UI_Challenge_ScoreCtrl uiScoreCtrl;

	public UI_Challenge_GameTimeCtrl uiGameTimeCtrl;

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

	public void UpdateScore(int levelID, bool isNextRound, bool isShowAnim = false)
	{
	}

	public void UpdateWind()
	{
	}

	public void SetTimeEnable(bool enable)
	{
	}

	public void ShowGameMode()
	{
	}

	public void ShowMiddleHints(FightingHintType fightingHints, float ShowingTime)
	{
	}

	public void ResetGameTime(float _sumTime, float _timeLeft)
	{
	}

	public void CloseGameTime()
	{
	}

	public void ClearGameTime()
	{
	}

	public void SetCancelButton(bool active)
	{
	}

	public void SetAimingCircleActive(bool active, object uiParam)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void UpdateDistance(string targetDis = "")
	{
	}
}
