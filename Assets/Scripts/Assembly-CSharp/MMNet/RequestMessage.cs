namespace MMNet
{
	public class RequestMessage : NetMessage
	{
		public long transactionTime;

		public int timeOut;

		private static long msgTrancId;

		private byte[] bytes;

		private int transTimeStartIdxInPack;

		private bool packWithLength;

		private bool pack;

		public bool IsHandleTimeOut => false;

		public RequestMessage(int msgCode, byte[] content, int timeOut, long transactionId)
		{
		}

		public static long GenMsgTransactionId()
		{
			return 0L;
		}

		private void Init(long _transactionId)
		{
		}

		public override byte[] Pack()
		{
			return null;
		}

		public override byte[] PackWithLength()
		{
			return null;
		}

		public void UpdateTransTime()
		{
		}

		public virtual void OnDestroy()
		{
		}

		protected byte[] Combine(params byte[][] arrays)
		{
			return null;
		}
	}
}
