using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UI_LevelClassic_List : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitingEnableCenterChild_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_LevelClassic_List _003C_003E4__this;

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
		public _003CWaitingEnableCenterChild_003Ed__8(int _003C_003E1__state)
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

	public UIGrid uiGrid;

	public UIScrollView uiScrollView;

	public UICenterOnChild uiCenterOnChild;

	private List<UI_Level1v1_CommonItem> uiLists;

	private LevelClassicParam uiParam;

	private UnLockGameModeLevel unLockGameModeLevel;

	public void CreateItems(object param, UnLockGameModeLevel _unLockGameModeLevel)
	{
	}

	private void ScrollToFirstItem()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitingEnableCenterChild_003Ed__8))]
	private IEnumerator WaitingEnableCenterChild()
	{
		return null;
	}

	private int GetMaxUnlockLevelIndex(bool isUnlockAnimPlay)
	{
		return 0;
	}

	public void ButtonInfoClicked()
	{
	}
}
