using UnityEngine;
using com.simple.proto;

public class UI_RankLeaguePopup_Promotion_Item : MonoBehaviour
{
	public UISprite sChestIconBack;

	public GameObject oLeagueChest;

	public UIButton btChest;

	public UIButton btItem;

	public UISprite sBacground;

	public PlayerHeadShow sPlayerPhoto;

	public UILabel lRank;

	public UILabel lRankbg;

	public UILabel lPlayerName;

	public UILabel lPlayerGold;

	private UI_RankLeaguePopup_Promotion uiLeagueRank;

	public UI_AnimationCtrl UpBigAnim;

	public UI_AnimationCtrl UpOrDownAnim;

	public UI_AnimationCtrl ChangeBigAnim;

	public TweenPosition MoveAnim;

	private bool isMe;

	private CCRankItem rankItem;

	private int rank;

	private bool hasUpdate;

	private bool buttonEnable;

	public void UpdateState(UI_RankLeaguePopup_Promotion _uiLeagueRank, int _rank, CCRankItem _rankItem, bool _isMe)
	{
	}

	public void Hide()
	{
	}

	private string GoldToStringK(long gold)
	{
		return null;
	}

	public void UpdatePhoto()
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

	public void PlayMoveAnim(bool isPlayBigAnim = false)
	{
	}

	public void PlayMoveAnimEnd()
	{
	}

	public void PlayBigAnim()
	{
	}

	public void PlayBigAnimEnd()
	{
	}

	public void SetMoveAnimValue(Vector3 From, Vector3 To, float delayTime = -1f, float MoveTime = -1f, UITweener.Style moveType = UITweener.Style.Once)
	{
	}
}
