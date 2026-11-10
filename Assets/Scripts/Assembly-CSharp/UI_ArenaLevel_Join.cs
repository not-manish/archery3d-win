using UnityEngine;

public class UI_ArenaLevel_Join : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btJoin;

	public UIButton btExit;

	public UISprite sMoneyTicket;

	public UILabel lMoneyTicket;

	private UI_ArenaLevel uiArenaLevel;

	private ArenaType arenaType;

	private long EntryFee;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_ArenaLevel _uiArenaLevel, ArenaType _arenaType)
	{
	}

	public void UpdateState()
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

	public bool IsJoinByGems()
	{
		return false;
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void GoToShopBuyGold()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
