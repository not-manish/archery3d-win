using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class Player : MonoBehaviour
{
	public enum AimingState
	{
		in_middle = 0,
		Left_top_out = 1,
		Left_top_out_big_edge = 2,
		right_down_out = 3,
		right_down_out_big_edge = 4
	}

	[HideInInspector]
	public PlayerMount playerMount;

	[HideInInspector]
	public GameObject modelArrowObject;

	private int ArrowModelIndex;

	[HideInInspector]
	public ArrowFly modelArrowFly;

	[HideInInspector]
	public GameObject BowObject;

	[HideInInspector]
	public GameObject BowAimCenter;

	[HideInInspector]
	public PlayerEntity playerEntity;

	[HideInInspector]
	public AnimationCtrl animationCtrl;

	private GameObject DefaultBow;

	private GameObject DefaultSight;

	private GameObject DefaultStabilizer;

	private GameObject DefaultArm;

	private GameObject DefaultArrow;

	public PlayerData playerdata;

	private Vector3 BowLocalPos;

	private Vector3 BowLocalRot;

	private Vector3 BowAimLocalRot;

	private Vector3 ArrowLocalPos;

	private Vector3 ArrowLocalRot;

	private PlayerType currentPlayerType;

	private Vector3 touchInitPos;

	private float MaxPixelRadius;

	private float curSpeedRatio;

	private Vector3 curVelocity;

	private const float curSpeedSpeed = 0.5f;

	private float RecoverSpeed;

	private AimingState horState;

	private AimingState verState;

	private float horOut;

	private float verOut;

	private float AngleRadio;

	private float AddAcc;

	private float SubAcc;

	private bool isAdd;

	private Vector3 initLocalEuler;

	private Quaternion initLocalRot;

	private float targetSpeed;

	private float curSpeed;

	private bool turnLeft;

	private Vector2 VelocityDir;

	private Vector2 curOffset;

	private Quaternion OppStartRot;

	private Quaternion OppTargetRot;

	private float OppCurT;

	private float OppSpeedT;

	private const float OppSpeedDecT = 5f;

	private float MaxZdis;

	private float AddZdis;

	[HideInInspector]
	public ArrowFly curFlyingArrow;

	private void Awake()
	{
	}

	public void Init(PlayerType playerType, ScenePosType playerPosType, PlayerStandPart standPart, EquipIds equipIds, PlayerData _playerdata = null)
	{
	}

	public void InitAnimation(ModelType modelType)
	{
	}

	public static void InitBones(Transform _root, PlayerMount playerMount)
	{
	}

	public static void InitBowLines(Transform _root, PlayerMount playerMount)
	{
	}

	public void SetObjectLayer(GameObject objParent, int Layer)
	{
	}

	private void LoadModel(EquipIds equipIds, PlayerType playerType)
	{
	}

	public void LoadArm(int arm_index)
	{
	}

	public void LoadBow(int bow_index, int type_id)
	{
	}

	public void SetBowLineActive(int model_index, Material material = null)
	{
	}

	public void LoadArrow(int model_index)
	{
	}

	public void LoadSight(int sight_model_index, int bow_model_index)
	{
	}

	public void LoadStabilizer(int model_index)
	{
	}

	public void UpdatePlayerArrowTexture()
	{
	}

	private Vector3 GetInitPos()
	{
		return default;
	}

	private Quaternion GetInitRot()
	{
		return default;
	}

	public void InitPos(ScenePosType playerPosType, int BowId)
	{
	}

	public void SetModelActive(bool Active)
	{
	}

	private void Update()
	{
	}

	public void SetPosition(Vector3 pos)
	{
	}

	public void SetLocalPosition(Vector3 localPos)
	{
	}

	public void SetRotation(Quaternion rot)
	{
	}

	public void SetEuler(Vector3 euler)
	{
	}

	public Quaternion GetRotation()
	{
		return default;
	}

	public Vector3 GetEulerAngle()
	{
		return default;
	}

	public void SetRotation(Vector3 euler)
	{
	}

	public void SetLocalRotation(Quaternion rot)
	{
	}

	public void SetLocalRotation(Vector3 euler)
	{
	}

	public void RecordTouchStartPosition(Vector2 screenPos)
	{
	}

	public void PullingBowRecover()
	{
	}

	public void ResetAimingState()
	{
	}

	public void UpdateArrowAimDirection(Vector3 touchNowPos, float curShootTime)
	{
	}

	public void InitPlayerPosBeforeAimPos()
	{
	}

	public void InitRandomParam()
	{
	}

	private void RangeVelocity()
	{
	}

	private Vector3 GetAITargetCenterPos()
	{
		return default;
	}

	public void AimingMoveAI(float deltaTime)
	{
	}

	public void AimingMoveOpp(float deltaTime)
	{
	}

	public void AimingMove(float deltaTime, bool canMove)
	{
	}

	private Vector3 GetAiBestShootPos(List<Vector3> shootPoss, int score)
	{
		return default;
	}

	public Vector3 GetAiShootPosition_normal(int score)
	{
		return default;
	}

	public Vector3 GetAiShootPosition_Bingo(int score)
	{
		return default;
	}

	public Vector3 GetAiShootPosition(int score)
	{
		return default;
	}

	public Vector3 GetAiDirection(Vector3 targetPoint)
	{
		return default;
	}

	public void GenerateAiShootParam()
	{
	}

	public static bool GetRaycast(out RaycastHit hit, Vector3 position, Vector3 dir, float range)
	{
		hit = default;
		return false;
	}

	public static bool GetRaycast(out RaycastHit hit, Vector3 position, Vector3 dir, float range, LayerMask layer)
	{
		hit = default;
		return false;
	}

	public void CalculateStartPosAndDir()
	{
	}

	public void CalculateCameraAimTarget(bool isMyself)
	{
	}

	public void GetAllHitTargetsByPhysics(bool isMyself)
	{
	}

	public bool AddHitTargetsAndIfFinished(bool isMyself, List<RaycastHit> AllHits, bool ShouldCheckHitPoint)
	{
		return false;
	}

	public void InitBowArrow()
	{
	}

	public void EnableArrowModel(bool active)
	{
	}

	public ArrowExtraParam GetArrowFlyParamFromNative()
	{
		return null;
	}

	public ArrowExtraParam GetArrowFlyParamFromServe(CCPVPResponse ccResponse)
	{
		return null;
	}

	public void ArrowReadyFly(ArrowExtraParam arrowFlyParam)
	{
	}

	public void SetArrowFlyHitObject()
	{
	}

	public CamFollowArrowParam GetCamTargetParam(ArrowExtraParam arrowFlyParam, float FlyTime, float MaxZ)
	{
		return null;
	}

	public bool IsAimingBar()
	{
		return false;
	}

	public bool IsAiAiming()
	{
		return false;
	}

	public void HandlePvpAimResponse(CCPvpAimOperateResponse pvpAimResponse)
	{
	}

	public void UpdateMyEquipments(EquipIds equipIds)
	{
	}

	public void CheckPvpChangeArrow(int ArrowId)
	{
	}

	public void CheckSendPlayerAimAngle()
	{
	}

	public GameObject GetBowAnimCenter()
	{
		return null;
	}

	public GameObject GetArrowObject()
	{
		return null;
	}

	public void ClearDefaultEquip(EquipType equipType)
	{
	}

	public void DownloadArrow(int model_index)
	{
	}

	public void UpdateArrowModel()
	{
	}
}
