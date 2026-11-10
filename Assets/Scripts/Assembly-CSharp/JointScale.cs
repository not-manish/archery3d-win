using System.Collections.Generic;
using UnityEngine;

public class JointScale : MonoBehaviour
{
	private List<Joint> _joint;

	private Rigidbody[] _connectBodys;

	private Vector3[] _anchor;

	private Vector3[] _connectedAnchor;

	public float old_scale;

	public float new_scale;

	public float mLocalScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Start()
	{
	}
}
