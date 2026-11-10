using System.Collections.Generic;
using UnityEngine;

public class UI_Rank_League_Segment_Item : MonoBehaviour
{
	public UI_Segment uiSegment;

	public UILabel lName1;

	public UILabel lName2;

	public PlayerHeadShow sPlayerPhoto;

	public UILabel lAddPercent;

	private int segment_id;

	public GameObject StartEffect;

	public ParticleSystem[] AllStartPartic;

	public UI_AnimationCtrl StartAnim;

	public Transform HeadMoveTransform;

	public TweenPosition HeadMoveAnim;

	public UI_AnimationCtrl HeadShowAnim;

	public UIWidget[] AllChangeDepth;

	private List<int> AllOldDepth;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public void UpdateState(int ID, bool isMySegment)
	{
	}

	public void PlayAnim(RankLeaguePopupType type, float ChangeHeight)
	{
	}

	public void ShowNextPanel()
	{
	}

	private void Update()
	{
	}

	public void RestAnim()
	{
	}
}
