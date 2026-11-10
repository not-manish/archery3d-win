using UnityEngine;

public class UI_Guide_ScoreCtrl : MonoBehaviour
{
	public Transform transStartPoints;

	public Transform transEndPoints;

	public Transform objStarBronze;

	public Transform objStarGold;

	public UILabel lTargetScore;

	public UILabel lCurScore;

	public UISprite sScoreProgress;

	public UI_AnimationCtrl AnimStarBronze;

	public UI_AnimationCtrl AnimStarGold;

	public ParticleSystem EffectStarBronze;

	public ParticleSystem EffectStarGold;

	private int levelID;

	private bool isShowPassStar;

	private bool isShowFullStar;

	private float t;

	private float oldFillAmount;

	public Transform tScorePos;

	private int PlayerArrows;

	private float scoreProgress;

	private float progressSpeed;

	public UI_AnimationCtrl CurScoreAnim;

	private bool isAddFillAmount;

	private void Update()
	{
	}

	public void Show()
	{
	}

	public void UpdateScore()
	{
	}

	public void PlayAnimation(int value)
	{
	}

	public bool Showing()
	{
		return false;
	}

	public Vector3 GetScorePos()
	{
		return default;
	}
}
