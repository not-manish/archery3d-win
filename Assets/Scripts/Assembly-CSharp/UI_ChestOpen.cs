using UnityEngine;
using com.simple.proto;

public class UI_ChestOpen : MonoInstance<UI_ChestOpen>, UIBase
{
	private enum ShowingWindow
	{
		TapContinue = 0,
		Gold = 1,
		Gem = 2,
		Equip = 3,
		ClassicTicket = 4,
		GrandTicket = 5,
		Arrow = 6
	}

	private enum ChestRequestState
	{
		NoRequest = 0,
		Asking = 1,
		Responsed = 2
	}

	public UI_ChestOpen_TapContinue uiTapContinue;

	public UI_ChestOpen_CoinGem uiCoinGem;

	public UI_ChestOpen_Equip uiEquip;

	public UI_ChestOpen_Common uiCommon;

	public UI_ChestOpen_Video uiChestOpenVideo;

	public UI_ChestOpen_RewardList uiChestOpenRewardList;

	public ChestOpenAnimCtrl chestOpenAnimCtrl;

	public int OpenCount;

	public Transform ChestPosition;

	public GameObject sCard;

	public OpenChestAnimState openChestAnimState;

	private ChestAnim chestAnim;

	public UI_ChestOpen_ShowBg uiChestOpenShowBg;

	public Camera camChestOpenCamera;

	public UIButton btBackground;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public FlexibleTimeRegulator m_tMaxWaitingTimeRegulator;

	public UI_WaitLoading uiWaitLoading;

	private bool hasSetScale;

	public UIChestOpenParam uiParam;

	private ShowingWindow CurShowingWindow;

	private CCChestReward chestReward;

	private long TransactionId;

	private ChestRequestState chestRequestState;

	public bool buttonEnable;

	public bool isOpen;

	public bool isHold;

	public int CurEquipIndex;

	public bool isOpenUI;

	private void Start()
	{
	}

	public void Show(object param)
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

	private void ButtonOnPress(GameObject go, bool isUP)
	{
	}

	public void PlayerUIAnim()
	{
	}

	public void WaittingShowNext()
	{
	}

	public bool isNewEquip(int EquipKindId, int Number)
	{
		return false;
	}

	public bool IsShowing()
	{
		return false;
	}

	private void Update()
	{
	}

	public void SetAction()
	{
	}

	public bool ChestOpenResponse()
	{
		return false;
	}

	public void ShowCardOrShowChest()
	{
	}

	public int GetOpenCount()
	{
		return 0;
	}

	public void isShowVideoTips()
	{
	}

	public bool ExterVideoResponse()
	{
		return false;
	}

	public void Show3DChestModel(UIChestOpenParam _uiParam)
	{
	}

	public void OpenCoinGemAnim(ChestRewardType rewardType, int ShowObjCount, Transform _endPosition, int quality = 0)
	{
	}
}
