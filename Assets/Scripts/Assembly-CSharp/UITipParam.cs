public class UITipParam
{
	public TipsType tipsType;

	public TipTitleType titleType;

	public TipButtonType buttonType;

	public string titleName;

	public string tipsTxt;

	public string codeTxt;

	public MoveToPosition moveToPosition;

	public UITipParam(TipTitleType _titleType, TipButtonType _buttonType, string _tipsTxt, string _codeTxt = "")
	{
	}

	public UITipParam(string _titleName, TipButtonType _buttonType, string contentTxt)
	{
	}

	public UITipParam(TipTitleType _titleType, TipButtonType _buttonType, TipsType _tipsType, MoveToPosition _moveToPosition = null)
	{
	}
}
