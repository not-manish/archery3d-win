using System.Collections.Generic;
using PlayerStates;
using UnityEngine;

public class PlayerEntity : PlayerBase
{
	private StateMachine<PlayerEntity> m_pStateMachine;

	public ShootingStates m_sShootingState;

	public OppShootingStates m_sOppShootingState;

	public Vector3 targetLocalPos;

	public Vector3 correctPos;

	public bool hasShoot;

	public ArrowShootState arrowState;

	public bool onTaget;

	public int onTargetID;

	public List<int> hitTargetServeIDList;

	public List<Vector3> hitPointList;

	public List<Vector3> hitForwardList;

	public List<Vector3> hit_targets_top;

	public List<bool> hitCanThroughList;

	public List<Vector3> hitTargetCenterList;

	public List<Transform> AllHitObjects;

	public Vector3 camAimingDir;

	public Vector3 camStartPos;

	public float targetZ;

	public float LastWind;

	public float LastAngle;

	public bool has_wind;

	public float BowPower;

	public float RoundWindSpeed;

	public float RoundWindAngle;

	public float ShootTargetTime;

	public float ArrowFlyParamA;

	public float ArrowFlyParamB;

	public TargetCtrl camAimingTarget;

	public float camAimingTargetZ;

	public long transIdForPvp;

	public float OppShootTargetTime;

	public ArrowExtraParam arrowExtraParam;

	private PlayerBaseStates m_sCurBaseState;

	private MyShootOnlineStates m_sMyShootOnlineState;

	private MyShootNormalStates m_sMyShootNormalState;

	private OppShootStates m_sOppShootState;

	public PlayerEntity(ModelType modelType, PlayerType playerType, ScenePosType playerPosType, PlayerStandPart standPart, Player player, EquipIds equipId, State<PlayerEntity> initState)
		: base(ModelType.male, PlayerType.Myself, ScenePosType.Null, PlayerStandPart.Left, null, null)
	{
	}

	public override void MyUpdate()
	{
	}

	public override bool HandleMessage(Telegram msg)
	{
		return false;
	}

	public StateMachine<PlayerEntity> GetFSM()
	{
		return null;
	}

	public override void RecoverPreviousState()
	{
	}

	public PlayerBaseStates GetCurBaseState()
	{
		return PlayerBaseStates.Init;
	}

	public void SetCurBaseState(int sendID, PlayerBaseStates state)
	{
	}

	public MyShootOnlineStates GetMyShootOnlineState()
	{
		return MyShootOnlineStates.BeforeShoot;
	}

	public void SetMyShootOnlineState(MyShootOnlineStates state)
	{
	}

	public void DealMyShootOnlineReconnect()
	{
	}

	public MyShootNormalStates GetMyShootNormalState()
	{
		return MyShootNormalStates.BeforeShoot;
	}

	public void SetMyShootNormalState(MyShootNormalStates state)
	{
	}

	public bool CanFinisheMyShoot()
	{
		return false;
	}

	public OppShootStates GetOppShootState()
	{
		return OppShootStates.BeforeShoot;
	}

	public void SetOppShootState(OppShootStates state)
	{
	}

	public void DealOppShootReconnect()
	{
	}

	private AimingStage GetCurAimingStage(float curShootTime)
	{
		return AimingStage.Stage1;
	}

	public float GetMaxAimScreenInSpeed(float curShootTime)
	{
		return 0f;
	}

	public void PlayStandIdleAni(float speed = 0.2f, float crossTime = 0.2f)
	{
	}

	public void PlayStandIdleAniEnforce(float speed = 0.2f)
	{
	}

	public void PlayPullBowAni(float speed = 1f)
	{
	}

	public bool IsPullBowFinish(float time)
	{
		return false;
	}

	public void PlayPushBowAni()
	{
	}

	public bool IsPushBowFinish(float time)
	{
		return false;
	}
}
