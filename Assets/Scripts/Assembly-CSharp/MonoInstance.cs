using UnityEngine;

public class MonoInstance<T> : MonoBehaviour where T : MonoInstance<T>
{
	public static T instance;

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}
}
