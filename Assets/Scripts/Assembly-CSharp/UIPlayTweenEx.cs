using System.Collections.Generic;
using AnimationOrTween;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Play Tween Ex")]
[ExecuteInEditMode]
public class UIPlayTweenEx : MonoBehaviour
{
	public static UIPlayTweenEx current;

	public GameObject tweenTarget;

	public int tweenGroup;

	public Trigger trigger;

	public Direction playDirection;

	public bool resetOnPlay;

	public bool resetIfDisabled;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public bool includeChildren;

	public bool isPlayLoop;

	public float DelayTime;

	private float AddTime;

	public List<EventDelegate> onFinished;

	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[SerializeField]
	[HideInInspector]
	private string callWhenFinished;

	private UITweener[] mTweens;

	private bool mStarted;

	private int mActive;

	private bool mActivated;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void OnDragOut()
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	private void OnToggle()
	{
	}

	private void Update()
	{
	}

	public void Play(bool forward)
	{
	}

	private void OnFinished()
	{
	}
}
