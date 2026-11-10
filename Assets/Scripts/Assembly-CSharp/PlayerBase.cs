public class PlayerBase : BaseEntity
{
	public Player m_Player;

	public ModelType modelType;

	public PlayerType playerType;

	public ScenePosType playerPosType;

	public PlayerStandPart standPart;

	public EquipIds equipIds;

	public EquipProperties equipProperties;

	public StateMachine<PlayerBase> m_dSubMathchine;

	public FlexibleTimeRegulator m_tTimeRegulator;

	public FlexibleTimeRegulator m_tTimeRegulator_StartCamFol;

	public FlexibleTimeRegulator m_tTimeRegulator_AimStart;

	public FlexibleRealTimeRegulator m_tRealtimeRegulator;

	public PlayerBase(ModelType _modelType, PlayerType _playerType, ScenePosType _playerPosType, PlayerStandPart _standPart, Player _player, EquipIds _equipIds)
	{
	}

	public StateMachine<PlayerBase> GetSubFSM()
	{
		return null;
	}

	public virtual void MyUpdate()
	{
	}

	public virtual void RecoverPreviousState()
	{
	}

	public void UpdateEquipID(EquipType equipType, int ID)
	{
	}

	public void UpdateEquipIDs(EquipIds _equipIds)
	{
	}

	public void UpdateEquipProperties()
	{
	}

	public float GetEquipAimingTime()
	{
		return 0f;
	}

	public float GetEquipAimingAniSpeed(float PlayTime)
	{
		return 0f;
	}

	public float GetEquipCamMoveSpeed()
	{
		return 0f;
	}

	public CamTargetParam GetCamTargetParam(float moveTime)
	{
		return null;
	}

	public UIAimCircleCtrlParam GetAimCircleParam()
	{
		return null;
	}
}
