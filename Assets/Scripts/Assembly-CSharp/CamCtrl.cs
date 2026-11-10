using UnityEngine;

public class CamCtrl : MonoBehaviour
{
	public enum CamCtrlStates
	{
		None = 0,
		CamMoveAni = 1,
		AimBefore_enforce = 2,
		AimBefore_slow = 3,
		AimBefore2Aiming = 4,
		Aiming = 5,
		OppAiming = 6,
		ArrowFlying = 7
	}

	public Camera playerCam;

	public Camera sceneCam;

	public Camera followCam;

	private FlexibleTimeRegulator m_tTimeRegulator;

	private CamCtrlStates camState;

	private CamFollowArrowParam followParam;

	private InterpolationType interType;

	private float curMoveTime;

	private float moveTime;

	private Vector3 startPos;

	private Quaternion startRot;

	private float startPlayerFov;

	private float startSceneFov;

	private Vector3 targetPos;

	private Quaternion targetRot;

	private float targetPlayerFov;

	private float targetSceneFov;

	private CamMoveAni camMoveAni;

	public void SetCamState(CamCtrlStates state, object param)
	{
	}

	private void LateUpdate()
	{
	}

	public float GetRealArrowSpeed(float Speed)
	{
		return 0f;
	}

	private Vector3 GetArrivePosOffset(Vector3 CamPos, Vector3 ArrowPos)
	{
		return default;
	}

	private Vector3 GetArriveBarOffset(Vector3 CamPos, Vector3 ArrowPos)
	{
		return default;
	}

	private Vector3 GetValidPos(Vector3 targetPos, Vector3 curPosition)
	{
		return default;
	}

	private bool ArrowInRegion(Vector3 arrowPos)
	{
		return false;
	}

	public void SetTargetPosAndRot(Vector3 _targetPos, Quaternion _targetRot, float _targetPlayerField, float _targetSceneField, bool isEnforce, float _moveTime = 0.5f)
	{
	}

	public Camera GetPlayerCamera()
	{
		return null;
	}

	public Camera GetSceneCamera()
	{
		return null;
	}

	public Quaternion GetRotation()
	{
		return default;
	}

	public Vector3 GetPosition()
	{
		return default;
	}

	public void SetRotation(Quaternion rotation)
	{
	}

	public void SetPosition(Vector3 position)
	{
	}

	public void PlayCamShake()
	{
	}
}
