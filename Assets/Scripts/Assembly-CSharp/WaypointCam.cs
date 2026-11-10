using UnityEngine;

public class WaypointCam : MonoBehaviour
{
	public Color WaypointsColor;

	public bool draw;

	public static Transform[] waypoints;

	private void Awake()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
