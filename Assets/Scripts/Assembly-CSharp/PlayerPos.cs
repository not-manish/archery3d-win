using UnityEngine;

public class PlayerPos : MonoBehaviour
{
	public ScenePosType posType;

	public Transform PlayerTrans;

	public Transform CamAimBeforeTrans;

	public float CamAimBeforeField;

	public Transform CamAimAfterTrans;

	public float CamAimAfterField;

	public Transform OppShootCamTrans;

	public float OppShootCamField;

	public Vector3 GetPlayerPos()
	{
		return default;
	}

	public Quaternion GetPlayerRot()
	{
		return default;
	}

	public Vector3 GetCamAimBeforePos()
	{
		return default;
	}

	public Quaternion GetCamAimBeforeRot()
	{
		return default;
	}

	public float GetCamAimBeforeField()
	{
		return 0f;
	}

	public Vector3 GetCamAimAfterPos()
	{
		return default;
	}

	public Quaternion GetCamAimAfterRot()
	{
		return default;
	}

	public float GetCamAimAfterField()
	{
		return 0f;
	}

	public Vector3 GetOppShootCamPos()
	{
		return default;
	}

	public Quaternion GetOppShootCamRot()
	{
		return default;
	}

	public float GetOppShootCamField()
	{
		return 0f;
	}
}
