using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UI_GO_Reward : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitingToRestartGame_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_GO_Reward _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitingToRestartGame_003Ed__61(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitingToShowPlayAgain_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_GO_Reward _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitingToShowPlayAgain_003Ed__63(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public UIButton btRematch;

	public UILabel lbtRematchName;

	public UIButton btPlayAgain;

	public UILabel lbtPlayAgainName;

	public UIButton btExit;

	public UISprite sSumReward;

	public UISprite sMyReward;

	public UISprite sOppReward;

	public UILabel lRematchTime;

	public UILabel lGoldNotEnough;

	public UILabel lSumReward;

	public UILabel lSumRewardbg;

	public UILabel lMyReward;

	public UILabel lOppReward;

	public GameObject oChest;

	public UISprite sChestBig;

	public GameObject oSumMoney;

	public GameObject oMoney;

	private FlexibleRealTimeRegulator m_tTimeForPlayAgain;

	private FlexibleRealTimeRegulator m_tTimeForwait;

	private FlexibleRealTimeRegulator m_tTimeForShowAI;

	public UI_AnimationCtrl ExitBtnShow;

	public UI_AnimationCtrl PlayerAgainBtnShow;

	public UI_AnimationCtrl RematchBtnShow;

	public UI_AnimationCtrl RematchBtnHide;

	public UI_AnimationCtrl ChestShow;

	public UI_AnimationCtrl ChestFullShow;

	public UI_AnimationCtrl MoneyShow;

	public UI_AnimationCtrl MoneyHide;

	public UI_Gameover_tenChest uiGameoverTenChest;

	private float waittingRewmatch;

	private float time;

	private bool clickedRematch;

	private bool isShowRematchTime;

	private float t;

	private int sumRewardNums;

	private int myRewardNums;

	private int oppRewardNums;

	public CoinAddState coinAddState;

	private UI_GameOver uiGameOver;

	private UIGameOverParam uiParam;

	private PlayerData playerData;

	private bool buttonEnable;

	private int myRematchState;

	private int oppRematchState;

	private UnLockGameMode unLockGameMode;

	private UnLockGameModeLevel unLockGameModeLevel;

	private void Update()
	{
	}

	public void PlayerAdd()
	{
	}

	public void PlayerSumDel()
	{
	}

	public void ChangeCoinAddState(CoinAddState _coinAddState)
	{
	}

	private void updateReward()
	{
	}

	public void Show(UI_GameOver _uiGO, UIGameOverParam _uiParam)
	{
	}

	private void UpdeteChestReward(UIGameOverParam gameOverParam)
	{
	}

	public void ShowChestFinish()
	{
	}

	public void Hide(object param)
	{
	}

	private void Start()
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

	public void ShowGameExit()
	{
	}

	private void SetRematchState()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitingToRestartGame_003Ed__61))]
	private IEnumerator WaitingToRestartGame()
	{
		return null;
	}

	private bool IfPlayAgainModeRight()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CWaitingToShowPlayAgain_003Ed__63))]
	private IEnumerator WaitingToShowPlayAgain()
	{
		return null;
	}

	private void SetPlayAgainActive(bool active)
	{
	}

	public void RematchBtnHideFinish()
	{
	}

	public void RematchBtnOnlyHideFinish()
	{
	}

	private void SetRematchActive(bool active)
	{
	}

	public void setButtonState(UIButton Button, UILabel ButtonName, bool isShow)
	{
	}

	private void SetExitActive(bool active)
	{
	}

	public void MoneyShowFinish()
	{
	}

	public void MoneyHideFinish()
	{
	}

	private void RecoverAllAni()
	{
	}

	public void OpenCoinGemAnim(ChestRewardType rewardType, int ShowObjCount, Transform end)
	{
	}

	public void LeaveRoomResponse()
	{
	}

	public void RoomRematchResponse()
	{
	}

	public void Rematch()
	{
	}

	public void ShowAIWord()
	{
	}

	public void ShowMyWord()
	{
	}

	public void PlayAgainResponse()
	{
	}

	public void CheskIsUnlockGameMode()
	{
	}

	public void CheskIsShopEquipTips()
	{
	}

	public bool isCheckEquip()
	{
		return false;
	}

	public bool CheckLeagueRankResponseShow()
	{
		return false;
	}

	public bool SetLeagueRankResponseShow()
	{
		return false;
	}

	public bool CheckLimitedTimeBuy(int CheckIndex = -1)
	{
		return false;
	}

	public bool ShowNewPlayer(bool isOnlyRefreshTime = false)
	{
		return false;
	}
}
