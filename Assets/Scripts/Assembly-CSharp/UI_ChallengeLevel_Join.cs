using UnityEngine;

public class UI_ChallengeLevel_Join : MonoBehaviour
{
	public UI_ChallengeLevel_Join_List uiList;

	public UI_ChallengeLevel_Join_CommonButton uiCommonButton;

	public UIButton btSelect;

	public UIButton btLocked;

	public UILabel lEntryFee;

	public UILabel lUnlockedSegment;

	public GameObject GameNotOpen;

	public UILabel lOpenTime;

	public UIButton btnShowLastWeekRank;

	public GameObject oOpenTime;

	public FlexibleRealTimeRegulator m_tRegulator;

	private UnLockGameModeLevel unLockGameModeLevel;

	public UI_AnimationCtrl AnimInfoTips;

	public UI_AnimationCtrl uiRuleShowAnim;

	public UIPanel pRule;

	public UIButton btnInfo;

	public UIButton btnCloseRules;

	public UIButton btBack;

	private UI_ChallengeLevel uiChallengeLevel;

	private bool hasSetScale;

	private ChallengeGroup showGroup;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_ChallengeLevel _uiChallengeLevel, object param)
	{
	}

	public void SetChallengeGroup(ChallengeGroup group)
	{
	}

	public void ChangeBtn(ChallengeGroup group)
	{
	}

	public void Hide(object param)
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void KeyEscapeClicked()
	{
	}

	public void ChallengeGroupClicked(ChallengeGroup group)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void ChallengeJoinResponse()
	{
	}

	public bool IsChallengeOpening()
	{
		return false;
	}

	private void Update()
	{
	}

	private void SetChallengeTime(bool isOpening, long LeftTimeMil)
	{
	}
}
