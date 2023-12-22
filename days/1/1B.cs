using System.Text.RegularExpressions;

namespace advent_of_code_2023.days;

// TODO: read input string and replace "one" with "one1one", "two" with "two2two", etc.
// 		 then just look at the numbers
public class _1B : DayBase
{
	public _1B()
		: base("days/1/data.txt") { }

	public override int Run()
	{
		int result = 0;

		foreach (var line in Input)
		{
			var newLine = line.Replace("one", "one1one")
				.Replace("two", "two2two")
				.Replace("three", "three3three")
				.Replace("four", "four4four")
				.Replace("five", "five5five")
				.Replace("six", "six6six")
				.Replace("seven", "seven7seven")
				.Replace("eight", "eight8eight")
				.Replace("nine", "nine9nine");

			char firstNumber = newLine.First(c => int.TryParse(c.ToString(), out int _));
			char lastNumber = newLine.Last(c => int.TryParse(c.ToString(), out int _));

			var numberString = string.Join("", [firstNumber.ToString(), lastNumber.ToString()]);
			result += int.Parse(numberString);
		}

		return result;
	}
}
