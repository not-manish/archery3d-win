using System.Collections.Generic;
using UnityEngine;

public class BowEffectCtrl : MonoBehaviour
{
	[SerializeField]
	private bool hasEffectBow;

	public ArrowEffect effectParent;

	public List<Material> normalMaterials;

	public List<MeshRenderer> normalMeshRender;

	public List<Material> effectMaterials;

	public void SetBowShowType(BowEffectType bowEffect)
	{
	}

	public static void SetBowShowTypeGlobal(GameObject bowCtrl, BowEffectType bowEffect)
	{
	}
}
