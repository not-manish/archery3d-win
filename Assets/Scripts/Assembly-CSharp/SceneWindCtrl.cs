using UnityEngine;

public class SceneWindCtrl : MonoBehaviour
{
	private enum WindDir
	{
		NoWind = 0,
		TowardsLeft = 1,
		TowardsRight = 2
	}

	public GameObject oNoWind;

	public GameObject oWindTowardsLeft;

	public GameObject oWindTowardsRight;

	public Material FengYe_Hong;

	private string ShakeBending;

	private string ShakeDisplacement;

	private string ShakeTime;

	private string ShakeWindspeed;

	private float MaxWinds;

	private float MinWinds;

	private static SceneWindCtrl instance;

	public static SceneWindCtrl Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static void SetSceneWindTowards(float windAngle, float windSpeed)
	{
	}

	private void SetWindDir(WindDir windDir, float windSpeed)
	{
	}

	public void SetWindShow(float value)
	{
	}
}
