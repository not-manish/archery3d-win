using com.simple.proto;

public class ThirdAccountInfo
{
	private static int getThirdTokenErrCode;

	private static int errLinkAccountCode;

	private static CCUserAccount toRecoverActWindowUserAccount;

	private static CCPlayer toRecoverActWindowSUserData;

	private static int recoverActErrCode;

	public static void SyncGetThirdTokenResponse(CCGetThirdTokenResponse resp)
	{
	}

	private static void SyncBindThirdAccountGetTokenOK(CCGetThirdTokenResponse resp)
	{
	}

	private static void SyncRestoreAccountGetTokenOK(CCGetThirdTokenResponse resp)
	{
	}

	public static void Handle_GetThirdTokenError(int resultCode, CCThirdAccountItem Item)
	{
	}

	private static void ShowGetThirdTokenError(CCThirdAccountItem Item)
	{
	}

	public static void SyncLinkThirdAccountResp(CCLinkThirdAccountResponse resp)
	{
	}

	public static void ToChangeUserNameWindow()
	{
	}

	public static void Handle_LinkThirdAccountNotOK(int resultCode, CCThirdAccountItem item)
	{
	}

	private static void ToLinkAccountErrorWindow(CCThirdAccountItem item)
	{
	}

	public static void SyncRestoreAccountResponse(CCRestoreAccountResponse resp)
	{
	}

	public static void Handle_RestoreAccountNotOK(int resultCode, CCThirdAccountItem item)
	{
	}

	private static void ToRecoverActErrorWindow(CCThirdAccountItem item)
	{
	}
}
