using UnityEngine;

public class UI_ChongCi_Creator : MonoBehaviour, UIBase
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

	public void ShowMyCurScore()
	{
	}

	public void ShowGameMode()
	{
	}

	public void ShowMiddleHints(FightingHintType hintType, float ShowingTime)
	{
	}

	public void UpdateScore(PlayerStandPart standPart, bool isNextRound, UpdatePlayerScore scoreType)
	{
	}

	public void UpdateDistance(string targetDis = "")
	{
	}

	public void UpdatePlayerPhoto()
	{
	}

	public void UpdateWind()
	{
	}

	public void ResetSumTimeLeft(float duration, float timeLeft, OnlineNormalState playerstate)
	{
	}

	public void CloseSumTimeLeft(bool isClearProgress, float duration, float timeLeft, OnlineNormalState playerstate)
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
}
