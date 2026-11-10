using UnityEngine;

public class UI_Challenge_ScoreCtrl : MonoBehaviour
{
	public Transform transStartPoints;

	public Transform transEndPoints;

	public Transform objStarBronze;

	public Transform objStarSilver;

	public Transform objStarGold;

	public UILabel lTargetScore;

	public UILabel lCurScore;

	public UILabel lGoldScore;

	public Transform tScorePos;

	public UISprite sScoreProgress;

	public GameObject objRound;

	public UILabel lRound;

	public Transform tTargetDis;

	public UILabel lTargetDis;

	public UISprite sRedDist;

	public UI_AnimationCtrl AnimStarBronze;

	public UI_AnimationCtrl AnimStarSilver;

	public UI_AnimationCtrl AnimStarGold;

	public ParticleSystem EffectStarBronze;

	public ParticleSystem EffectStarSilver;

	public ParticleSystem EffectStarGold;

	public UI_AnimationCtrl animCurScore;

	private float scoreProgress;

	private float progressSpeed;

	private int levelID;

	private bool isShowPassStar;

	private bool isShowSilverStar;

	private bool isShowFullStar;

	private float t;

	private float oldFillAmount;

	private bool isAddFillAmount;

	private void Update()
	{
	}

	public void Show(int levelID)
	{
	}

	public void UpdateScore(int _levelID, bool isNextRound, bool isShowAnim = false)
	{
	}

	public void ShowCurscore()
	{
	}

	public void PlayAnimation(int value)
	{
	}

	public void UpdateDistance(string targetDis = "")
	{
	}

	public void SetTimeEnable(bool enable)
	{
	}

	public Vector3 GetScorePos()
	{
		return default;
	}
}
