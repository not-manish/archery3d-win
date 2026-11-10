public class UIMatchParam
{
	public static MatchType matchType;

	public static string friend_uid;

	public static string friend_fid;

	public static string friend_name;

	public static bool hide_facebook_head;

	public bool isRematch;

	public bool isInviter;

	public GameType gameType;

	public UIMatchParam()
	{
	}

	public UIMatchParam(MatchType _matchType, string _friend_uid, string _friend_fid, string _friend_name, bool _isRematch, bool _isInviter, bool _hide_facebook_head = false)
	{
	}
}
