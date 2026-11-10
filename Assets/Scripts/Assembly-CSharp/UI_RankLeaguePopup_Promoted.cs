using System.Collections.Generic;
using UnityEngine;

public class UI_RankLeaguePopup_Promoted : MonoBehaviour
{
	public UIButton btContinue;

	public UI_Segment uiSegment;

	public UISprite sSegmentLogo;

	public UILabel lSegmentName1;

	public UILabel lSegmentName2;

	public PlayerHeadShow sPlayerPhoto;

	public UILabel lPlayerTrophyNum;

	public GameObject StartEffect;

	public ParticleSystem[] StartCirclePartic;

	public ParticleSystem[] AllStartPartic;

	public UI_AnimationCtrl StartAnim;

	public List<ParticleSystem> StartParticNotHide;

	public GameObject EndEffect;

	public ParticleSystem[] AllEndPartic;

	public UI_AnimationCtrl EndAnim;

	public UIWidget[] AllChangeDepth;

	private List<int> AllOldDepth;

	private UI_RankLeaguePopup uiRankPopup;

	public FlexibleRealTimeRegulator m_tTimeChangeLogoRegulator;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public FlexibleRealTimeRegulator PlaySoundRegulator;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_RankLeaguePopup _uiRankPopup, object param)
	{
	}

	private void UpdateState()
	{
	}

	public void Hide(object param)
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void ShowNextPanel()
	{
	}

	private void Update()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void RestAnim()
	{
	}
}
