using UnityEngine;

public class UI_GO_Bingo_Score : MonoBehaviour
{
	private UI_GO_Bingo uiBingo;

	private UIGameOverParam uiParam;

	public UI_Bingo_LineScore uiLeftLineScore;

	public UI_Bingo_LineScore uiRightLineScore;

	public GameObject[] myLines;

	public GameObject[] oppLines;

	private bool isSameLineCount;

	public bool IsSameLineCount
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Show(UI_GO_Bingo _uiBingo, UIGameOverParam _uiParam)
	{
	}
}
