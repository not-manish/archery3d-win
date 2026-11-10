public class StateMachine<T>
{
	private T m_pOwner;

	private State<T> m_pCurrentState;

	private State<T> m_pPreviousState;

	private State<T> m_pGlobalState;

	public StateMachine(T _owner)
	{
	}

	public void SetCurrentState(State<T> s)
	{
	}

	public void SetGlobalState(State<T> s)
	{
	}

	public void SetPreviousState(State<T> s)
	{
	}

	public State<T> GetCurrentState()
	{
		return null;
	}

	public State<T> GetGlobalState()
	{
		return null;
	}

	public State<T> GetPreState()
	{
		return null;
	}

	public void Update()
	{
	}

	public bool HandleMessage(Telegram telegram)
	{
		return false;
	}

	public void InitState(State<T> newState)
	{
	}

	public void ExitState()
	{
	}

	public void ChangeState(State<T> newState)
	{
	}

	public void RevertToPreviousState()
	{
	}

	public bool IsInState(State<T> state)
	{
		return false;
	}

	public bool IsPreState(State<T> state)
	{
		return false;
	}
}
