using System.Collections.Generic;
using UnityEngine;

public class SendReQuestHandleCtrl : MonoBehaviour
{
	public static List<long> ResponesIds;

	public Dictionary<ReSendRequestType, SendRequestHandle> AllReSendEvent;

	public SendRequestHandle NormalReSendItem;

	public List<SendRequestHandle> AllReSendItems;

	public static int ResponesID;

	private static SendReQuestHandleCtrl instance;

	public static SendReQuestHandleCtrl Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool SetResponesIds(long id)
	{
		return false;
	}

	private void Awake()
	{
	}

	public SendRequestHandle GetSendRequestHandle()
	{
		return null;
	}

	public void AddReSendRequestData(object Param)
	{
	}

	public void RemoveRequestItem(ReSendRequestType _reSendRequestType)
	{
	}
}
