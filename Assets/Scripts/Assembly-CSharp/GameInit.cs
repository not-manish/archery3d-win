using UnityEngine;

public class GameInit : MonoBehaviour
{
	private static bool isFirstTimeStartGame;

	public bool SendRobotPvpShoot;

	public static bool SendRobotPvpShootStatic;

	public bool SendPlayerPvpShoot;

	public static bool SendPlayerPvpShootStatic;

	public static int SendVersCount;

	public static bool NeedReconnectServe;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static void LoadData(bool IsFromResourceDir)
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnApplicationQuit()
	{
	}

	public static void Reconnect()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}
}
