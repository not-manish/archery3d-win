using AssetUpdate.Util;
using UnityEngine;

public class AvatarNodeSc : MonoBehaviour
{
	public UITexture defaultAvatarTex;

	public UITexture avatarTex;

	public UISprite frameSprite;

	private string showingUid;

	private string showingFbId;

	private int frameDepthAdd;

	public Texture2D NowHeadTexture;

	public bool isCircle;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetFrameDepthAdd(int value)
	{
	}

	private void SetDepth()
	{
	}

	public void SetAvatarTex(Texture2D tex)
	{
	}

	public void UpdateInfo(Account account)
	{
	}

	public void UpdateInfo(UserHeadData sUserData)
	{
	}

	public void BackShowDefaultHead()
	{
	}

	public void ResetData()
	{
	}

	public void HidePlayerTex()
	{
	}

	public void UpdateInfo(string uid, string fbId, bool facebookLinked, bool refresh = true)
	{
	}

	private void ReadLocalFaceBookAvatarCallBack(FileUtil.WWWFileInfo wwwFileInfo)
	{
	}

	private void DownloadAvatarCallback(string uid, string fbId, Texture2D tex)
	{
	}
}
