using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class GamePlayingCtrl : MonoBehaviour
{
	public CamCtrl camCtrl;

	public ArrowCtrl arrowCtrl;

	public TargetBrokenCtrl targetBrokenCtrl;

	public PlayerCtrl playerCtrl;

	public TargetManage targetManage;

	public TargetNormalPoolCtrl targetNormalPoolCtrl;

	public AiEmojiCtrl aiEmojiCtrl;

	private static GamePlayingCtrl instance;

	public Dictionary<long, CCPVPResponse> pvpResponsses;

	public Dictionary<long, ArrowFly> waitingServeArrow;

	public static GamePlayingCtrl Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void HandlePvpResponse(long transactionId, CCPVPResponse ccPvpResponse)
	{
	}

	public void HandleArrowGenerated(long transactionId, ArrowFly arrowFly)
	{
	}

	public void HandlePvpAimResponse(CCPvpAimOperateResponse pvpAimResponse)
	{
	}

	public void UpdatePlayerInfo()
	{
	}

	public void SetAllTargetsPos(float targetTime)
	{
	}

	public bool CanShowAiEmoji()
	{
		return false;
	}
}
