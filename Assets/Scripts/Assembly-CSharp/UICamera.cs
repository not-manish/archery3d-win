using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/UI/NGUI Event System (UICamera)")]
[ExecuteInEditMode]
public class UICamera : MonoBehaviour
{
	public enum ControlScheme
	{
		Mouse = 0,
		Touch = 1,
		Controller = 2
	}

	public enum ClickNotification
	{
		None = 0,
		Always = 1,
		BasedOnDelta = 2
	}

	public class MouseOrTouch
	{
		public Vector2 pos;

		public Vector2 lastPos;

		public Vector2 delta;

		public Vector2 totalDelta;

		public Camera pressedCam;

		public GameObject last;

		public GameObject current;

		public GameObject pressed;

		public GameObject dragged;

		public float clickTime;

		public ClickNotification clickNotification;

		public bool touchBegan;

		public bool pressStarted;

		public bool dragStarted;
	}

	public enum EventType
	{
		World = 0,
		UI = 1,
		Unity2D = 2
	}

	public delegate void OnScreenResize();

	public delegate void OnCustomInput();

	private struct DepthEntry
	{
		public int depth;

		public RaycastHit hit;
	}

	[CompilerGenerated]
	private sealed class _003CChangeSelection_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICamera _003C_003E4__this;

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
		public _003CChangeSelection_003Ed__72(int _003C_003E1__state)
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

	public static BetterList<UICamera> list;

	public static OnScreenResize onScreenResize;

	public EventType eventType;

	public LayerMask eventReceiverMask;

	public bool debug;

	public bool useMouse;

	public bool useTouch;

	public bool allowMultiTouch;

	public bool useKeyboard;

	public bool useController;

	public bool stickyTooltip;

	public float tooltipDelay;

	public float mouseDragThreshold;

	public float mouseClickThreshold;

	public float touchDragThreshold;

	public float touchClickThreshold;

	public float rangeDistance;

	public string scrollAxisName;

	public string verticalAxisName;

	public string horizontalAxisName;

	public KeyCode submitKey0;

	public KeyCode submitKey1;

	public KeyCode cancelKey0;

	public KeyCode cancelKey1;

	public static OnCustomInput onCustomInput;

	public static bool showTooltips;

	public static Vector2 lastTouchPosition;

	public static RaycastHit lastHit;

	public static UICamera current;

	public static Camera currentCamera;

	public static ControlScheme currentScheme;

	public static int currentTouchID;

	public static KeyCode currentKey;

	public static MouseOrTouch currentTouch;

	public static bool inputHasFocus;

	public static GameObject genericEventHandler;

	public static GameObject fallThrough;

	private static GameObject mCurrentSelection;

	private static GameObject mNextSelection;

	private static ControlScheme mNextScheme;

	private static MouseOrTouch[] mMouse;

	private static GameObject mHover;

	public static MouseOrTouch controller;

	private static float mNextEvent;

	private static Dictionary<int, MouseOrTouch> mTouches;

	private static int mWidth;

	private static int mHeight;

	private GameObject mTooltip;

	private Camera mCam;

	private float mTooltipTime;

	private float mNextRaycast;

	public static bool isDragging;

	public static GameObject hoveredObject;

	private static DepthEntry mHit;

	private static BetterList<DepthEntry> mHits;

	private static RaycastHit mEmpty;

	private static Plane m2DPlane;

	private static bool mNotifying;

	[Obsolete("Use new OnDragStart / OnDragOver / OnDragOut / OnDragEnd events instead")]
	public bool stickyPress => false;

	public static Ray currentRay => default;

	private bool handlesEvents => false;

	public Camera cachedCamera => null;

	public static GameObject selectedObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static int touchCount => 0;

	public static int dragCount => 0;

	public static Camera mainCamera => null;

	public static UICamera eventHandler => null;

	public static bool IsPressed(GameObject go)
	{
		return false;
	}

	protected static void SetSelection(GameObject go, ControlScheme scheme)
	{
	}

	[IteratorStateMachine(typeof(_003CChangeSelection_003Ed__72))]
	private IEnumerator ChangeSelection()
	{
		return null;
	}

	private static int CompareFunc(UICamera a, UICamera b)
	{
		return 0;
	}

	public static bool Raycast(Vector3 inPos, out RaycastHit hit)
	{
		hit = default;
		return false;
	}

	private static bool IsVisible(ref RaycastHit hit)
	{
		return false;
	}

	private static bool IsVisible(ref DepthEntry de)
	{
		return false;
	}

	public static bool IsHighlighted(GameObject go)
	{
		return false;
	}

	public static UICamera FindCameraForLayer(int layer)
	{
		return null;
	}

	private static int GetDirection(KeyCode up, KeyCode down)
	{
		return 0;
	}

	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		return 0;
	}

	private static int GetDirection(string axis)
	{
		return 0;
	}

	public static void Notify(GameObject go, string funcName, object obj)
	{
	}

	public static MouseOrTouch GetMouse(int button)
	{
		return null;
	}

	public static MouseOrTouch GetTouch(int id)
	{
		return null;
	}

	public static void RemoveTouch(int id)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void ProcessMouse()
	{
	}

	public void ProcessTouches()
	{
	}

	private void ProcessFakeTouches()
	{
	}

	public void ProcessOthers()
	{
	}

	public void ProcessTouch(bool pressed, bool unpressed)
	{
	}

	public void ShowTooltip(bool val)
	{
	}

	private void OnApplicationPause()
	{
	}
}
