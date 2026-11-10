using UnityEngine;

public class ChestOpenAnimCtrl : MonoBehaviour
{
	public GameObject gameObjectEnable;

	[HideInInspector]
	public GameObject equipAllParent;

	public GameObject singleParant;

	private UIChestParam uiParam;

	public ChestEffect chestEffect;

	[HideInInspector]
	public ChestAnim chestAnim;

	[HideInInspector]
	public GameObject oChest;

	private Vector3 coinGemTran;

	public static ChestOpenAnimCtrl instance;

	public Vector3 CoinGemTran
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void Show(UIChestParam _uiParam)
	{
	}

	private void LoadModel(UIChestParam _uiParam)
	{
	}

	public GameObject LoadResource(ChestType uiChestType)
	{
		return null;
	}

	public void Hide()
	{
	}
}
