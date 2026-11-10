using UnityEngine;

public class UI_ChongCi_Score : MonoBehaviour
{
	public UILabel lLeftSumScores;

	public UILabel lRightSumScores;

	public UI_AnimationCtrl LeftSumScoresAnim;

	public UI_AnimationCtrl RightSumScoresAnim;

	public void UpdateScore(PlayerStandPart myStandPart, bool isNextRound, UpdatePlayerScore scoreType)
	{
	}

	public Vector3 GetScorePos(bool isMySelf)
	{
		return default;
	}
}
