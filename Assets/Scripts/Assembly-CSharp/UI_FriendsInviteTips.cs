using UnityEngine;

public class UI_FriendsInviteTips : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UILabel lFriendsName;

	public UILabel lGameMode;

	public UILabel lGrade;

	public UILabel lEntryFee;

	public UIButton btStartNow;

	public UIButton btNotNow;

	private FlexibleTimeRegulatorFirstTime m_tUpdatePlayerHead;

	public Texture2D defaultTex;

	public PlayerHeadShow playerHeadShow;

	private bool hasSetScale;

	private UIFriendsInviteTipsParam uiParam;

	private bool buttonEnable;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Show(object param)
	{
	}

	private void UpdateState()
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

	public void ForceGiveUp()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void AskFriendsResponse()
	{
	}

	public bool MatchingResponse()
	{
		return false;
	}
}
