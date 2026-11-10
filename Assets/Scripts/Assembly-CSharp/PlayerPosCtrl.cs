using System.Collections.Generic;
using UnityEngine;

public class PlayerPosCtrl : MonoBehaviour
{
	private static PlayerPosCtrl instance;

	public List<PlayerPos> playerPoss;

	public static PlayerPosCtrl Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public PlayerPos GetPlayerPosScript(ScenePosType playerPosType)
	{
		return null;
	}
}
