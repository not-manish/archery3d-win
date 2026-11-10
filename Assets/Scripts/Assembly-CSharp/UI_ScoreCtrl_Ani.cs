using System.Collections.Generic;
using UnityEngine;

public class UI_ScoreCtrl_Ani : MonoBehaviour
{
	public UI_AnimationCtrl aniScoreInt;

	public List<TweenPosition> allScoreNormal;

	public List<UI_AnimationCtrl> aniScoreNormalChilds;

	public UI_AnimationCtrl aniScoreTenPerfect;

	public List<TweenPosition> allScoreTenPerfect;

	public List<UI_AnimationCtrl> aniScoreTenPerfectChilds;

	public UI_AnimationCtrl aniScorePoint;

	public UI_AnimationCtrl aniScoreMiss;

	public void PlayAni(UIScoreParam uiParam)
	{
	}

	private void RecoverAllAni()
	{
	}

	public void AnimationFinished()
	{
	}
}
