using UnityEngine;

public class CamTargetParam
{
	public Vector3 targetPos;

	public Quaternion targetRot;

	public float targetPlayerFOV;

	public float targetSceneFOV;

	public float moveTime;

	public CamTargetParam()
	{
	}

	public CamTargetParam(Vector3 _targetPos, Quaternion _targetRot, float _targetPlayerFOV, float _targetSceneFOV, float _moveTime)
	{
	}
}
