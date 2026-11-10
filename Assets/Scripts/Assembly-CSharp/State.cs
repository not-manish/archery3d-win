public abstract class State<T>
{
	public virtual void Enter(T owner)
	{
	}

	public virtual void Exit(T owner)
	{
	}

	public virtual void Execute(T owner)
	{
	}

	public virtual bool OnMessage(T owner, Telegram telegram)
	{
		return false;
	}
}
