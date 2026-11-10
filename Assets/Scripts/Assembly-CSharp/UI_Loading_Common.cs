using UnityEngine;

public class UI_Loading_Common : MonoBehaviour
{
	private enum State
	{
		LoadingScene = 0,
		LoadingOver = 1,
		Finished = 2
	}

	public UILabel lTips;

	public UILabel lPercent;

	public UI_Progress_Scroll uiProgress;

	public UITexture BG;

	public GameObject oTips;

	public UILabel lGameTips;

	private float targetPorgress;

	private FlexibleTimeRegulator m_tTimeRegulaor;

	private UI_Loading uiLoading;

	private State state;

	private bool buttonEnable;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Show(UI_Loading _uiLoading)
	{
	}

	public void ShowTips(bool isShow)
	{
	}

	public void Hide()
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

	public void LoadingSceneFinished()
	{
	}
}
