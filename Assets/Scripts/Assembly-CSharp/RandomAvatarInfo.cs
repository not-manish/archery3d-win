using System.Collections.Generic;
using UnityEngine;

public class RandomAvatarInfo
{
	private static IList<string> socialIdList;

	private static BetterList<Texture2D> avatarTexList;

	private const int max_cnt = 10;

	public static void ClearTex()
	{
	}

	public static void CheckGetRandomAvatar()
	{
	}

	public static void DownloadAvatarCallback(string uid, string fbId, Texture2D avatar)
	{
	}

	public static BetterList<Texture2D> GetAvatarTexList()
	{
		return null;
	}

	public static void Handle_GetRandomSocialIdNotOK()
	{
	}
}
