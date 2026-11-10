using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using com.simple.proto;

public class UI_Rank_Friend : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPostGetInfo_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_Rank_Friend _003C_003E4__this;

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
		public _003CPostGetInfo_003Ed__32(int _003C_003E1__state)
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

	public UIButton uiConnectToFaceBook;

	public UILabel lConnectToFaceBook;

	public UILabel lRconnectToFaceBook;

	public GameObject oLingkTips;

	public UILabel lconnectTips;

	public UILabel lRconnectTips1;

	public UILabel lRconnectTips2;

	public Dictionary<string, RankFriendItems> AllFriendRank;

	public UIScrollView uiScrollView;

	public UIWrapContentEx uiWrapContentEx;

	public GameObject oFrientItems;

	public UILabel lChestName;

	public UILabel lChestNameBg;

	public UISprite sChest;

	private bool hasSetScale;

	private UI_Rank uiRank;

	private RankFriendWindows curShowWindows;

	public Dictionary<string, string> FriendsFBInfo;

	private PlayerData playerdate;

	private int PostFriendsInfoCount;

	private int FriendsCount;

	private List<List<CCFriendAskInfo>> FriendAskInfos;

	private List<CCFriendItem> AllFriends;

	private bool buttonEnable;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Show(UI_Rank _uiRank)
	{
	}

	public void ShowWindows(RankFriendWindows window)
	{
	}

	public void OnlyShowSelf()
	{
	}

	public void ShowFriendRank(object Param)
	{
	}

	public void InitFriendDate(object Param)
	{
	}

	public void ShowisLongin()
	{
	}

	public void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	public void GetFacebookFriendsCallBack(List<ThirdPlatformUserItem> Friends)
	{
	}

	[IteratorStateMachine(typeof(_003CPostGetInfo_003Ed__32))]
	public IEnumerator PostGetInfo()
	{
		return null;
	}

	public void GetRespones()
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

	public bool IsShowing()
	{
		return false;
	}

	public void RecoverAccountLoginFacebookCallBack(string fbId, string fbToken, string fbName)
	{
	}

	public void ReconnectLoginSuccess()
	{
	}

	public void SetUpdateName()
	{
	}
}
