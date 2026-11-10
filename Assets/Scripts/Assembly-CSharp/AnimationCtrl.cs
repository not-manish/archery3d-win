using System.Collections.Generic;
using UnityEngine;

public class AnimationCtrl : MonoBehaviour
{
	public static Dictionary<AnimationType, string> AnimationNames;

	[HideInInspector]
	private Player player;

	[HideInInspector]
	public GameObject charactorHolder;

	private AnimationType currentAnimationType;

	private AnimationType currentAnimationTypeLayer1;

	private List<AnimationType> aniPlayBackList;

	private static bool initAniName;

	private int MoveLayer;

	private bool enableWeightRectify;

	private bool weightRectify;

	private List<AnimationType> playingPreAnimation;

	private AnimationState curAniState;

	private bool IsPlayingLayer0;

	private bool IsPlayingLayer1;

	public static void InitAnimationName()
	{
	}

	public void InitAnmation(Player _player, GameObject model, ModelType modelType)
	{
	}

	private void AddAnimationClip(ModelType modelType)
	{
	}

	private void SetMixAnimation(ModelType modelType)
	{
	}

	private void SetAnimationLayer(ModelType modelType)
	{
	}

	private void SetAnimationWrapMode(ModelType modelType)
	{
	}

	private void AddAnimationEvent(ModelType modelType)
	{
	}

	public void StopAnimationLayer1()
	{
	}

	public void StopAnimationLayer0()
	{
	}

	private void Update()
	{
	}

	public void PlayAnimation(float speed, AnimationType animationType, bool enableWeight = true)
	{
	}

	public void PlayAnimation(float speed, AnimationType animationType, float weight, bool enableWeight = true)
	{
	}

	public void PlayAnimation(float speed, float crossFadeTime, AnimationType animationType, bool enableWeight = true)
	{
	}

	public void PlayAnimation(float speed, float crossFadeTime, AnimationType animationType, float weight, bool enableWeight = true)
	{
	}

	private void PlayAnimationFinal(float speed, float crossFadeTime, AnimationType animationType, float weight, bool enableWeight = true)
	{
	}

	public bool IsAnimationFinish(AnimationType animationType, float time)
	{
		return false;
	}

	public bool IsAnimationFinishBack(AnimationType animationType, float time)
	{
		return false;
	}

	public float GetAnimationSpeed(AnimationType animType)
	{
		return 0f;
	}

	public void SetCurrentAnimationSpeed(AnimationType animType, float speed)
	{
	}

	public void SetCurrentAnimationNormalizedTime(AnimationType animType, float normalizeTime)
	{
	}

	public float GetCurrentAnimationNormalizedTime(AnimationType animType)
	{
		return 0f;
	}

	public float GetCurrentAnimationLengthTime(AnimationType animType)
	{
		return 0f;
	}

	public float GetAnimationTime(AnimationType animationType)
	{
		return 0f;
	}

	public AnimationType GetCurrentAnimationType()
	{
		return AnimationType.Null;
	}

	public AnimationType GetCurrentAnimationTypeLayer1()
	{
		return AnimationType.Null;
	}

	public bool IsPlaying(AnimationType animationType)
	{
		return false;
	}

	public void StopAllAnimation()
	{
	}

	public void StoreAnimationState()
	{
	}

	public void RecoverAnimation()
	{
	}
}
