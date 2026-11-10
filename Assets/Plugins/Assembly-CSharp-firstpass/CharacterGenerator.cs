using System.Collections.Generic;
using UnityEngine;

public class CharacterGenerator
{
	private static WWW database;

	private static Dictionary<string, Dictionary<string, List<CharacterElement>>> sortedElements;

	private static List<string> availableCharacters;

	private string currentCharacter;

	private Dictionary<string, CharacterElement> currentConfiguration;

	public static bool ReadyToUse => false;

	public bool ConfigReady => false;

	public static string AssetbundleBaseURL => null;

	public static string ResourceBaseURL => null;

	public static string AssetbundleWeaponURL => null;

	private CharacterGenerator()
	{
	}

	public static CharacterGenerator CreateWithConfig(string config)
	{
		return null;
	}

	public void PrepareConfig(string config)
	{
	}

	public string GetConfig()
	{
		return null;
	}

	public void ChangeElement(string catagory, bool next)
	{
	}

	public GameObject Generate()
	{
		return null;
	}

	private GameObject Generate(GameObject root)
	{
		return null;
	}
}
