using System;

public class ReSendRequestData
{
	public ReSendRequestType reSendRequestType;

	public float waitTime;

	public int ReSendCount;

	public Action action;

	public ReSendRequestData(ReSendRequestType _reSendRequestType, float _waitTime, int _reSendCount, Action _action)
	{
	}
}
