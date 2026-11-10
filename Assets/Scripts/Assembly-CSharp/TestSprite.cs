using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TestSprite : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CReturn_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TestSprite _003C_003E4__this;

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
		public _003CReturn_003Ed__7(int _003C_003E1__state)
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

	public UISprite B_Sprite;

	public UIButton Button;

	public string[] chestname;

	private int x;

	private int y;

	private void Start()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	[IteratorStateMachine(typeof(_003CReturn_003Ed__7))]
	private IEnumerator Return(int z)
	{
		return null;
	}
}
