namespace advent_of_code_2023;

public abstract class DayBase
{
	public readonly string[] Input;

	public DayBase(string filePath)
	{
		Input = ReadFile(filePath);
	}

	public abstract int Run();

	private string[] ReadFile(string relativePath)
	{
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string absolutePath = Path.Combine(baseDirectory, relativePath);

		if (File.Exists(absolutePath))
		{
			return File.ReadAllLines(absolutePath);
		}
		else
		{
			throw new FileNotFoundException("The specified file does not exist.");
		}
	}
}
