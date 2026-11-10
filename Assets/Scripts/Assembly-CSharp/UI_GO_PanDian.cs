using UnityEngine;

public class UI_GO_PanDian : MonoInstance<UI_GO_PanDian>, UIBase
{
	public UI_GO_PanDian_Score uiScore;

	[HideInInspector]
	public UI_GameOver uiGameOver;

	private UIGameOverParam uiParam;

	private PanDianResultWindow curShowWind;

	private FlexibleTimeRegulator m_tTimeRegulator;

	private bool buttonEnable;

	public void Show(UI_GameOver _uiGameOver, UIGameOverParam _uiParam)
	{
	}

	private void Update()
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
}
