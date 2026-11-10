using UnityEngine;

public class UI_Challenge_Creator : MonoBehaviour, UIBase
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

	public void ShowCurScore(int Score)
	{
	}

	public void UpdateScore(int levelID, bool isNextRound, bool isShowAnim = false)
	{
	}

	public void UpdateWind()
	{
	}

	public void ShowGameMode()
	{
	}

	public void UpdateDistance(string targetDis = "")
	{
	}

	public void ShowMiddleHints(FightingHintType hintType, float ShowingTime)
	{
	}

	public void ClearGameTime()
	{
	}

	public void ResetGameTime(float _sumTime, float _timeLeft)
	{
	}

	public void StopGameTime()
	{
	}

	public void SetCancelButton(bool active)
	{
	}

	public void SetAimingCircleActive(bool active, object uiParam)
	{
	}
}
