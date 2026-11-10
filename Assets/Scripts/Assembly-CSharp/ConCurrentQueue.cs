using System.Collections.Generic;

public class ConCurrentQueue<T>
{
	private Queue<T> queue;

	private byte[] lockVal;

	public void Enqueue(T item)
	{
	}

	public T Dequeue()
	{
		return default;
	}

	public T Peek()
	{
		return default;
	}

	public void Clear()
	{
	}

	public int Count()
	{
		return 0;
	}
}
