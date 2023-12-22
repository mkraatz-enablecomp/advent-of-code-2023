namespace advent_of_code_2023.days;

public class _2A : DayBase
{
	public _2A()
		: base("days/2/data.txt") { }

	public override int Run()
	{
		int result = 0;

		foreach (string line in Input)
		{
			bool possibleGame = true;
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
							if (diceNumber > 14)
							{
								possibleGame = false;
							}
							break;
						case "green":
							if (diceNumber > 13)
							{
								possibleGame = false;
							}
							break;
						case "red":
							if (diceNumber > 12)
							{
								possibleGame = false;
							}
							break;
						default:
							break;
					}
				}
			}
			if (possibleGame)
			{
				result += gameNumber;
			}
		}

		return result;
	}
}
