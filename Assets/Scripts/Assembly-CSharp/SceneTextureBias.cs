using UnityEngine;

public class SceneTextureBias : MonoBehaviour
{
	[Header("Settings")]
	[Tooltip("A positive bias makes a texture appear extra blurry, while a negative bias sharpens the texture. Note that using large negative bias can reduce performance, so it's not recommended to use more than -0.5 negative bias.)")]
	public float _target;

	[Header("References")]
	public Texture[] _texturesToAdjust;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
