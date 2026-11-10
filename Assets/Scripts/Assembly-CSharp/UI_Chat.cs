using System.Collections.Generic;
using UnityEngine;

public class UI_Chat : MonoBehaviour
{
	private enum chatType
	{
		chat_text = 0,
		chat_emoji = 1
	}

	private enum chatPosition
	{
		left = 0,
		right = 1
	}

	public UIButton btChat;

	public UIButton btIsShowChat;

	public UISprite sSelectShowChat;

	public UISprite sSelectImage;

	private float SelectImageX;

	private float NotSelectImageX;

	public UI_AnimationCtrl ShowChatAnim;

	public List<UIButton> btExpressions;

	public GameObject objExpression;

	public UI_AnimationCtrl aniLeftTalk;

	public UISprite sLeftTalk;

	public UISprite sLeftChatBg;

	public UILabel lLeftText;

	public UILabel lLeftTextBg;

	public UI_AnimationCtrl aniRightTalk;

	public UISprite sRightTalk;

	public UISprite sRightChatBg;

	public UILabel lRightText;

	public UILabel lRightTextBg;

	private bool isShowChat;

	private Vector2 Chat_textSize;

	private float Chat_textX;

	private Vector2 Chat_emojiSize;

	private float Chat_emojiX;

	private bool buttonEnable;

	public void Show()
	{
	}

	private void Update()
	{
	}

	public void HideAnim()
	{
	}

	public void Hide()
	{
	}

	public void HideChatButton(bool isShow)
	{
	}

	private void Start()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool isShowChatImage()
	{
		return false;
	}

	public void SetShowChatImage(bool isShow)
	{
	}

	public void HandleChatResopnse(int chatId, bool isMySelf)
	{
	}

	private void SetChatBgValue(chatType _chatType, chatPosition _chatPosition)
	{
	}
}
