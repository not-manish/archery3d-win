using System;
using System.Net;
using System.Net.Sockets;

public class NetConnectMgr
{
	public NetMgr m_NetMgr;

	private static ConnectState connectState;

	public static string[] HOSTIPS;

	private static string[] NormalServerIps;

	private static string NormalDns;

	private IPHostEntry m_HostEntry;

	private const int PORT = 5678;

	private const int PORT_SSL = 8443;

	private const ProtocolType TYPE = ProtocolType.Tcp;

	private static NetMgr _instance;

	private FlexibleTimeRegulator m_TimeRegulator;

	public NetConnectMgr(NetMgr _NetMgr)
	{
	}

	public static ConnectState GetConnectState()
	{
		return ConnectState.SUCCESS;
	}

	public void SetConnectState(ConnectState state)
	{
	}

	public void Update()
	{
	}

	public void Connect()
	{
	}

	private void StartConnectByHostEntry()
	{
	}

	public void DoGetHostEntryAsync(string hostname)
	{
	}

	public void GetHostEntryCallback(IAsyncResult ar)
	{
	}

	public void ConnectSuccess()
	{
	}

	public void ConnectFailed()
	{
	}

	public bool IsConnected()
	{
		return false;
	}
}
