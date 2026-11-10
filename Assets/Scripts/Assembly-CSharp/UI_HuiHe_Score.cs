using UnityEngine;

public class UI_HuiHe_Score : MonoBehaviour
{
	public GameObject objRoundScore;

	public GameObject objDisScore;

	public string curRound;

	public UILabel lRoundNum;

	public UILabel lLeftRoundScore;

	public UILabel lRightRoundScore;

	public UILabel lLeftDisScore;

	public UILabel lRightDisScore;

	public UI_AnimationCtrl LeftAnimationCtrl;

	public UI_AnimationCtrl RightAnimationCtrl;

	public UI_AnimationCtrl LeftDistAnimationCtrl;

	public UI_AnimationCtrl RightDistAnimationCtrl;

	public void UpdateScore(bool isNextRound, UpdatePlayerScore scoreType, PlayerStandPart myStandPart)
	{
	}

	private void UpdateRoundScore(bool isNextRound, UpdatePlayerScore scoreType, PlayerStandPart myStandPart)
	{
	}

	private void UpdateDisScore(bool isNextRound, UpdatePlayerScore scoreType, PlayerStandPart myStandPart)
	{
	}

	public Vector3 GetScorePos(bool isMySelf)
	{
		return default;
	}
}
