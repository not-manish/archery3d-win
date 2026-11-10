using UnityEngine;

public class UI_ChallengeLevel_Rank_GroupRule_Item : MonoBehaviour
{
	public PlayerHeadShow playerHeadShow;

	public UISprite sGroupLogo;

	public UILabel lGroupName1;

	public UILabel lGroupName2;

	public UILabel lGroupTips;

	private ChallengeGroup group;

	private bool isMyGroup;

	public void UpdateState(ChallengeGroup _group, bool _isMyGroup)
	{
	}
}
