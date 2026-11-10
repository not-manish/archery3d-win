using System.Collections.Generic;
using UnityEngine;

public class UI_ChallengeLevel_Join_CommonButton : MonoBehaviour
{
	public UI_ChallengeLevel_Join uiJoin;

	public GameObject oRookieSelect;

	public UIButton btRookieNotSelect;

	public GameObject oProSelect;

	public UIButton btProNotSelect;

	public GameObject oExpertSelect;

	public UIButton btExpertNotSelect;

	public GameObject oMasterSelect;

	public UIButton btMasterNotSelect;

	public List<GameObject> BtnGroup;

	public List<UIWidget> ShowBtnSprite;

	private int OneBtnWidth;

	public UISprite sBoard;

	private ChallengeGroup curGroup;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void UpdateState(ChallengeGroup group)
	{
	}
}
