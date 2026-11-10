using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UI_Loading_Connect : MonoBehaviour
{
	private enum State
	{
		LoadingScene = 0,
		Logining = 1,
		CheckAndDlRsIndex = 2,
		DlNeedRs = 3,
		Finished = 4,
		WaitingQuit = 5
	}

	[CompilerGenerated]
	private sealed class _003CWaitingToClose_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

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
		public _003CWaitingToClose_003Ed__44(int _003C_003E1__state)
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

	public static bool ignore_download;

	public static bool ignore_guide;

	public static bool unlock_all_level;

	public static bool unlock_offline;

	public static bool unlock_all_game_mode;

	public static bool ignore_level_gold;

	public static bool is_debug_mode;

	public static bool start_clear_all_data;

	public static NetType net_type;

	public static bool close_all_sound;

	public static bool is_infinite_gold;

	public static bool use_test_account;

	public static bool is_build_to_AB;

	public static bool use_SSL;

	private string[] LoadingTex;

	private string lTipstr;

	public UILabel lTips;

	public UILabel lPercent;

	public UI_Progress_Scroll uiProgress;

	public UIButton btOffline;

	public GameObject oProgress;

	public GameObject oPercent;

	public UITexture BG;

	private FlexibleTimeRegulator m_tTimeRegulaor;

	private UI_Loading uiLoading;

	private State state;

	private bool buttonEnable;

	private static NetType getNetType(int value)
	{
		return NetType.local;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetLoadingState(State _state)
	{
	}

	public void Show(UI_Loading _uiLoading)
	{
	}

	public void Hide()
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

	public void SetPlayOfflineMode()
	{
	}

	public void SetRetry()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void LoadingSceneFinished()
	{
	}

	public void QuitQuickly()
	{
	}

	public void ForceUpgradeClientAction()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitingToClose_003Ed__44))]
	private IEnumerator WaitingToClose(float waitTime)
	{
		return null;
	}

	public void OptUpgradeClientAction()
	{
	}

	public void CheckClientRsIndexFinishAction(bool needDownload)
	{
	}

	public void DownloadNeedRsAction()
	{
	}

	public bool shouldIgnoreVersionUpdate(string CurServerVersion3)
	{
		return false;
	}
}
