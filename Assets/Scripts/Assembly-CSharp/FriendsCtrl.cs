using UnityEngine;
using com.simple.proto;

public class FriendsCtrl : MonoBehaviour
{
	public enum InviteResponseState
	{
		Start_Now = 1,
		After_This = 2,
		Not_Now = 3
	}

	public enum FriendsHandleTypes
	{
		RequestFriendsInfo = 1,
		SendFriendsGifts = 2,
		InvitePlaying = 3,
		AnswerInviting = 4,
		CancelInviting = 5,
		RequestFriendsRank = 6
	}

	public static CCFriendAskInfo GetCCFriendAskInfo(string uid, string fbid, string name)
	{
		return null;
	}
}
