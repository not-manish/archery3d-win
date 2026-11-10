using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UI_Equip_Creator : MonoBehaviour, UIBase
{
	[CompilerGenerated]
	private sealed class _003CLoadUIAsync_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_Equip_Creator _003C_003E4__this;

		public Action<AsyncLoadType> LoadFinished;

		private ResourceRequest _003CojAsset_003E5__2;

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
		public _003CLoadUIAsync_003Ed__5(int _003C_003E1__state)
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

	public UICreator creator;

	private string prefabName;

	private static object _lock;

	public void Init()
	{
	}

	public void InitAsync(Action<AsyncLoadType> LoadFinished)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadUIAsync_003Ed__5))]
	private IEnumerator LoadUIAsync(Action<AsyncLoadType> LoadFinished)
	{
		return null;
	}

	public void Show(object param)
	{
	}

	public bool IsNotShowOtherPanel()
	{
		return false;
	}

	public void Hide(object param)
	{
	}

	public void ShowWindow(EquipWindows type, object param, bool isShowinfo = false, UIModelKind _uiModelKind = UIModelKind.EquipAll)
	{
	}

	public void HideEnforce()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}
}
