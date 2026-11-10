using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OfflineLevelCtrl : MonoBehaviour
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
	private sealed class _003CMoveOn_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float sp;

		public OfflineLevelCtrl _003C_003E4__this;

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
		public _003CMoveOn_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CMoveToPos_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float start;

		public float end;

		public OfflineLevelCtrl _003C_003E4__this;

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
		public _003CMoveToPos_003Ed__54(int _003C_003E1__state)
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

	public Camera moveCamera;

	public GameObject MovePlane;

	private float cameraMinPosition;

	private float cameraMaxPosition;

	private float cameraOffSet;

	public bool isEnterMouse;

	public bool isDrag;

	public float backspeed;

	private Vector3 force;

	private bool isMouseUp;

	private Vector3 oldMousePosition;

	private Vector3 oldPanelPosition;

	public UI_OfflineLevel_List offlineLevel_List;

	public UI_OfflineLevel_Item uiOfflineLevelItem;

	private float movebackTime;

	public float MovebackTotalTime;

	public Vector3 oldCarmerPosition;

	public bool isScroll;

	public int MoveToLevel;

	private float OneLevel;

	private int LastOpenLevel;

	private Rigidbody MovePlaneRigidBody;

	private Vector3 MovePlaneOldPosition;

	private Ray ray;

	private RaycastHit hit;

	private float times;

	private float MoveDistance;

	public float moveFactor;

	public float speedThreold;

	public float zMin;

	public float zMax;

	private DragSpeed dragSpeed;

	public Transform cameraTrans;

	private bool isMove;

	private bool isPressed;

	private bool isUI;

	public bool isAutoScrollBack;

	private Vector2 lastPos;

	private Vector2 delta;

	public void Show(int Level = -1)
	{
	}

	public void Hide()
	{
	}

	public float GetMoveSpeed(float time, float moveDistance)
	{
		return 0f;
	}

	public Vector3 GetMouseMovePositon(Vector3 mousePosition)
	{
		return default;
	}

	public void UpdateState(int _levelID)
	{
	}

	public void ChooseUpdatePosition(float MovePlane_z, bool isFirstEnter = false)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
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

	[IteratorStateMachine(typeof(_003CMoveOn_003Ed__53))]
	private IEnumerator MoveOn(float sp)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveToPos_003Ed__54))]
	private IEnumerator MoveToPos(float start, float end)
	{
		return null;
	}

	public void SetScroll(bool isStart, int ScorllLevelID = 0)
	{
	}

	public void MoveByScroll()
	{
	}

	public void SetBackBtnShow(int Nowlevel)
	{
	}

	public void AutoMoveBack(float backTime, Vector3 moveAnimPosition, Vector3 moveAnimEnd)
	{
	}

	public void SetAutoMoveBack(bool isStart)
	{
	}
}
