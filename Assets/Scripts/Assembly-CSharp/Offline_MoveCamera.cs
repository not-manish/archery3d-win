using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Offline_MoveCamera : MonoBehaviour
{
	private class DragSpeed
	{
		public const int LEN = 10;

		private float[] a;

		private int idx;

		public void Clear()
		{
		}

		public void addSp(float sp)
		{
		}

		public float avgSp()
		{
			return 0f;
		}
	}

	[CompilerGenerated]
	private sealed class _003CMoveOn_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float sp;

		public Offline_MoveCamera _003C_003E4__this;

		private float _003Ct_003E5__2;

		private float _003CtimeEnd_003E5__3;

		private float _003CtimeStart_003E5__4;

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
		public _003CMoveOn_003Ed__19(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CMoveToPos_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float start;

		public float end;

		public Offline_MoveCamera _003C_003E4__this;

		private float _003CtimeEnd_003E5__2;

		private float _003CtimeStart_003E5__3;

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
		public _003CMoveToPos_003Ed__20(int _003C_003E1__state)
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

	public float moveFactor;

	public float speedThreold;

	public float zMin;

	public float zMax;

	private DragSpeed dragSpeed;

	public Transform cameraTrans;

	private Camera cam;

	private bool isPressed;

	private bool isDrag;

	private Vector2 lastPos;

	private Vector2 delta;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	private void Start()
	{
	}

	public void Drag(Vector2 delta)
	{
	}

	public void DragStart()
	{
	}

	public void DragEnd()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveOn_003Ed__19))]
	private IEnumerator MoveOn(float sp)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveToPos_003Ed__20))]
	private IEnumerator MoveToPos(float start, float end)
	{
		return null;
	}
}
