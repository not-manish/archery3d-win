using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Event Trigger")]
public class UIEventTrigger : MonoBehaviour
{
	public static UIEventTrigger current;

	public List<EventDelegate> onHoverOver;

	public List<EventDelegate> onHoverOut;

	public List<EventDelegate> onPress;

	public List<EventDelegate> onRelease;

	public List<EventDelegate> onSelect;

	public List<EventDelegate> onDeselect;

	public List<EventDelegate> onClick;

	public List<EventDelegate> onDoubleClick;

	public List<EventDelegate> onDragOver;

	public List<EventDelegate> onDragOut;

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnSelect(bool selected)
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnDragOver(GameObject go)
	{
	}

	private void OnDragOut(GameObject go)
	{
	}
}
