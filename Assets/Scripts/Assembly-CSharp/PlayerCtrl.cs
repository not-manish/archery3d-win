using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
	[HideInInspector]
	public Player myPlayer;

	[HideInInspector]
	public Player oppPlayer;

	public void AwakeInit(GameType gameType, int levelID, PlayerStandPart playerStandPart)
	{
	}
}
