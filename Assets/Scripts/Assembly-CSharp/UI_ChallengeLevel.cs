using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UI_ChallengeLevel : MonoInstance<UI_ChallengeLevel>, UIBase
{
	[CompilerGenerated]
	private sealed class _003CShowNextLevel_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_ChallengeLevel _003C_003E4__this;

		public int levelID;

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
		public _003CShowNextLevel_003Ed__9(int _003C_003E1__state)
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

	public UI_ChallengeLevel_List uiLevelList;

	public UI_ChallengeLevel_LevelInfo uiLevelInfo;

	public UI_ChallengeLevel_Rank uiRank;

	public UI_ChallengeLevel_Join uiJoin;

	public UI_ChallengeLevel_Join_Popup uiJoinPopup;

	public UIButton btBack;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	[IteratorStateMachine(typeof(_003CShowNextLevel_003Ed__9))]
	private IEnumerator ShowNextLevel(int levelID)
	{
		return null;
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

	public bool CheckChallengeReward()
	{
		return false;
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	private void ButtonCommonClicked(ButtonType buttonType)
	{
	}

	public void UpdateItems()
	{
	}

	public void LevelClicked(int levelID, int levelIndex, ChallengeLevelItemState state)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
