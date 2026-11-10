using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace MMNet
{
	public class NetSocketSSL
	{
		private BaseNetMgr m_BaseNetMgr;

		private string m_ServerDns;

		private string m_ServerIp;

		private int m_Port;

		private ProtocolType m_ProtocolType;

		private TcpClient client;

		private SslStream sslStream;

		private ConCurrentQueue<NetMessage> m_SendMessages;

		private ConCurrentQueue<NetMessage> m_ReceiveMessages;

		private SendThread m_SendThread;

		private ReceiveSSLAsync m_ReceiveSSLAsync;

		public bool Connected => false;

		public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return false;
		}

		public NetSocketSSL(BaseNetMgr baseNetMgr)
		{
		}

		public void Connect(string ServerDns, string ServerIp, int port, ProtocolType type)
		{
		}

		private void _Connect()
		{
		}

		public void Close()
		{
		}

		public void Dispose()
		{
		}

		public void Send(NetMessage message)
		{
		}

		public NetMessage OnMessage()
		{
			return null;
		}
	}
}
