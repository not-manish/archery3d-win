using UnityEngine;

public class UI_OfflineLevel_IsEnterLevel : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btBack;

	public UILabel lLevelNum;

	public UILabel lLevelbg;

	public UILabel lTitle;

	public UILabel lTitleNum;

	public UISprite[] sStart;

	public UILabel lPayHeartNum;

	public UIButton btEnterLevel;

	private int levelID;

	public UISprite sS_Board;

	private int maxHeight;

	private int minHeight;

	public GameObject objPrize;

	public UILabel lPeizeNum;

	public UISprite sPeizeIcon;

	public Transform tPrizeBG;

	public GameObject MoveHeartParent;

	public UI_AnimationCtrl MoveHeartParentAnim;

	public UI_AnimationCtrl MoveHeartIconParentAnim;

	public UI_AnimationCtrl MoveHeartIconAnim;

	public UISprite Heart;

	public UI_Downloading_Tips uiDownloadingTips;

	private string SceneName;

	private SingleFileState isNeedDown;

	private bool hasSetScale;

	private bool buttonEnable;

	public TweenTransform animTran;

	private float lastClickUpgrade;

	public int LevelID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void UpdateState()
	{
	}

	public void SetLevelMaterial(LevelPassStart levelPassStart)
	{
	}

	private void ShowPrize()
	{
	}

	public void Hide()
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void CheckIsDownloading()
	{
	}

	public void ShowUnlock(SingleFileState singleFileState)
	{
	}

	public void setHeratActive()
	{
	}

	public void MyEnd()
	{
	}

	public void WaitingToCloseWindow()
	{
	}
}
