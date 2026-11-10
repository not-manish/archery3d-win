using System.Collections.Generic;

public class ObjectPool<T> where T : IPoolable, new()
{
	public delegate T Delegate_NewObject();

	public delegate T Delegate_NewObject_ById(int id);

	private int initSize;

	private int addSize;

	private List<T> objects;

	private List<T> usedObjects;

	public Delegate_NewObject NewObject;

	private int id;

	public Delegate_NewObject_ById NewObjectById;

	public ObjectPool(int initSize, int addSize)
	{
	}

	public void Init(int id)
	{
	}

	public void Init()
	{
	}

	private void InitSize(int size)
	{
	}

	public T Obtain()
	{
		return default;
	}

	public int FreeSize()
	{
		return 0;
	}

	public int UsedSize()
	{
		return 0;
	}

	public void Free(T t)
	{
	}

	public void DestoryAll()
	{
	}

	public void ResetAll()
	{
	}

	public void FreeAll()
	{
	}
}
