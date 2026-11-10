using UnityEngine;

public class UI_Offline_Creator : MonoBehaviour, UIBase
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

	public void ShowReady()
	{
	}

	public void ShowGO()
	{
	}

	public void ShowCurScore(int Score)
	{
	}

	public void UpdateScore(int levelID)
	{
	}

	public void AfterBuyObj_UpdateData(int levelID, int objCount)
	{
	}

	public int GetlTargetScore()
	{
		return 0;
	}

	public void UpdateWind()
	{
	}

	public void ShowGameOver()
	{
	}

	public void SetTimeEnable(bool enable)
	{
	}

	public void UpdateDistance(string targetDis = "")
	{
	}

	public void ShowBuyArrows()
	{
	}

	public SelectGameOverState isSelectGameOver(int levelID)
	{
		return SelectGameOverState.waitSelecting;
	}

	public void ShowBuyTimes()
	{
	}

	public void SetCancelButton(bool active)
	{
	}

	public void SetAimingCircleActive(bool active, object uiParam)
	{
	}
}
