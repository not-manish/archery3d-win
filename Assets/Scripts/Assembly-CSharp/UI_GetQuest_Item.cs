using UnityEngine;

public class UI_GetQuest_Item : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimCtrl;

	public UILabel lAchievementName;

	public UILabel lAchievementNameBg;

	public UILabel lAchievemenValue;

	public UISprite sGetTipsBg;

	public UISprite sQuestProgess;

	public ParticleSystem pEffect;

	public UI_AnimationCtrl uiIconAnimCtrl;

	private QuestItemData questItem;

	private GetAchievementItemData getAchievementItemData;

	private FlexibleTimeRegulator m_tTimeRegulator;

	private bool isShowAddAnim;

	private float t;

	public void Show(object param)
	{
	}

	public void UpdateState()
	{
	}

	private void Update()
	{
	}

	public void PlayerValueUpgrade(QuestItemData questItem, float time)
	{
	}

	public void PlayHeadAnim()
	{
	}

	public void resetAnim()
	{
	}

	public void PlaybackAnim()
	{
	}

	public void Hide()
	{
	}
}
