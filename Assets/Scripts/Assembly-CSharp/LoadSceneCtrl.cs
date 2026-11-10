using UnityEngine;

public class LoadSceneCtrl : MonoBehaviour
{
	private enum LoadStates
	{
		Waiting1Frame = 0,
		LoadScene = 1,
		WaitingLoad = 2
	}

	private static SceneType sceneType;

	private static SceneState sceneState;

	private LoadStates loadState;

	public static void SetNextLoadingScene(SceneType _sceneType, SceneState _sceneState)
	{
	}

	public static SceneType GetSceneType()
	{
		return SceneType.S_City;
	}

	public static SceneState GetSceneState()
	{
		return SceneState.ForUI;
	}

	public static bool IsInUIScene()
	{
		return false;
	}

	public static void LoadScene(SceneType _sceneType)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
