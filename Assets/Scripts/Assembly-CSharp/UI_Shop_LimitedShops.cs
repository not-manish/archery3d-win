using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UI_Shop_LimitedShops : MonoBehaviour
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
	private sealed class _003CWaitingRecenter_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_Shop_LimitedShops _003C_003E4__this;

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
		public _003CWaitingRecenter_003Ed__26(int _003C_003E1__state)
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

	public new const string tag = "ShopLimitenTimeBuy";

	public UIScrollView ScrollViewParent;

	public UIScrollView ScrollViewself;

	public Transform ItemParent;

	public UILabel AccountNum;

	public UILabel AccountNumBg;

	public UISprite LeftArrows;

	public UISprite RightArrows;

	public UIButton btnLeft;

	public UIButton btnright;

	private int MaxChildCount;

	public BoxCollider rightCollider;

	public BoxCollider leftCollider;

	public UIDragScrollView DrapPanel;

	public List<UIDragScrollView> AllChildDragScrollView;

	public UI_Shop_List_Others uiShopListOthers;

	public UIScrollViewDouble uiScrollViewDouble;

	public UICenterOnChild uiCenterOnChild;

	public MoveState moveState;

	public MoveDirection moveDirecti;

	private UI_Shop_List_Others uiShopOthers;

	public List<UI_OnSale_Common_Item> allLimitedItem;

	private float waitingAutoTime;

	public bool InputButton;

	private int NowCount;

	public float time;

	private void Start()
	{
	}

	public void Show(List<UI_OnSale_Common_Item> _allLimitedItem)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitingRecenter_003Ed__26))]
	private IEnumerator WaitingRecenter()
	{
		return null;
	}

	public void GetUIDragScorllView(Transform Parent)
	{
	}

	public void Hide()
	{
	}

	private void Update()
	{
	}

	public void OnButtonClick(GameObject button)
	{
	}
}
