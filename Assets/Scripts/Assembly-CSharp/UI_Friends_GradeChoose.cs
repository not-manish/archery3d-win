using UnityEngine;

public class UI_Friends_GradeChoose : MonoBehaviour
{
	public UILabel lFriendsName;

	public UILabel lFriendsNamebg;

	public UILabel lTrophy;

	public UILabel lTrophybg;

	public string id;

	public UIButton btnClassic;

	public UIButton btnRush;

	public UIButton btnBingo;

	public UIButton btnBack;

	public UILabel lLastMatchCount;

	public UI_FriendMatch_List uiFriendMatchList;

	public PlayerHeadShow playerHeadShow;

	public GameType SelectGameType;

	public UI_Friends_LogIn_Item uiFriendsLogInItem;

	private float oldx;

	private float addx;

	private string greenbg;

	private string bluebg;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void UpdateState()
	{
	}

	public void ShowMatch()
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

	public void ClickChange(GameObject button)
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
