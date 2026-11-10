public class MessageDispatcher
{
	private static MessageDispatcher instance;

	public const float SEND_MSG_IMMEDIATELY = 0f;

	public const int NO_ADDITIONAL_INFO = 0;

	public const int SENDER_ID_IRRELEVANT = -1;

	public static MessageDispatcher Instance => null;

	private MessageDispatcher()
	{
	}

	private void Discharge(BaseEntity pReceiver, Telegram telegram)
	{
	}

	public void DispatchMsg(int sender, int receiver, FSMMessageType msg)
	{
	}

	public void DispatchMsg(int sender, int receiver, FSMMessageType msg, object AdditionalInfo)
	{
	}

	public void DispatchMsg(MessageSendTarget messageTarget, int sender, FSMMessageType msg, object AdditionalInfo)
	{
	}

	public void DispatchDelayedMessages()
	{
	}
}
