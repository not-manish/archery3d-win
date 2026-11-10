using System;

public class UIDownButtonParam
{
	public ButtonType buttonType;

	public Action<ButtonType> buttonClicked;

	public UIDownButtonParam(ButtonType _buttonType, Action<ButtonType> _buttonClicked)
	{
	}
}
