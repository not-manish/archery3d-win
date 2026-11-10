using System.Collections.Generic;
using System.Net.Sockets;

namespace MMNet
{
	public class BaseNetMgr
	{
		public NetSocketMgr m_NetSocketMgr;

		protected List<INetMessageCallback> m_MsgCallbacks;

		protected INetMessageCallback m_MsgCallback;

		public void Connect(bool _is_ssl, string serverDns, string serverIp, int port, ProtocolType type)
		{
		}

		public virtual void Close()
		{
		}

		public virtual void ConnectSuccess()
		{
		}

		public virtual void ConnectFailed()
		{
		}

		public virtual void Update()
		{
		}

		public void Dispose()
		{
		}

		private void HandleMessage()
		{
		}

		public INetMessageCallback RegisterMsgCallBack(INetMessageCallback callback)
		{
			return null;
		}

		public void UnRegisterMsgCallBack(INetMessageCallback callback)
		{
		}

		public INetMessageCallback SetMsgCallback(INetMessageCallback callback)
		{
			return null;
		}
	}
}
