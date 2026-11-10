using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UI_BGShow : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadScene_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_BGShow _003C_003E4__this;

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
		public _003CLoadScene_003Ed__8(int _003C_003E1__state)
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

	public UILabel lTips;

	public UI_Progress_Scroll uiProgress;

	private AsyncOperation async;

	private int disableProgress;

	private int toProgress;

	private bool hided;

	private bool canOver;

	private bool buttonEnable;

	public static bool NeedReconnectServe;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadScene_003Ed__8))]
	private IEnumerator LoadScene()
	{
		return null;
	}

	private void Update()
	{
	}

	public void Show(float curProgress)
	{
	}

	public void InitOver()
	{
	}

	private void Hide()
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

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnApplicationQuit()
	{
	}

	public static void Reconnect()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}
}
