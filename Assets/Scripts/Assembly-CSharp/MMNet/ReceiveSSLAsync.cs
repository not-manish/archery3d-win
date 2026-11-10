using System;
using System.Net.Security;

namespace MMNet
{
	public class ReceiveSSLAsync
	{
		public enum ReadState
		{
			Length = 0,
			TranscationId = 1,
			MsgCode = 2,
			Content = 3
		}

		private SslStream sslStream;

		private ConCurrentQueue<NetMessage> m_Messages;

		private bool m_Processing;

		private ReadState curReadState;

		private byte[] lengthBytes;

		private byte[] transcationIdBytes;

		private byte[] msgCodeBytes;

		private byte[] contentBytes;

		private int contentLength;

		private long transactionId;

		private int msgCode;

		public ReceiveSSLAsync(ConCurrentQueue<NetMessage> messages, SslStream _sslStream)
		{
		}

		public void ReceiveAsync(ReadState readState)
		{
		}

		private void ReceiveCallback(IAsyncResult ar)
		{
		}

		public void Close()
		{
		}
	}
}
