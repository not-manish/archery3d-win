using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UI_Sale_List : MonoBehaviour
{
	public enum MoveDirection
	{
		Right = 0,
		Left = 1,
		Up = 2,
		Down = 3
	}

	public enum MoveState
	{
		Null = 0,
		OnPress = 1,
		OnDrap = 2,
		AutoMove = 3,
		ClickMove = 4
	}

	[CompilerGenerated]
	private sealed class _003CWaitingRecenter_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_Sale_List _003C_003E4__this;

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
		public _003CWaitingRecenter_003Ed__24(int _003C_003E1__state)
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

	public Transform ItemParent;

	public UILabel AccountNum;

	public UILabel AccountNumBg;

	public UISprite LeftArrows;

	public UISprite RightArrows;

	public UIButton btnLeft;

	public UIButton btnright;

	public BoxCollider rightCollider;

	public BoxCollider leftCollider;

	private int MaxChildCount;

	public UIDragScrollView DrapPanel;

	public UIPanel pScrollPanel;

	public UICenterOnChild uiCenterOnChild;

	private float ItemStartLocalX;

	private float ItemWidth;

	public MoveState moveState;

	public MoveDirection moveDirecti;

	public Dictionary<int, UI_OnSale_Common_Item> allLimitedItem;

	public List<int> allLimitedItemKeys;

	private float waitingAutoTime;

	private int NowCount;

	private float time;

	private void Start()
	{
	}

	public void Show(Dictionary<int, UI_OnSale_Common_Item> _allLimitedItem, int ShowCount = 0)
	{
	}

	public void SetPanelPosition(int ShowCount)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitingRecenter_003Ed__24))]
	private IEnumerator WaitingRecenter()
	{
		return null;
	}

	public void Hide()
	{
	}

	private void Update()
	{
	}

	public void RemoveBuyItem(int PackageID)
	{
	}

	public void OnButtonClick(GameObject button)
	{
	}
}
