using System.Runtime.CompilerServices;
using UnityEngine;

public class LuckyTurntable : MonoBehaviour
{
	public enum State
	{
		None = 0,
		Start = 1,
		Prepared = 2,
		End = 3,
		EndWaiting = 4,
		stop = 5
	}

	public delegate void OnFinishCallback();

	[CompilerGenerated]
	private OnFinishCallback m_OnFinish;

	public float MaxSpeed;

	public Transform node;

	private State _state;

	private float _endAngle;

	private float AddSpendTime;

	private float AddAndMaxSpendTime;

	private float _tmpAngle;

	private float _time;

	private float _factor;

	private float allRoundTime;

	public float WaitingTime;

	private UI_MiniGames_Spin uiMiniGamesSpin;

	private int currPointingIdx;

	private int prevPointingIdx;

	public int rewardIndex;

	private bool isSpecial;

	public State CurState
	{
		get
		{
			return State.None;
		}
		private set
		{
		}
	}

	public float EndAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private event OnFinishCallback OnFinish
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SetOnFinishCallback(OnFinishCallback onFinish)
	{
	}

	private void Start()
	{
	}

	public void Show(UI_MiniGames_Spin _uiMiniGamesSpin)
	{
	}

	private void Update()
	{
	}

	private void PointToItem()
	{
	}

	private float GetCurClockwiseAngle()
	{
		return 0f;
	}

	public void OnStartClick(int index)
	{
	}

	public void OnStopClick(int RewardIndex)
	{
	}

	public void OnRandomClick()
	{
	}

	public void ErrorStop()
	{
	}
}
