using com.simple.proto;

public class Account
{
	public string social_google_id;

	public string social_facebook_id;

	public string mail_addr;

	public string phone_no;

	public string social_apple_id;

	public void Update(CCUserAccount account)
	{
	}

	public void ClearInfo()
	{
	}

	public static string GetRealSocialId(string pSID)
	{
		return null;
	}

	public bool IsBindFB()
	{
		return false;
	}

	public static bool IsFinishBind(string type)
	{
		return false;
	}

	public bool IsGuest()
	{
		return false;
	}

	public bool IsNotLinkAccount()
	{
		return false;
	}

	public bool IsSameFB(string fbId)
	{
		return false;
	}

	public bool IsSameEmail(string email)
	{
		return false;
	}

	public bool IsSamePhone(string regionCode, string phoneNo)
	{
		return false;
	}
}
