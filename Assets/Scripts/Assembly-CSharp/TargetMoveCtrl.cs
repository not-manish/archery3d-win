using System.Collections.Generic;
using UnityEngine;

public class TargetMoveCtrl : MonoBehaviour
{
	public static float TargetMoveStartTime;

	[HideInInspector]
	public int move_pos_id;

	[HideInInspector]
	public int move_rot_id;

	private bool enableMove;

	public static float curT;

	public bool isForTest;

	public bool isLogRot;

	public bool isLogPos;

	public float debugTime;

	private List<float> PosLineDis;

	private List<float> PosRunTimes;

	private float PosSumTime;

	private List<float> RotRunTimes;

	private float RotSumTime;

	public static void UpdateTargetMoveTime(float MovedTime)
	{
	}

	public static float GetTargetMovedTime()
	{
		return 0f;
	}

	public void SetMoveType(int _move_pos_id, int _move_rot_id)
	{
	}

	private void InitPos()
	{
	}

	private void InitRot()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetAllTargetsPosRot(float curT)
	{
	}

	public void SetAllTargetsPos_New(float curT)
	{
	}

	public void SetAllTargetsRot_New(float curT)
	{
	}

	public void ResetMove()
	{
	}

	public void ResumeMove()
	{
	}

	public void PauseMove()
	{
	}
}
