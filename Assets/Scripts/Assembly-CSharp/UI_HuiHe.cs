using UnityEngine;

public class UI_HuiHe : MonoInstance<UI_HuiHe>, UIBase
{
	public UI_HuiHe_Score uiHuiHeScore;

	public Transform tTargetDis;

	public UILabel lTargetDis;

	public UISprite sRedDist;

	private bool hasSetScale;

	private bool buttonEnable;

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

	public void CommonButtonClicked(ButtonType buttonType)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void OnPressScreen(bool press)
	{
	}

	public void OnTouchScreen(Vector2 pos)
	{
	}

	public void ShowCurScore()
	{
	}

	public void ShowGameMode()
	{
	}

	public void ShowTargetHit(bool isNextRound)
	{
	}

	public void ShowTurnHints(bool isMyTurn)
	{
	}

	public void UpdateDistance(string targetDis = "")
	{
	}

	public void UpdatePlayerPhoto()
	{
	}

	public void UpdateWind(bool isShowMyWind)
	{
	}

	public void UpdateScore(bool isNextRound, UpdatePlayerScore scoreType)
	{
	}

	public void ResetShootingTime(float duration, float timeLeft, OnlineNormalState PlayerState)
	{
	}

	public void CloseShootingTime(bool isClearProgress, OnlineNormalState PlayerState)
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
}
