using System.Collections.Generic;
using GameCtrlStates;
using com.simple.proto;

public class GameCtrlEntity : BaseEntity
{
	public enum CamMoveAniState
	{
		ToMiddleAim = 0,
		ToLeftLook = 1,
		ToLeftAim = 2,
		ToRightLook = 3,
		ToRightAim = 4
	}

	public enum PvpResState
	{
		NoAnswer = 0,
		AnswerOk = 1,
		AnswerError = 2
	}

	public GameCtrlEntityData m_dGCEdata;

	public GameCtrl gameCtrl;

	public FlexibleRealTimeRegulator m_tGameTimeRegulator;

	public FlexibleTimeRegulator m_tTimeRegulator;

	public FlexibleTimeRegulator m_tTimeRegulator2;

	public FlexibleTimeRegulator m_tTimeRegulatorScoreAnim;

	public FlexibleRealTimeRegulator m_tShootWaitRealtime;

	public float TargetUpdateTime;

	public FlexibleTimeRegulatorFirstTime m_tTimeForUpdateTarget;

	public Dictionary<long, CCPVPResponse> pvpResDic;

	public OnePlayStates m_sOnePlayerState;

	public TurnBaseStates m_sTurnBaseState;

	public ChongCiStates m_sChongCiState;

	public ChallengeStates m_sChallengeState;

	public GuideStates m_sGuideState;

	public GameCtrlEntity(GameCtrl _gameCtrl)
	{
	}

	public void MyUpdate()
	{
	}

	public override bool HandleMessage(Telegram msg)
	{
		return false;
	}

	public StateMachine<GameCtrlEntity> GetFSM()
	{
		return null;
	}

	public float GetTurnBasePvpTimeLeft()
	{
		return 0f;
	}

	public static float GetTimeLeft()
	{
		return 0f;
	}

	public CamMoveAni GetCamMoveAniParm(CamMoveAniState state, float moveTime)
	{
		return null;
	}

	public CamMoveAni GetCamMoveAniParm(bool IsMyTurn, float moveTime = 1.6f)
	{
		return null;
	}

	public void ShowGameMode()
	{
	}

	public void UiShowTurnHints(bool isMyTurn = true)
	{
	}

	public void UiUpdataTargetHit(bool isNextRound)
	{
	}

	public void UiShowForbidShoot()
	{
	}

	public void UiUpdateWind(bool isShowMyWind)
	{
	}

	public void UiUpdateScore(bool isNextRound, UpdatePlayerScore scoreType, bool isShowStarAnim = false)
	{
	}

	public void UiResetShootingTime(float duration, float timeLeft, OnlineNormalState PlayerState)
	{
	}

	public void ClearPvpResponse()
	{
	}

	public void AddPvpResponse(long TranscationId, CCPVPResponse ccres)
	{
	}

	public PvpResState GetPvpResponseState(long TranscationId)
	{
		return PvpResState.NoAnswer;
	}

	public bool GetPvpResponseHasShoot(long TranscationId)
	{
		return false;
	}

	public void UiShowCurScore(PlayerType playerType)
	{
	}

	public void UiShowTimeOut(float showTime)
	{
	}

	public UIGameOverParam GetUIGameOverParam(CCGameOverResponse goRes)
	{
		return null;
	}

	public void UiShowGameResult(GameResultType gameResult)
	{
	}

	public void UiShowGameOver(CCGameOverResponse goRes)
	{
	}

	public void UiCloseShootingTime(bool isClearProgress, OnlineNormalState PlayerState)
	{
	}

	public bool LastTurnIsMe()
	{
		return false;
	}

	public OnlineNormalState GetOnlineNormalState()
	{
		return OnlineNormalState.Null;
	}

	public bool ShouldShowGameMode()
	{
		return false;
	}

	public void setNotShootTarget(bool isMyself)
	{
	}
}
