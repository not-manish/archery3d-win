using System.Collections.Generic;

public class EntityManager
{
	private static EntityManager instance;

	private Dictionary<int, BaseEntity> m_EntityMap;

	private EntityManager()
	{
	}

	public static EntityManager GetInstance()
	{
		return null;
	}

	public void RegisterEntity(BaseEntity NewEntity)
	{
	}

	public BaseEntity GetEntityFromID(int id)
	{
		return null;
	}

	public void RemoveEntity(BaseEntity pEntity)
	{
	}

	public void Reset()
	{
	}

	public Dictionary<int, BaseEntity>.ValueCollection GetAllEntity()
	{
		return null;
	}

	public void ClearAllEntity()
	{
	}
}
