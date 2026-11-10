namespace MMNet
{
	public class NetMessage
	{
		public long transactionId;

		public int msgCode;

		public byte[] content;

		public NetMessage()
		{
		}

		public NetMessage(int msgCode, byte[] content)
		{
		}

		public NetMessage(long transactionId, int msgCode, byte[] content)
		{
		}

		public virtual byte[] Pack()
		{
			return null;
		}

		public virtual byte[] PackWithLength()
		{
			return null;
		}
	}
}
