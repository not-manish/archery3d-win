using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AssetUpdate
{
	public class AssetDownloadManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDownloadFile_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ConfigFileInfo fileInfo;

			public AssetDownloadManager _003C_003E4__this;

			public object priority;

			private string _003ChttpsFullUrl_003E5__2;

			private WWW _003Cwww_003E5__3;

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
			public _003CDownloadFile_003Ed__14(int _003C_003E1__state)
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

		private static AssetDownloadManager _instance;

		public static Dictionary<DlPriority, List<ConfigFileInfo>> dlAssetsInfoPros;

		public Dictionary<DlPriority, Action> dlAssetsSuccessCallbacks;

		public static Dictionary<string, ConfigFileInfo> dlAssetsInfoPros_Single;

		public static Dictionary<string, Action> dlAssetsSuccessCallbacks_Single;

		public static HashSet<string> dlRsMd5Set;

		public static HashSet<string> dlRsMd5SetUnpacked;

		public static Dictionary<string, WWW> WwwDownloading;

		public static AssetDownloadManager Instance => null;

		private void Awake()
		{
		}

		public void ClearAllDownloading()
		{
		}

		public void DownloadFiles(DlPriority priority, List<ConfigFileInfo> files, Action callback)
		{
		}

		public void DownloadFiles_Single(ConfigFileInfo configFileInfo, Action callback)
		{
		}

		[IteratorStateMachine(typeof(_003CDownloadFile_003Ed__14))]
		public IEnumerator DownloadFile(ConfigFileInfo fileInfo, object priority = null)
		{
			return null;
		}

		private void DownloadFileOver(ConfigFileInfo fileInfo, object oPriority = null)
		{
		}

		public bool IsAssetDownloading(string md5)
		{
			return false;
		}

		public bool IsAssetUnpacked(string md5)
		{
			return false;
		}

		public void DownloadingProgress(ref float sumProgress, ref long sumSize, DlPriority priority)
		{
		}

		public void DownloadingProgress(ref float sumProgress, ref long sumSize, string fileName)
		{
		}
	}
}
