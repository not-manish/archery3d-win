using UnityEngine;

public class UI_PanDian_Score : MonoBehaviour
{
	public UI_PanDian_Trophy uiTrophy;

	public GameObject objSetScore;

	public GameObject objDisScore;

	public UILabel lRoundNum;

	public UILabel lLeftRoundScore;

	public UILabel lRightRoundScore;

	public UILabel lLeftDisScore;

	public UILabel lRightDisScore;

	public UI_AnimationCtrl LeftAnimationCtrl;

	public UI_AnimationCtrl RightAnimationCtrl;

	public UI_AnimationCtrl LeftDistAnimationCtrl;

	public UI_AnimationCtrl RightDistAnimationCtrl;

	public void ShowStarEmpty()
	{
	}

	public void UpdateScore(bool isNextRound, PlayerStandPart myStandPart, UpdatePlayerScore scoreType, bool isShowStarAnim = false)
	{
	}

	private void UpdateSetScore(bool isNextRound, PlayerStandPart myStandPart, UpdatePlayerScore scoreType, bool isShowStarAnim = false)
	{
	}

	private void UpdateDisScore(bool isNextRound, PlayerStandPart myStandPart, UpdatePlayerScore scoreType)
	{
	}

	public Vector3 GetScorePos(bool isMySelf)
	{
		return default;
	}
}
