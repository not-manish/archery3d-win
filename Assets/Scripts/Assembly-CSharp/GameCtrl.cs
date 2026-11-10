using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class GameCtrl : MonoBehaviour
{
	private static GameCtrl instance;

	public GameCtrlEntity gameCtrlEntity;

	private GameCtrlData gameData;

	public static int ChestModelLayer;

	public static int UIModelLayer;

	public static int ShootPlayerLayer;

	public static int MoneyrLayer;

	private static GameStates gameState;

	private static List<float> listTimeScale;

	private static int ClickedBackTimes;

	private static float LastClickedBackTime;

	private const float DoubleClickedMaxTime = 2f;

	public static GameCtrl Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static GameStates GameStates => GameStates.Null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static void LoadUIScene(EnterUIState enterState)
	{
	}

	public static void AfterUILoading()
	{
	}

	public static void StartTutorialSingle()
	{
	}

	public static void GoToFighting()
	{
	}

	public static void AfterFightingLoading()
	{
	}

	public static void SetGameStates(GameStates _gameState)
	{
	}

	public static bool IsGameInfighting()
	{
		return false;
	}

	public static bool IsGameOnline()
	{
		return false;
	}

	public void ReceivePvpResponse(long transactionId, CCPVPResponse ccPvpResponse)
	{
	}

	public void ReceivePvpAimResponse(CCPvpAimOperateResponse pvpAimResponse)
	{
	}

	public void ExchangTurnResponse()
	{
	}

	public void GameOverResponse()
	{
	}

	public void GamePlayingStateResponse(CCGamePlayingStatesResponse stateRes)
	{
	}

	public void MatchResponse(CCMatchResponse matchResponse)
	{
	}

	public void LoadAssetSuccessResponse()
	{
	}

	public void ReceiveGameTimeBegin()
	{
	}

	public void ReceiveGameTimeEnd()
	{
	}

	public void UpdatePlayerInfo()
	{
	}

	public int CalculateScore(List<int> hitTargetServeIDs, List<Vector3> hitPos, List<Vector3> hitForward, List<Vector3> hitTop, bool AddTargetIdScores = false, Dictionary<int, int> ServeIdScores = null)
	{
		return 0;
	}

	public void GameTimeFinished()
	{
	}

	public static void UpdateTargetServeTime()
	{
	}

	public static void RecoverTimeScale()
	{
	}

	public static void SetTimeScale(float time)
	{
	}

	public static float GetTimeScale()
	{
		return 0f;
	}

	public static void SetActiveRecursively(Transform t, bool state)
	{
	}

	public static void SetLayerRecursively(GameObject go, int layerNumber)
	{
	}

	public void SetCancelButton(bool active)
	{
	}

	public void SetAimingCircleActive(bool active, object param = null)
	{
	}

	public void UpdatePlayerArrowTexture()
	{
	}

	public static void RecoverPlayerActive()
	{
	}

	public static void ShowRestart()
	{
	}

	public static void ClickedButtonBack()
	{
	}

	public void OnPressShootScreen()
	{
	}
}
