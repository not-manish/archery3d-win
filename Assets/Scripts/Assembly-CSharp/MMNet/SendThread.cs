using System.Net.Security;
using System.Net.Sockets;
using System.Threading;

namespace MMNet
{
	public class SendThread
	{
		private Thread m_Thread;

		private bool use_SSL;

		private SslStream sslStream;

		private NetworkStream m_NetWorkStream;

		private ConCurrentQueue<NetMessage> m_Messages;

		private bool m_Processing;

		public SendThread(ConCurrentQueue<NetMessage> messages, NetworkStream networkStream)
		{
		}

		public SendThread(ConCurrentQueue<NetMessage> messages, SslStream _sslStream)
		{
		}

		public void Start()
		{
		}

		public void OnProcess()
		{
		}

		public void Close()
		{
		}
	}
}
