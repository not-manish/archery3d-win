using UnityEngine;

public class UI_Offline_ScoreCtrl : MonoBehaviour
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

	public GameObject objTime;

	public UI_Offline_TimeLeft uiTimeLeft;

	public UILabel lTargetDis;

	public Transform tTargetDis;

	public UISprite sRedDist;

	public UI_AnimationCtrl AnimStarBronze;

	public UI_AnimationCtrl AnimStarSilver;

	public UI_AnimationCtrl AnimStarGold;

	public ParticleSystem EffectStarBronze;

	public ParticleSystem EffectStarSilver;

	public ParticleSystem EffectStarGold;

	public UI_AnimationCtrl CurScoreAnim;

	private int PlayerArrows;

	private float scoreProgress;

	private float progressSpeed;

	private int levelID;

	private bool isShowPassStar;

	private bool isMiddlePassStar;

	private bool isShowFullStar;

	private float t;

	private float oldFillAmount;

	private bool isAddFillAmount;

	private int TargetScoreNum;

	public int GetlTargetScore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	public void Show(int _levelID)
	{
	}

	public void UpdateScore(int levelID)
	{
	}

	public void PlayAnimation(int value)
	{
	}

	public void AfterBuyObj_UpdateData(int levelID, int BuyObj, bool isReSetTime = false)
	{
	}

	public void SetTimeEnable(bool enable)
	{
	}

	public void UpdateDistance(string targetDis = "")
	{
	}

	public Vector3 GetScorePos()
	{
		return default;
	}
}
