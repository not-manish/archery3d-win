using UnityEngine;

public class UI_ScoreCtrl : MonoBehaviour
{
	public UI_ScoreCtrl_Ani uiAniCtrl;

	public GameObject oScoreNormal;

	public GameObject objectTenPerfect;

	public GameObject objectScoreMiss;

	public GameObject oScorePoint;

	public GameObject objectScoreX;

	public UISprite sXDigit;

	public UISprite sXDigitAnim;

	public GameObject objectScoreXX;

	public UISprite sXXTensDigit;

	public UISprite sXXDigit;

	public UISprite sXXTensDigitAnim;

	public UISprite sXXDigitAnim;

	public GameObject objectScoreXXX;

	public UISprite sXXXHundredDigit;

	public UISprite sXXXTensDigit;

	public UISprite sXXXDigit;

	public UISprite sXXXHundredDigitAnim;

	public UISprite sXXXTensDigitAnim;

	public UISprite sXXXDigitAnim;

	public UILabel lPointScore;

	public UILabel lTenText;

	public UILabel lTenTextBg;

	public ParticleSystem EffectTen;

	public Transform tTenPerfect;

	public Transform tOneNum;

	public Transform tTwoNum;

	public Transform tThreeNum;

	private UIScoreParam uiParam;

	public void ShowScore(object param)
	{
	}

	private void UpdateState()
	{
	}

	public void Hide()
	{
	}

	private void SetScore(int Score)
	{
	}

	public int GetTenNum(PlayerType playerType)
	{
		return 0;
	}

	public int GetMaxEqualTenNum(PlayerType playerType)
	{
		return 0;
	}

	public void PlayScoreSound(int score, int tenNum = -1)
	{
	}
}
