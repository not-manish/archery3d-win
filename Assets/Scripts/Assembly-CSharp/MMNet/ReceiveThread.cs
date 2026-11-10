using System.Net.Security;
using System.Net.Sockets;
using System.Threading;

namespace MMNet
{
	public class ReceiveThread
	{
		private Thread m_Thread;

		private bool use_SSL;

		private SslStream sslStream;

		private NetworkStream m_NetWorkStream;

		private ConCurrentQueue<NetMessage> m_Messages;

		private bool m_Processing;

		private byte[] lengthBytes;

		private byte[] transcationIdBytes;

		private byte[] msgCodeBytes;

		private byte[] contentBytes;

		public ReceiveThread(ConCurrentQueue<NetMessage> messages, NetworkStream networkStream)
		{
		}

		public ReceiveThread(ConCurrentQueue<NetMessage> messages, SslStream _sslStream)
		{
		}

		public void Start()
		{
		}

		private void OnProcess()
		{
		}

		public void Close()
		{
		}
	}
}
