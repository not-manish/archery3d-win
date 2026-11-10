using System.Collections.Generic;
using UnityEngine;

public class UI_ChallengeLevel_Rank_Prize_TopButton : MonoBehaviour
{
	public UIButton btAmateur;

	public UIButton btProfessional;

	public UIButton btExpert;

	public UIButton btMaster;

	public UIChangeWidgeColor wiAmateur;

	public UIChangeWidgeColor wiProfessional;

	public UIChangeWidgeColor wiExpert;

	public UIChangeWidgeColor wiMaster;

	private UI_ChallengeLevel_Rank_Prize uiPrize;

	public List<GameObject> BtnGroup;

	public UISprite sBoard;

	private int index;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_ChallengeLevel_Rank_Prize _uiPrize, ChallengeGroup _challengeGroupState)
	{
	}

	public void SetButtonState(ChallengeGroup _challengeGroupState)
	{
	}

	public void Hide(bool enforce)
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

	public void UpdateState()
	{
	}
}
