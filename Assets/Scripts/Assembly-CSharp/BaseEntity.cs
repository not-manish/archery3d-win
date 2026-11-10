public class BaseEntity
{
	private int m_ID;

	private static int m_iNextValidID;

	private void SetID(int val)
	{
	}

	public BaseEntity()
	{
	}

	public BaseEntity(int id)
	{
	}

	public virtual bool HandleMessage(Telegram telegram)
	{
		return false;
	}

	public static int GetNextValidID()
	{
		return 0;
	}

	public static void ResstNextValidID()
	{
	}

	public int ID()
	{
		return 0;
	}

	public virtual object GetParent()
	{
		return null;
	}
}
