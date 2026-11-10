using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class ArrowFly : MonoBehaviour
{
	[HideInInspector]
	public int ModelIndex;

	public ArrowEffect arrowEffect;

	public Animation arrowAnimation;

	public Transform arrowStart;

	public Transform arrowEnd;

	public Transform arrowModel;

	private ArrowFlyState currentState;

	[HideInInspector]
	public List<bool> hasReachTarget;

	[HideInInspector]
	public bool IsMyShoot;

	private float ArrowFlySpeed;

	private float ArrowRealFlySpeed;

	private Vector3 cam_start_pos;

	private Vector3 cam_start_dir;

	private float target_z;

	private bool hasWind;

	private float windSpeed;

	private float windAngle;

	private float bowEffRealZDis;

	private float ArrowFlyParamA;

	private float ArrowFlyParamB;

	[HideInInspector]
	public List<int> hit_target_ids;

	private List<Vector3> hit_target_center;

	private List<Vector3> hit_target_point;

	private List<Vector3> hit_target_forward;

	private List<Vector3> hit_target_top;

	private bool shouldChangeTrace;

	public List<Transform> AllHitObjects;

	private Transform TraceTrans;

	private Transform ArrowsParent;

	private Vector3 hitLocalPos;

	private ArrowExtraParam arrowExtraParam;

	[HideInInspector]
	public bool hasReceiveServeData;

	[HideInInspector]
	public bool IsShootValid;

	private Vector3 lastLocalHitPos;

	private float XYrotateSpeed;

	private float MaxX;

	private float MinX;

	private float MaxY;

	private float MinY;

	private FlexibleTimeRegulator m_timeRegulator;

	private static float _barMaxZ;

	private void ClearFlyParam()
	{
	}

	public void ClearReceiveServeData()
	{
	}

	private void Update()
	{
	}

	public float GetRealArrowSpeed()
	{
		return 0f;
	}

	public void InitFlyingParam(ArrowExtraParam _arrowFlyParam)
	{
	}

	public void ArrowSetParamFromServe(CCPVPResponse ccResponse)
	{
	}

	public void InitArrow(Vector3 _startPos, Quaternion rotation, ArrowExtraParam _arrowFlyParam)
	{
	}

	public static void GetArrowFlyingTimeAndMaxZ(ArrowExtraParam _arrowFlyParam, ref float FlyingTime, ref float MaxZ)
	{
	}

	public void CheckReachTarget()
	{
	}

	private bool ArrowNotInregion()
	{
		return false;
	}

	private void ReachTargetDeal(int serveID, Vector3 hitPosition)
	{
	}

	private void ShowTargetScore(TargetCtrl targetCtrl)
	{
	}

	public List<int> GetScore(TargetNormalType targetNormalType, Vector3 HitPos, Vector3 VecTarCenter, Vector3 VecTarForward, Vector3 VecTarTop)
	{
		return null;
	}

	private void CheckShouldChangeTrace()
	{
	}

	private bool ShouldChangeTraceNow()
	{
		return false;
	}

	private bool CanHitSomewhere(Vector3 hitPos, ref Transform hitTrans)
	{
		return false;
	}

	public void SetCurrentState(ArrowFlyState state)
	{
	}

	public Vector3 GetPosition()
	{
		return default;
	}

	public Vector3 SetPosition(Vector3 pos)
	{
		return default;
	}

	public Quaternion GetRotation()
	{
		return default;
	}

	public void SetRotation(Quaternion rot)
	{
	}

	public Vector3 GetForward()
	{
		return default;
	}

	public bool IsArrowArriveTagretBar()
	{
		return false;
	}

	public bool IsArrowArrivePos()
	{
		return false;
	}

	public bool HasUnreachedTarget()
	{
		return false;
	}
}
