using System.Collections.Generic;
using UnityEngine;

public class UI_Bingo : MonoInstance<UI_Bingo>, UIBase
{
	public UI_Bingo_Score uiBingoScore;

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

	public void CommonButtonClicked(ButtonType buttonType)
	{
	}

	public void KeyEscapeClicked()
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

	public void ShowCurScore(PlayerType playerType)
	{
	}

	public void ShowGameMode()
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

	public void UpdateScore(bool isNextRound, UpdatePlayerScore scoreType, bool isShowStarAnim = false)
	{
	}

	public void GetBingoShouldShoot(List<int> MyShouldShootPoint)
	{
	}

	public void GetBingoHideScore()
	{
	}

	public void ResetShootingTime(float duration, float timeLeft, OnlineNormalState PlayerState)
	{
	}

	public void CloseShootingTime(bool isClearProgress, OnlineNormalState PlayerState)
	{
	}

	public void UpdateHitPos()
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
