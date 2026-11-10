using UnityEngine;

public class UI_Setting_Toggle : MonoBehaviour
{
	public UISprite sShowBtn;

	public UISprite sBackGround;

	public bool isOn;

	public float MaxValue;

	public float MinValue;

	public Transform nowShowBtnPosition;

	private SettingData settingData;

	public SystemSettingType settingType;

	public void Show()
	{
	}

	public void UpdateState()
	{
	}

	public void SetShowBtnValue(SystemSettingType _settingType, bool _isOn, bool isChange = true)
	{
	}

	public void SettingValueChange(SystemSettingType _settingType)
	{
	}

	private float GetMaxPositionx()
	{
		return 0f;
	}

	private float GetMinPositionx()
	{
		return 0f;
	}
}
