using System;

public class UITopMoneyParam
{
	public bool shouldShowAnim;

	public bool showPlayerInfo;

	public Action<ButtonType> buttonClicked;

	public UITopMoneyParam(bool _showPlayerInfo, Action<ButtonType> _buttonClicked, bool _shouldShowAnim = true)
	{
	}
}
