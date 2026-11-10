using System.Collections.Generic;

public class ChallengeChestOriData
{
	public int chest_id;

	public string name;

	public int chest_kind;

	public int gold;

	public int gem;

	public int sum_cards;

	public int blue_card_kind_min;

	public int blue_card_kind_max;

	public int purple_card_count;

	public int purple_card_kind_min;

	public int purple_card_kind_max;

	public int orange_card_count;

	public int orange_card_kind_min;

	public int orange_card_kind_max;

	public List<int> arrow_kinds;

	public List<int> arrow_count;

	public int grade;

	public int MaxGrade()
	{
		return 0;
	}
}
