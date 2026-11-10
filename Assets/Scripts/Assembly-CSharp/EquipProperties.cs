using UnityEngine;

public class EquipProperties
{
	public static int RANGE_MAX;

	public int range;

	public int range_add_percent;

	public static int ACCURACY_MAX;

	public int accuracy;

	public int accuracy_add_percent;

	public static int ARROW_SPEED_MAX;

	public int arrow_speed;

	public int arrow_speed_add_percent;

	public static int STAMINA_MAX;

	public int stamina;

	public int stamina_add_percent;

	public static int STABILITY_MAX;

	public int stability;

	public int stability_add_percent;

	public static int ZOOM_IN_MAX;

	public int zoom_in;

	public int zoom_in_add_percent;

	public static int AIMING_SPEED_MAX;

	public int aiming_speed;

	public int aiming_speed_add_percent;

	public int win_bonus;

	public int win_bonus_add_percent;

	public int lose_bonus;

	public int lose_bonus_add_percent;

	public int resist_wind;

	public int resist_wind_add_percent;

	public void ClearAllData()
	{
	}

	public static float GetProgress(EquipPropertiesType type, int value, bool isPrecent = false, bool isArrows = false)
	{
		return 0f;
	}

	private static float GetProgress(int CurNum, int MaxNum)
	{
		return 0f;
	}

	public static float GetRangeReal(int RangeConfig)
	{
		return 0f;
	}

	public static float GetAccuracyA(int AccuracyConfig)
	{
		return 0f;
	}

	public static float GetAccuracyB(int AccuracyConfig)
	{
		return 0f;
	}

	public static float GetStaminaStage2Start(int staminaConfig)
	{
		return 0f;
	}

	public static float GetStaminaStage3Start(int staminaConfig)
	{
		return 0f;
	}

	public static float GetStabilityScreenInState1Speed(int stabilityConfig)
	{
		return 0f;
	}

	public static float GetStabilityScreenInState2Speed(int stabilityConfig)
	{
		return 0f;
	}

	public static float GetStabilityScreenInState3Speed(int stabilityConfig)
	{
		return 0f;
	}

	public static float GetPlayerCamZoomInFOV(int zoomInConfig)
	{
		return 0f;
	}

	public static float GetSceneCameZoomInFov(int zoomInConfig)
	{
		return 0f;
	}

	public static Vector3 GetZoomInPos(int zoomInConfig, Vector3 CamAfterPos)
	{
		return default;
	}

	public static Quaternion GetZoomInRot(int zoomInConfig)
	{
		return default;
	}

	public static float GetAimingTime(int aimingSpeed)
	{
		return 0f;
	}

	public int GetRange_Config()
	{
		return 0;
	}

	public int GetAccuracy_Config()
	{
		return 0;
	}

	public int GetArrowSpeed_Config()
	{
		return 0;
	}

	public static float GetArrowSpeed(int arrowConfig)
	{
		return 0f;
	}

	public int GetStamina_Config()
	{
		return 0;
	}

	public int GetStability_Config()
	{
		return 0;
	}

	public int GetZoomIn_Config()
	{
		return 0;
	}

	public int GetAimingSpeed_Config()
	{
		return 0;
	}

	public static int GetWinBonusLevel(int value)
	{
		return 0;
	}

	public int GetWinBonusInt()
	{
		return 0;
	}

	public float GetWinBonusFloat()
	{
		return 0f;
	}

	public static int GetLoseBonusLevel(int value)
	{
		return 0;
	}

	public int GetLoseBonusInt()
	{
		return 0;
	}

	public float GetLoseBonusFloat()
	{
		return 0f;
	}

	public static int GetWindResistLevel(int value)
	{
		return 0;
	}

	public int GetResistWindInt()
	{
		return 0;
	}

	public static float GetResistWindFloat01(int ResistConfig)
	{
		return 0f;
	}

	public static float GetLastWind(float windSpeed, float windResist01)
	{
		return 0f;
	}
}
