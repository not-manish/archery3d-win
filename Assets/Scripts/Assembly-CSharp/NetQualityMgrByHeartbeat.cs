using com.simple.proto;

public class NetQualityMgrByHeartbeat
{
	private enum State
	{
		Init = 0,
		WaitingToSendHeartCheck = 1,
		WaitingReceiveResponse = 2
	}

	private NetMgr m_NetMgr;

	private NetQualityState m_NetQualityState;

	private State curState;

	private FlexibleTimeRegulator m_tRealtimeRegulator;

	private float MaxWaitingResponseTime;

	private float SendHeartCheckBetweenNormal;

	private float SendHeartCheckBetweenDelay;

	private const int MaxDelayTimes = 2;

	private int HaveDelayTimes;

	private long LastSendTimeMil;

	public NetQualityState M_NetQualityState => NetQualityState.NONE;

	public NetQualityMgrByHeartbeat(NetMgr netMgr)
	{
	}

	private void OnHeartbeatCheck()
	{
	}

	private void ClearHearbeatTime()
	{
	}

	public void Update()
	{
	}

	public void LoginSuccessInitNetQuality()
	{
	}

	public void IsLoginingStopHeartBeat()
	{
	}

	public void ReceiverHeartCheckResponse(CCHeartbeatResponse res)
	{
	}
}
