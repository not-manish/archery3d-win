using DG.Tweening;
using UnityEngine;

public class BoxAnimationCtl : MonoBehaviour
{
	protected Sequence enterSequence;

	protected Sequence lockedSequence;

	protected Sequence unlockedSequence;

	private int state;

	public const int box_none = 0;

	public const int box_locked = 1;

	public const int box_unlocking = 2;

	public const int box_unlocked = 3;

	private int animationState;

	private const int anim_state_none = 0;

	private const int anim_state_enter = 1;

	private const int anim_state_locked = 2;

	private const int anim_state_unlocked = 3;

	private const int anim_state_pre_end = 4;

	private Tween enterCompleteDelayCall;

	private Tween lockedCompleteDelayCall;

	private Tween unlockedCompleteDelayCall;

	private static int idx;

	private int idxx;

	public GameObject target;

	private Vector3 p0;

	private Vector3 p1;

	private Vector3 p2;

	private Vector3 s0;

	private Vector3 s1;

	private Vector3 s2;

	public float t1;

	public float t2;

	public float state01Scale;

	public float delayTimeMin;

	public float delayTimeMax;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartAnimation()
	{
	}

	public void UpdateState(int state)
	{
	}

	private void CheckNeedUpdateAnimation()
	{
	}

	private bool canEnterAnimation()
	{
		return false;
	}

	private bool canLockedAnimation()
	{
		return false;
	}

	private bool canUnlockedAnimation()
	{
		return false;
	}

	private void DoEnterAnimation()
	{
	}

	private void EnterAnimationComplete()
	{
	}

	private void _DoEnterAnimationComplete()
	{
	}

	private void KillDelayCall_Enter()
	{
	}

	private void DoLockedAnimation()
	{
	}

	private void LockedAnimationComplete()
	{
	}

	private void _DoLockedAnimationComplete()
	{
	}

	private void KillDelayCall_Locked()
	{
	}

	private void DoUnlockedAnimation()
	{
	}

	private void InitIdxx()
	{
	}

	private void UnlockedAnimationComplete()
	{
	}

	private void _DoUnlockedAnimationComplete()
	{
	}

	private void KillDelayCall_Unlocked()
	{
	}

	private void KillDelayCall()
	{
	}

	private float randomDelayTime()
	{
		return 0f;
	}

	private float t(float t)
	{
		return 0f;
	}

	private Tween Move01()
	{
		return null;
	}

	private Tween Scale01()
	{
		return null;
	}

	private Tween Move12()
	{
		return null;
	}

	private Tween Scale12()
	{
		return null;
	}
}
