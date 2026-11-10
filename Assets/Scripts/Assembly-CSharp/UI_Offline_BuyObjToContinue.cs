using UnityEngine;

public class UI_Offline_BuyObjToContinue : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btBack;

	public UIButton btPayDiamond;

	public UIButton btBuyDiamond;

	public UILabel labDiamondNum;

	public UILabel labGetObjNum;

	public UILabel labTitle;

	public UILabel labPayDiamondNum;

	public LevelSingleRealtimeData levelSingleRealtimeData;

	public LevelSingleOriData levelSingleOriData;

	private SelectGameOverState gameover_state;

	public int LevelID;

	public SelectGameOverState selectGameOverState
	{
		get
		{
			return SelectGameOverState.waitSelecting;
		}
		set
		{
		}
	}

	public void Start()
	{
	}

	public void Show(object parm)
	{
	}

	public int GetlevelSingleOriData_BuyCount()
	{
		return 0;
	}

	public int GetlevelSingleOriData_PayPrice()
	{
		return 0;
	}

	public bool IsShowing()
	{
		return false;
	}

	public virtual void UpdateState()
	{
	}

	public virtual void Hide(object parm)
	{
	}

	public virtual void EnableButtons()
	{
	}

	public virtual void DisableButtons()
	{
	}

	public virtual void KeyEscapeClicked()
	{
	}

	public virtual void ButtonOnClicked(GameObject button)
	{
	}

	public virtual void PayDiamondButtonOnClicked(GameObject button)
	{
	}

	public virtual void BuyDiamondButtonOnClicked(GameObject button)
	{
	}

	public virtual void BuyObjsResponse()
	{
	}
}
