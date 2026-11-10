using System;
using System.Collections.Generic;
using UnityEngine;

public static class Localization
{
	public static bool localizationHasBeenSet;

	private static string[] mLanguages;

	private static Dictionary<string, string> mOldDictionary;

	private static Dictionary<string, string[]> mDictionary;

	private static int mLanguageIndex;

	private static string mLanguage;

	public static Dictionary<string, string[]> dictionary
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string[] knownLanguages => null;

	public static string language
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static bool LoadDictionary(string value)
	{
		return false;
	}

	private static bool LoadAndSelect(string value)
	{
		return false;
	}

	public static void Load(TextAsset asset)
	{
	}

	public static bool LoadCSV(TextAsset asset)
	{
		return false;
	}

	private static bool SelectLanguage(string language)
	{
		return false;
	}

	private static void AddCSV(BetterList<string> values)
	{
	}

	public static void Set(string languageName, Dictionary<string, string> dictionary)
	{
	}

	public static string Get(string key)
	{
		return null;
	}

	[Obsolete("Use Localization.Get instead")]
	public static string Localize(string key)
	{
		return null;
	}

	public static bool Exists(string key)
	{
		return false;
	}
}
