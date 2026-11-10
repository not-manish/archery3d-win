using UnityEngine;

public class UI_MainMenu_ChestItem_Locked : MonoBehaviour
{
	public UIButton btBackground;

	public UISprite sChestIconBack;

	public UILabel lChestName1;

	public UILabel lChestName2;

	public UILabel lChestGradeNum;

	public UILabel lTapToUnLock;

	public UI_LittleTips uiLittleTips;

	public GameObject oChest;

	public UI_AnimationCtrl unMoveAnimationCtrl;

	public ParticleSystem pChestSystem1;

	public ParticleSystem pChestSystem2;

	public UI_AnimationCtrl unlockAnimationCtrl;

	public FlexibleTimeRegulator mWaitingTimeRegulator;

	public FlexibleTimeRegulator mChestSoundTimeRegulator;

	private int index;

	private ChestClassicSingle chestSingleData;

	private UI_MainMenu_ChestItem uiParent;

	private bool buttonEnable;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Show(UI_MainMenu_ChestItem _uiParent, int _index, object param, bool ShowMoveAnim, ChestListType chestListType)
	{
	}

	public void PlayMoveAnim(bool ShowMoveAnim, ChestListType chestListType)
	{
	}

	public void ShowItemTutorial()
	{
	}

	private bool IsTutorial(ChestClassicSingle chestSingle)
	{
		return false;
	}

	public void ShowMoveAnimFinish()
	{
	}

	public void ShowAnimFinish()
	{
	}

	private void UpdateState()
	{
	}

	private void UpdateState_Guide(int chestID)
	{
	}

	private void UpdateState_Classic(int chestID)
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
}
