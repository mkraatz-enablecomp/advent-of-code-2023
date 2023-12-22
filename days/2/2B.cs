namespace advent_of_code_2023.days;

public class _2B : DayBase
{
	public _2B()
		: base("days/2/data.txt") { }

	public override int Run()
	{
		int result = 0;

		foreach (string line in Input)
		{
			int blueMax = 0;
			int greenMax = 0;
			int redMax = 0;

			var splitLine = line.Split(":");
			int gameNumber = int.Parse(splitLine.First()[5..]);
			var handPulls = splitLine.Last().Split(";");

			foreach (var pull in handPulls)
			{
				var diceGroups = pull.Split(",");
				foreach (var group in diceGroups)
				{
					var groupSplit = group.Trim().Split(" ");
					var diceNumber = int.Parse(groupSplit.First());
					var diceColor = groupSplit.Last();

					switch (diceColor)
					{
						case "blue":
							if (diceNumber > blueMax)
							{
								blueMax = diceNumber;
							}
							break;
						case "green":
							if (diceNumber > greenMax)
							{
								greenMax = diceNumber;
							}
							break;
						case "red":
							if (diceNumber > redMax)
							{
								redMax = diceNumber;
							}
							break;
						default:
							break;
					}
				}
			}
			result += blueMax * greenMax * redMax;
		}

		return result;
	}
}
