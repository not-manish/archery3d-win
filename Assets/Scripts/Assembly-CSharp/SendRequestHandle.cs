using UnityEngine;

public class SendRequestHandle : MonoBehaviour
{
	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public ReSendRequestData reSendRequestData;

	public ReSendRequestType reSendRequestType;

	private int resendCount;

	private SendReQuestHandleCtrl sendReQuestHandleCtrl;

	public void Show(SendReQuestHandleCtrl _sendReQuestHandleCtrl, object Param)
	{
	}

	public void SetTimeRegulator(bool isActive, float time)
	{
	}

	private void Update()
	{
	}

	public void ClearData()
	{
	}
}
