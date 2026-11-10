using System;
using UnityEngine;

public class DebuggerUtil : MonoBehaviour
{
	public enum DebugLevel
	{
		ALL = 0,
		DEBUG = 1,
		INFO = 2,
		WARN = 3,
		EXCEPTION = 4,
		ERROR = 5,
		FATAL = 6,
		OFF = 100
	}

	public static DebugLevel DEBUG_LEVEL;

	public static void Log(object message)
	{
	}

	public static void Log(object message, UnityEngine.Object context)
	{
	}

	public static void LogInfo(object message)
	{
	}

	public static void LogInfo(object message, UnityEngine.Object context)
	{
	}

	public static void LogWarning(object message)
	{
	}

	public static void LogWarning(object message, UnityEngine.Object context)
	{
	}

	public static void LogException(Exception exception)
	{
	}

	public static void LogException(Exception exception, UnityEngine.Object context)
	{
	}

	public static void LogError(object message)
	{
	}

	public static void LogError(object message, UnityEngine.Object context)
	{
	}

	public static void LogFatal(object message)
	{
	}

	public static void LogFatal(object message, UnityEngine.Object context)
	{
	}
}
