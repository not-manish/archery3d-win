using MMNet;

public interface INetMessageCallback
{
	bool Accept(int msgCode);

	void HandleMessage(NetMessage responseMsg);

	void OnTimeOut(WaittingResponseMessage msg);
}
