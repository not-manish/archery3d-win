using System.Net.Sockets;

namespace MMNet
{
	public class NetSocketMgr
	{
		private bool is_ssl;

		private NetSocketSSL TcpSSL;

		private NetSocketNoSSL TcpNoSSL;

		public bool Connected => false;

		public NetSocketMgr(BaseNetMgr baseNetMgr)
		{
		}

		public void Connect(bool _is_ssl, string serverDns, string serverIp, int port, ProtocolType type)
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
