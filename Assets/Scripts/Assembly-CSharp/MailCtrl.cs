public class MailCtrl
{
	public enum MailType
	{
		AnnouncementMail = 0,
		ConditionMail = 1,
		FriendsMail = 2,
		RewardsMail = 3
	}

	public enum MailState
	{
		Unread = 0,
		ReadUnreward = 1,
		ReadRewarded = 2,
		Delete = 3
	}

	public enum MailHandleType
	{
		Read = 0,
		Reward = 1,
		Delete = 2
	}
}
