using MMNet;

public class RecMsgHandle_PlayScene : INetMessageCallback
{
	private NetMgr m_NetMgr;

	public bool Accept(int msgCode)
	{
		return false;
	}

	public void HandleMessage(NetMessage responseMsg)
	{
	}

	public void OnTimeOut(WaittingResponseMessage msg)
	{
	}

	public RecMsgHandle_PlayScene(NetMgr netMgr)
	{
	}
}
