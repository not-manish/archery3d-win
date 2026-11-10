using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TargetCarrier : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetCarrierAppearDisappear_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float WaitingTime;

		public TargetCarrier _003C_003E4__this;

		public bool active;

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
		public _003CSetCarrierAppearDisappear_003Ed__20(int _003C_003E1__state)
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

	public TargetCarrierContainers carContainers;

	[HideInInspector]
	public int carrierId;

	[HideInInspector]
	public List<TargetCtrl> targetCtrls;

	[HideInInspector]
	public Dictionary<TargetCtrl, GameObject> targetNotShoot;

	[HideInInspector]
	public List<TargetCtrl> destroyedCtrls;

	public void GenerateTargets(TargetCarrierOriData targetCarrierOriData, int ServeStartId, bool isLoadNotShoot)
	{
	}

	public TargetCtrl GetTargetCtrlByServeId(int serveID)
	{
		return null;
	}

	public bool Contains(TargetCtrl targetCtrl)
	{
		return false;
	}

	public bool Contains(int TargetServeId)
	{
		return false;
	}

	public void DestroyTarget(TargetCtrl targetCtrl)
	{
	}

	public void RecoverAllTarget()
	{
	}

	public void ResetMove()
	{
	}

	public void ResumeMove()
	{
	}

	public void PauseMove()
	{
	}

	public void SetAllTargetsPos(float targetTime)
	{
	}

	public void GetAllNotShootTarget(bool setActive)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void SetActive(bool active, float waitingTime = 0f)
	{
	}

	public void PlayRecover()
	{
	}

	public void PlayAni(bool isAppear)
	{
	}

	[IteratorStateMachine(typeof(_003CSetCarrierAppearDisappear_003Ed__20))]
	private IEnumerator SetCarrierAppearDisappear(float WaitingTime, bool active)
	{
		return null;
	}
}
