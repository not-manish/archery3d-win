using UnityEngine;

public class UI_Offline_Heart_Recover : MonoBehaviour
{
	public UILabel lHeartTime;

	private LevelSingleHeartRealtimeData chestSingleData;

	public UI_OfflineLevel_LevelChoose uiParent;

	private bool isfirstenter;

	private float time;

	public void Show(UI_OfflineLevel_LevelChoose _uiParent)
	{
	}

	private void Update()
	{
	}

	public void UpdateState()
	{
	}

	public void Hide()
	{
	}

	public bool islHeartTimeActive()
	{
		return false;
	}
}
