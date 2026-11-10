namespace MMNet
{
	public class WaittingResponseMessage
	{
		public INetMessageCallback callBack;

		public const int DEFAULT_NET_COST = 5000;

		public WaittingResponseMessageMgr mgr;

		public NetSocketMgr netSocketMgr;

		public RequestMessage message;

		private float lastSendRealTime;

		private float timeOut;

		private bool managed;

		public float sendTime;

		public long TranscationId => 0L;

		public bool Managed => false;

		public WaittingResponseMessage(INetMessageCallback callBack, WaittingResponseMessageMgr mgr, NetSocketMgr netSocketMgr, RequestMessage message)
		{
		}

		public void Update()
		{
		}

		private void OnTimeOut()
		{
		}

		public void OnManaged()
		{
		}

		public void OnCancelManaged()
		{
		}

		public void Send()
		{
		}

		public void ReSend()
		{
		}
	}
}
