namespace advent_of_code_2023.days;

public class _1A : DayBase
{
	public _1A()
		: base("days/1/data.txt") { }

	public override int Run()
	{
		int result = 0;

		foreach (var line in Input)
		{
			string? firstNumber = null,
				lastNumber = null;
			foreach (var character in line)
			{
				if (int.TryParse(character.ToString(), out int _))
				{
					if (firstNumber == null)
					{
						firstNumber = character.ToString();
					}
					lastNumber = character.ToString();
				}
			}
			var numberString = string.Join("", [firstNumber!, lastNumber!]);
			result += int.Parse(numberString);
		}

		return result;
	}
}
