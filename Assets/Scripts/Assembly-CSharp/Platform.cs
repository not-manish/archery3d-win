using System;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
	private static Platform _instance;

	private static string AppName;

	public static string[] notification;

	public const string Video_NEED_HIGH_VERSION = "Sorry, there aren't any videos available right now. Please try again later!";

	public static string country;

	public static string uuid;

	public static string CLIENT_VERSION;

	public ThirdPlatformUserItem facebookUserItem;

	public static AndroidJavaClass jc;

	public static AndroidJavaObject getJc;

	public static AndroidJavaObject currentActivity;

	public static int AndroidSDKVersion;

	public static int MIN_ANDROID_SDK_VERSION;

	public static int CURRENT_ABVERSION_TYPE;

	public static int FACEBOOK_MIN_ANDROID_SDK_VERSION;

	public static int HTTPS_DOWNLOAD_MIN_SDK_VERSION;

	private Action<List<ThirdPlatformUserItem>> faceBookGetFriendsCallBack;

	private Action<string, string, string> faceBookLinkCallBack;

	private Action<bool> _onFacebookLogout;

	private static int versionType;

	public static bool hasUnconsumedVideo;

	public static Action<bool> PlayVideoCallBack;

	public static Platform Instance()
	{
		return null;
	}

	private void Awake()
	{
	}

	public static void Init()
	{
	}

	public static int GetAndroidSdkVersion()
	{
		return 0;
	}

	public static string GetCountry()
	{
		return null;
	}

	public static string GetUUID()
	{
		return null;
	}

	public static void Vibrate(long[] pattern, int repeat)
	{
	}

	public static void Vibrate(float seconds)
	{
	}

	public static bool CanFacebook()
	{
		return false;
	}

	public static void GetClientPlatomVersion()
	{
	}

	public static string GetClientVersion()
	{
		return null;
	}

	public static void UpdateVersion()
	{
	}

	public static void Rating()
	{
	}

	public static void ShowQuitHints()
	{
	}

	public static float GetCameraViewportSH()
	{
		return 0f;
	}

	public void GetFacebookFriends(Action<List<ThirdPlatformUserItem>> CallBack)
	{
	}

	public bool isFaceBookToken()
	{
		return false;
	}

	public void Callback_GetFacebookFriends(string jsonStr)
	{
	}

	public void InviteFacebookFriends()
	{
	}

	public static void FacebookShare(int id, string title, string dsp, string addDsp)
	{
	}

	public void FacebookLink(Action<string, string, string> callBack)
	{
	}

	public void Callback_FacebookLink(string jsonStr)
	{
	}

	public void FacebookLogout(Action<bool> onFacebookLogout)
	{
	}

	public void Callback_FacebookLogout(string jsonStr)
	{
	}

	public static int GetCurrentVersionType()
	{
		return 0;
	}

	public static int GetVersionType()
	{
		return 0;
	}

	public string fbNamecheck(string _name)
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public void HideFakeLoading()
	{
	}

	public static void SetNotification()
	{
	}

	public static void SetNotificationDay(long startTime, string titleText, int notificationType, ref int dailyDay, ref int ChallengeDay)
	{
	}

	public static void NotifyMsg(int notifyId, long time, string titleText, string contentText)
	{
	}

	public static void CancelAllNotifyMsg()
	{
	}

	public static bool isVideoAvailable(bool isRoulette = false)
	{
		return false;
	}

	public void playVideo(Action<bool> playVideoCallBack)
	{
	}

	public void OnVideoPlayFinished()
	{
	}

	public void onVideoPlaySkiped()
	{
	}

	public static void ConsumeVideoReward()
	{
	}

	public static bool PlayUnityVideoIsVersionValid()
	{
		return false;
	}

	public static bool CanPlayUnityVideo()
	{
		return false;
	}

	public static bool IsVersionValid_PlayVideo()
	{
		return false;
	}

	public static void FlurryLogEvent(int type, int value)
	{
	}

	public static void FlurryLogEvent(string category, string type, string value)
	{
	}

	public static void CreateBilling(string skuArray)
	{
	}

	public static void Billing(string sku)
	{
	}

	public static void CheckHasPurchaseNeedCertify()
	{
	}

	public static void PurchaseCertifySucess(string sku)
	{
	}

	public void Callback_CertifyPurchase(string purchaseStr)
	{
	}
}
