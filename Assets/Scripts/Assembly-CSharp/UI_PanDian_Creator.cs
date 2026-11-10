using UnityEngine;

public class UI_PanDian_Creator : MonoBehaviour, UIBase
{
	public UICreator creator;

	private string prefabName;

	private static object _lock;

	public void Init()
	{
	}

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public void HideEnforce()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void ShowCurScore()
	{
	}

	public void ShowSetsResult()
	{
	}

	public void ShowTargetHit(bool isNextRound)
	{
	}

	public void ShowGameMode()
	{
	}

	public void ShowTurnHints()
	{
	}

	public void UpdateScore(bool isNextRound, UpdatePlayerScore scoreType, bool isShowStarAnim = false)
	{
	}

	public void UpdateDistance(string targetDis = "")
	{
	}

	public void UpdateWind(bool isShowMyWind)
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
