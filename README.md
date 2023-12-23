# Advent of Code 2023

> My solutions to this year's Advent of Code challenges. For fun only!

[Advent of Code Website](https://adventofcode.com/2023)

## How to Run

Each folder in `/days` requires a file named `data.txt` that is your unique puzzle input. Log in to Advent of Code to retrieve your puzzle input and paste it in this file

In `Program.cs` this application uses reflection to identify the _latest_ puzzle set. Since I've been completing these puzzles sequentially, it's convenient to only run the highest possible puzzle

If you'd like to run a specific puzzle:

1. Comment out the code in `Program.cs`
1. Construct the class of the day/part you'd like to run
1. Call `.Run()` on the instantiated class

## Starting a new Puzzle

Each day/part should inherit from `DayBase` and pass a relative path to the appropriate `data.txt` puzzle input for that day. `DayBase` provides an `Input` property that is the collection of lines from your puzzle input. Each day/part must implement `Run()` to return an integer puzzle solution

## Extensions We <3

- [CSharpier](https://csharpier.com/) Opinionated Code Formatting
- [C# Dev Kit](https://learn.microsoft.com/en-us/visualstudio/subscriptions/vs-c-sharp-dev-kit) C# Productivity Tools for VS Code
