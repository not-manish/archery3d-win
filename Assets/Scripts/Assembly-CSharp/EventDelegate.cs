using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[Serializable]
public class EventDelegate
{
	[Serializable]
	public class Parameter
	{
		public UnityEngine.Object obj;

		public string field;

		[NonSerialized]
		public Type expectedType;

		[NonSerialized]
		public bool cached;

		[NonSerialized]
		public PropertyInfo propInfo;

		[NonSerialized]
		public FieldInfo fieldInfo;

		public object value => null;

		public Type type => null;

		public Parameter()
		{
		}

		public Parameter(UnityEngine.Object obj, string field)
		{
		}
	}

	public delegate void Callback();

	[SerializeField]
	private MonoBehaviour mTarget;

	[SerializeField]
	private string mMethodName;

	[SerializeField]
	private Parameter[] mParameters;

	public bool oneShot;

	private Callback mCachedCallback;

	private bool mRawDelegate;

	private bool mCached;

	private MethodInfo mMethod;

	private object[] mArgs;

	private static int s_Hash;

	public MonoBehaviour target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string methodName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Parameter[] parameters => null;

	public bool isValid => false;

	public bool isEnabled => false;

	public EventDelegate()
	{
	}

	public EventDelegate(Callback call)
	{
	}

	public EventDelegate(MonoBehaviour target, string methodName)
	{
	}

	private static string GetMethodName(Callback callback)
	{
		return null;
	}

	private static bool IsValid(Callback callback)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	private void Set(Callback call)
	{
	}

	public void Set(MonoBehaviour target, string methodName)
	{
	}

	private void Cache()
	{
	}

	public bool Execute()
	{
		return false;
	}

	public void Clear()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static void Execute(List<EventDelegate> list)
	{
	}

	public static bool IsValid(List<EventDelegate> list)
	{
		return false;
	}

	public static void Set(List<EventDelegate> list, Callback callback)
	{
	}

	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
	}

	public static void Add(List<EventDelegate> list, Callback callback)
	{
	}

	public static void Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
	}

	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
	}

	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
	}

	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		return false;
	}

	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		return false;
	}
}
