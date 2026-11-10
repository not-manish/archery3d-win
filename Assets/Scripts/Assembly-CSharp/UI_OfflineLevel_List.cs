using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UI_OfflineLevel_List : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CScrollToFirstItem_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CScrollToFirstItem_003Ed__14(int _003C_003E1__state)
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

	public Camera OfflineCamera;

	public List<UI_OfflineLevel_Item> uiLists;

	public Material LevelPassMat;

	public Material LevelNotPassMat;

	public Material LevelNumberPassMat;

	public Material LevelNumberNotPassMat;

	public Material StarLightMat;

	public Material StarDarkMat;

	public Material LineLightMat;

	public Material LineDarkMat;

	public MeshRenderer LineTransition;

	public UI_OfflineLevel_LockStar[] uiOfflineLevelLockStar;

	private void Start()
	{
	}

	public void CreateItems()
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToFirstItem_003Ed__14))]
	private IEnumerator ScrollToFirstItem()
	{
		return null;
	}
}
