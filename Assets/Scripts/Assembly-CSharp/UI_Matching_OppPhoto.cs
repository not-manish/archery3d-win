using UnityEngine;

public class UI_Matching_OppPhoto : MonoBehaviour
{
	public Texture2D defaultTex;

	public GameObject oFriendParent;

	public GameObject oNormalParent;

	public UITexture texFriendTex;

	public PlayerHeadShow hFriendHead;

	public SpringContenSc spritNormalScroll;

	public void Show(bool isScroll)
	{
	}

	public void Hide()
	{
	}

	private void FinishSpringCallBack()
	{
	}

	public void CheckFriendUid(string uid)
	{
	}

	public void SetFriendDownload(string uid, string facebookId, bool hide_facebook_head)
	{
	}

	public void SetNormalDownload()
	{
	}

	public void DownloadAvatarCallback(string uid, string fbId, Texture2D avatar)
	{
	}
}
