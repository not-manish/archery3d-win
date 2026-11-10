using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using com.simple.proto;

public class UI_Friends : MonoInstance<UI_Friends>, UIBase
{
	[CompilerGenerated]
	private sealed class _003CPostGetInfo_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_Friends _003C_003E4__this;

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
		public _003CPostGetInfo_003Ed__12(int _003C_003E1__state)
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

	public UI_Friends_GradeChoose uiFriendsGradeChoose;

	public UI_Friends_LogIn uiFriendsLogIn;

	public UI_Friends_NoLogIn uiFriendsNoLogIn;

	private PlayerData playerdate;

	private bool hasSetScale;

	private int PostFriendsInfoCount;

	private int FriendsCount;

	private List<List<CCFriendAskInfo>> FriendAskInfos;

	private IList<CCFriendItem> AllFriends;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void ShowisLongin()
	{
	}

	public void GetFacebookFriendsCallBack(List<ThirdPlatformUserItem> Friends)
	{
	}

	[IteratorStateMachine(typeof(_003CPostGetInfo_003Ed__12))]
	public IEnumerator PostGetInfo()
	{
		return null;
	}

	public void GetRespones()
	{
	}

	public void GetServerBroadcast()
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	private void ButtonCommonClicked(ButtonType buttonType)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
