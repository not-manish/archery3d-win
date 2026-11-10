using UnityEngine;

public class Coin_MoveTimeCtrl : MonoInstance<Coin_MoveTimeCtrl>
{
	public int CoinNum;

	public float MoveTotal_time;

	public float MoveTo_time;

	public float MoveBack_Time;

	public float MoveX;

	public float minY;

	public float maxY;

	public float MoveZ;

	public float StartScale;

	public float MiddleScale;

	public float EndScale;

	public Vector3 GoldEndRotation;

	public Vector3 DiamEndRotation;

	public float MoveFirst_Time;

	public float WaitMoveTime;

	public float waitTime;

	public float TimeMultiplier;

	public float MoveTimeMultiplier;

	public void SetTimeMultiplier(float Value = 1f)
	{
	}

	public void SetChestOpenTimeMultiplier(float _timeMultiplier = 0.85f, float _moveTimeMultiplier = 1f)
	{
	}

	public float GetWaitMoveTime(int index)
	{
		return 0f;
	}

	public float GetMoveToTime(int index)
	{
		return 0f;
	}

	public float GetMoveTotalTime(int index)
	{
		return 0f;
	}

	public float GetMoveBackTime(int index)
	{
		return 0f;
	}

	public float GetMoveFirstTime(int index)
	{
		return 0f;
	}

	public float GetWaitTime()
	{
		return 0f;
	}
}
