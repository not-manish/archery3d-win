using UnityEngine;

public class UI_Offline_GameOver : MonoBehaviour
{
	public UITexture BG;

	public UILabel lGetScore;

	public UIButton btBack;

	public UIButton btRetry;

	public UIButton btNext;

	public UIButton btRplay;

	public ParticleSystem[] AnimaParticleSystem;

	public UI_AnimationCtrl[] uiAnimationCtrl;

	public UI_AnimationCtrl uiAnimationFailure;

	public UI_AnimationCtrl uiAnimationSuccess;

	public UI_AnimationCtrl uiAnimationCollect;

	public UI_AnimationCtrl uiAnimationBtn;

	public ParticleSystem WinParticile;

	public GameObject Success;

	public GameObject Failed;

	public FlexibleRealTimeRegulator m_tTimeRegulatorWaitRespones;

	public UI_Offline_GameOverRewards Offline_GetRewards;

	public UISprite[] sStart;

	public UILabel[] lScores;

	public int levelID;

	private LevelSingleHeartRealtimeData heartStoreDataLoader;

	private bool BackRewardRespones;

	private int startNum;

	private int moveindex;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show()
	{
	}

	private void UpdateState()
	{
	}

	public void SetLevelMaterial(LevelPassStart levelPassStart)
	{
	}

	public void AnimationendListener()
	{
	}

	public void AnimationInListener()
	{
	}

	public void ShowFailed()
	{
	}

	public void ShowSuccess()
	{
	}

	public void ShowNext(bool isShow = true)
	{
	}

	public void PlayEffect()
	{
	}

	public void Hide()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void KeyEscapeClicked()
	{
	}

	private void Update()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void WaitingToCloseWindow()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void GetRewardResond()
	{
	}

	public void UpdatePlayerInfo()
	{
	}
}
