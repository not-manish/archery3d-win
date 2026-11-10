using UnityEngine;

public class UI_Loading : MonoInstance<UI_Loading>, UIBase
{
	public UI_Loading_Common uiLoadCommon;

	public UI_Loading_Connect uiLoadConnect;

	public UI_Loading_NetworkError uiNetError;

	public UI_AnimationCtrl uiAnimationCtrl;

	public bool EnablePlayAni;

	private bool hasSetScale;

	private UILoadingParam uiParam;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void UpdateState()
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

	public bool IsConnecting()
	{
		return false;
	}

	public void LoadingSceneFinished()
	{
	}
}
