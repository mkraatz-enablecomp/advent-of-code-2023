// See https://aka.ms/new-console-template for more information
using System.Reflection;
using advent_of_code_2023;

Console.WriteLine("Hello, World!");

string targetNamespace = "advent_of_code_2023.days"; // Replace with your target namespace
var classesInNamespace = Assembly
	.GetExecutingAssembly()
	.GetTypes()
	.Where(t => t.Namespace == targetNamespace && t.IsClass && t.IsSubclassOf(typeof(DayBase)));

var classToRun = classesInNamespace.OrderByDescending(c => c.Name).First();

// Create an instance of the class
var instance = Activator.CreateInstance(classToRun) as DayBase;

// Call the Run() method on the instance
if (instance != null)
{
	Console.WriteLine("Running {0}", new { classToRun.Name });
	var result = instance.Run();
	Console.WriteLine("Answer: {0}", new { result });
}
