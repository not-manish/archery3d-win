using UnityEngine;

public class UI_GO_Single : MonoBehaviour
{
	public UI_GO_Single_Success uiSuccess;

	public UI_GO_Single_Failed uiFailed;

	public UILabel lLevel;

	public UILabel lLevelbg;

	public UI_AnimationCtrl WinShowAnimationCtrl;

	public UI_AnimationCtrl LoseShowAnimationCtrl;

	private UI_GameOver uiGameOver;

	private UIGameOverParam uiParam;

	private bool buttonEnable;

	public void Show(UI_GameOver _uiGameOver, UIGameOverParam _uiParam)
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

	public void ResetAnim()
	{
	}

	public void RetryReponse()
	{
	}

	public bool MatchResponse()
	{
		return false;
	}

	private void RetrySuccess()
	{
	}
}
