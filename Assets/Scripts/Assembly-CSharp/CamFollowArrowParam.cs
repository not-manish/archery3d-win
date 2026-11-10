using UnityEngine;

public class CamFollowArrowParam
{
	public enum FollowState
	{
		Null = 0,
		Flying = 1,
		FlyingSlow = 2,
		WaitingToArrive = 3,
		ArriviedBar = 4,
		ArriviedPos = 5,
		ArrowOutSide = 6
	}

	public static Vector3 StartOffsetPos_LeftTop;

	public static Vector3 StartOffsetPos_Left_Middle;

	public static Vector3 StartOffsetPos_Left_MiddleDown;

	public static Vector3 StartOffsetPos_RightTop;

	public static Vector3 StartOffsetPos_Right_Middle;

	public static Vector3 StartOffsetPos_Right_MiddleDown;

	public static Vector3 StartOffsetPos_Top;

	public static Vector3 StartOffsetPos_Left_End_01;

	public static Vector3 StartOffsetPos_Right_End_01;

	public static Vector3 StartOffsetPos_Left_End_02;

	public static Vector3 StartOffsetPos_Right_End_02;

	public static Vector3 StartOffsetPos_Left_End_03;

	public static Vector3 StartOffsetPos_Right_End_03;

	public static Vector3 StartOffsetPos_Left_End_04;

	public static Vector3 StartOffsetPos_Right_End_04;

	public static float ArrowFollowSpeed;

	public static float CamArriveWaitingTime;

	public static float CamArriveTime;

	public static bool IsCamFolUniform;

	public static float ArrowArriveSpeed;

	public static float ArrowArriveXYOffset;

	public static float ArrowArriveZOffset;

	public static float SpeedTargetOffsetTrans;

	public static float CamSlowFollowStartTime;

	public static float CamSlowFollowAllTime;

	public static float CamSlowFollowTimeScale;

	public static Vector3 CamFollowMin;

	public static Vector3 CamFollowMax;

	public static Vector3 ArrowRegionMin;

	public static Vector3 ArrowRegionMax;

	public CamFolType camFolType;

	public CamFolPos startFolPos;

	public CamEndPos targetFolPos;

	public Player player;

	public ArrowFly arrowFly;

	public float arrowFlyTime;

	public float targetMaxZ;

	public float arrowSpeed;

	public bool useNearFol;

	public bool showCamSlowEffect;

	public Vector3 curFollowOffset;

	public Vector3 _StartFollowOffset;

	public Vector3 _TargetFollowOffset;

	public Vector3 ArrowArrivePos;

	public FollowState followState;

	public FlexibleTimeRegulator m_TimeRegulator;

	public FlexibleRealTimeRegulator m_tTimeForCamEffect;

	public void CalFollowParam()
	{
	}

	private void SetFolPos(CamFolPos folPosType, ref Vector3 folPos)
	{
	}

	private void SetEndPos(CamEndPos folPosType, ref Vector3 folPos)
	{
	}
}
