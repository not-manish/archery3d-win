using UnityEngine;

public class UI_PanDian : MonoInstance<UI_PanDian>, UIBase
{
	public UI_PanDian_Score uiPanDianScore;

	public Transform tTargetDis;

	public UILabel lTargetDis;

	public UISprite sRedDist;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	private void Update()
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

	public void ShowTargetHit(bool isNextRound)
	{
	}

	public void ShowTurnHints()
	{
	}

	public void ShowGameMode()
	{
	}

	public void ShowSetsResult()
	{
	}

	public void UpdateDistance(string targetDis = "")
	{
	}

	public void UpdateWind(bool isShowMyWind)
	{
	}

	public void UpdateScore(bool isNextRound, UpdatePlayerScore scoreType, bool isShowStarAnim = false)
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
