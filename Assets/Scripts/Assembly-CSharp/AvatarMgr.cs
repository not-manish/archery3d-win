using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Pool3D.TimerUtil;
using UnityEngine;

public class AvatarMgr : MonoBehaviour
{
	public class AvatarInfo
	{
		public string Uid { get; set; }

		public string FbId { get; set; }

		public DownloadAvatarCallback Callback { get; set; }

		public int DownloadCnt { get; set; }

		public Texture2D Tex { get; set; }

		public long AccessTime { get; set; }
	}

	public delegate void DownloadAvatarCallback(string uid, string fbId, Texture2D avatar);

	private struct DownloadAvartarInfo
	{
		public string Uid { get; set; }

		public string FbId { get; set; }

		public string Url { get; set; }

		public DownloadAvatarCallback Callback { get; set; }
	}

	[CompilerGenerated]
	private sealed class _003CDownloadAvatarAsync_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DownloadAvartarInfo dai;

		private string _003Cuid_003E5__2;

		private string _003CfbId_003E5__3;

		private string _003Curl_003E5__4;

		private DownloadAvatarCallback _003Ccallback_003E5__5;

		private WWW _003Cwww_003E5__6;

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
		public _003CDownloadAvatarAsync_003Ed__30(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadLocalFacebookPhoto_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<string> localFbId;

		private int _003Ci_003E5__2;

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
		public _003CLoadLocalFacebookPhoto_003Ed__32(int _003C_003E1__state)
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

	private static AvatarMgr _instance;

	public const int DefaultAvatarSize = 128;

	private LinkedList<AvatarInfo> downloadList;

	public static Dictionary<string, Texture2D> persistFbTex;

	public static Dictionary<string, AvatarInfo> downloadedCache;

	private static List<AvatarInfo> LRLUList;

	private const int MaxCacheNum = 50;

	private Timer reDownloadTimer;

	private const int MaxReDownloadTimes = 3;

	private const int ReDownloadInterval = 10;

	private const int MAX_SAVE_LOCAL_PHOTO_NUM = 200;

	private GameObject avatarObjPrefab;

	public static AvatarMgr Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void DownloadAvatar(string uid, string fbId, DownloadAvatarCallback callback)
	{
	}

	private void DownloadNext()
	{
	}

	private void ReDownload()
	{
	}

	private string GetUrl(string fbId)
	{
		return null;
	}

	private void OnAvatarDownloaded(string uid, string fbId, Texture2D avatar)
	{
	}

	private void CacheAvatarInfo(AvatarInfo info)
	{
	}

	private int Comparison(AvatarInfo left, AvatarInfo right)
	{
		return 0;
	}

	public bool IsSelfOrFriend(string uid)
	{
		return false;
	}

	public AvatarNodeSc GenAvatarNode()
	{
		return null;
	}

	public void StopDownloadAvatar()
	{
	}

	public void DownloadAvatar(string uid, string fbId, string url, DownloadAvatarCallback callback)
	{
	}

	[IteratorStateMachine(typeof(_003CDownloadAvatarAsync_003Ed__30))]
	private IEnumerator DownloadAvatarAsync(DownloadAvartarInfo dai)
	{
		return null;
	}

	private void LoadLocalHeadPhoto()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadLocalFacebookPhoto_003Ed__32))]
	private IEnumerator LoadLocalFacebookPhoto(List<string> localFbId)
	{
		return null;
	}
}
