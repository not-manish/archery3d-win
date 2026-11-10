using UnityEngine;

public class UI_GO_Common_Player : MonoBehaviour
{
	public static bool isLastGameWin;

	public PlayerHeadShow sLeftPhoto;

	public UILabel lLeftName;

	public UILabel lLeftTrophy;

	public GameObject objLeftWinTitle;

	public UISprite sLeftTrophy;

	public UISprite sLeftWinner;

	public ParticleSystem pLeftWinner;

	public UI_AnimationCtrl LeftWinAnim;

	public UI_AnimationCtrl LeftTrophyWinAnim;

	public PlayerHeadShow sRightPhoto;

	public UILabel lRightName;

	public UILabel lRightTrophy;

	public GameObject objRightWinTitle;

	public UISprite sRightTrophy;

	public UISprite sRightWinner;

	public ParticleSystem pRightWinner;

	public UI_AnimationCtrl RightWinAnim;

	public UI_AnimationCtrl RightTrophyWinAnim;

	public GameObject oMyWords;

	public UILabel lMyWords;

	public GameObject oOppWords;

	public UILabel lOppWords;

	public UI_AnimationCtrl uiAnimationCtrl;

	public ParticleSystem MyParticleSystem;

	public ParticleSystem otherParticleSystem;

	public UILabel lMyAddTrophy;

	public UILabel lMyTrophyFull;

	public UILabel lOtherAddTrophy;

	public UILabel lOtherTrophyFull;

	public UI_AnimationCtrl TrophyShow;

	public UI_AnimationCtrl TrophyHide;

	public GameObject Trophy;

	public UISprite sLogo;

	public GameObject oClassic;

	public GameObject oArena;

	public GameObject oBingo;

	public GameObject oRush;

	public GameObject oClassicMode;

	public GameObject oClassic_PanDian;

	public GameObject oClassic_HuiHe;

	public GameObject oRushMode;

	public GameObject oBingoMode;

	public GameObject oArenaMode;

	public GameObject oArena_PanDian;

	public GameObject oArena_HuiHe;

	public GameObject oArena_Rush;

	private UIGameOverParam _uiGameOverParam;

	private UIGOPlayerParam uiParam;

	public CommonPlayerState commonPlayerState;

	private FlexibleTimeRegulator m_tTimeRegulator;

	private bool isMy;

	private bool isOpp;

	private bool isWin;

	private float t;

	public void Show(UIGameOverParam uiGameOverParam, object _uiParam)
	{
	}

	public void ShowWinAniming()
	{
	}

	public void ShowWinAnimEffect()
	{
	}

	public void WinAnimPlay()
	{
	}

	public void ChangeCommonPlayerState(CommonPlayerState _commonPlayerState)
	{
	}

	private void Update()
	{
	}

	public void Showhead()
	{
	}

	public void ShowTyophy()
	{
	}

	public void ShowFull(PlayerType playerType)
	{
	}

	public void ShowTrophyFalse()
	{
	}

	public void ShowAddTrophy(bool _isWin)
	{
	}

	public void PlayerAdd(bool _isMy, bool _isOpp, bool _isWin)
	{
	}

	public void PlayTrophyLoseShow()
	{
	}

	public void PlayTrophyWinShow()
	{
	}

	public void PlayTrophyLoseHide()
	{
	}

	public void PlayTrophyLoseWait()
	{
	}

	public void PlayTrophyWinHide()
	{
	}

	public void HideTrophy()
	{
	}

	public void Hide(object param)
	{
	}

	public void ShowWords(bool isMy, RematchWords wordIndex)
	{
	}

	public void HideWords(bool isMy)
	{
	}

	private void RecoverAllAni()
	{
	}

	private void UpdateState(GameType gameType, PvpType pvpType, int levelID)
	{
	}
}
