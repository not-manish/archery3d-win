using System;
using System.Net.Sockets;

namespace MMNet
{
	public class NetSocketNoSSL
	{
		private BaseNetMgr m_BaseNetMgr;

		private string m_Server;

		private int m_Port;

		private ProtocolType m_ProtocolType;

		private Socket m_Socket;

		private NetworkStream m_netWorkStream;

		private ConCurrentQueue<NetMessage> m_SendMessages;

		private ConCurrentQueue<NetMessage> m_ReceiveMessages;

		private SendThread m_SendThread;

		private ReceiveThread m_ReceiveThread;

		public bool Connected => false;

		public NetSocketNoSSL(BaseNetMgr baseNetMgr)
		{
		}

		public void Connect(string server, int port, ProtocolType type)
		{
		}

		private void _Connect()
		{
		}

		private void ConnectCallback(IAsyncResult ar)
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
