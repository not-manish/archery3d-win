using UnityEngine;

public class UI_Loading_Creator : MonoBehaviour, UIBase
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

	public void LoadingSceneFinished()
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
}
