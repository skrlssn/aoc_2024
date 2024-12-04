using aoc;

var input = File.ReadLines("input.txt");

var part = Environment.GetEnvironmentVariable("part");
// var part = "part1";
// var part = "part2";

var solution = part switch
{
    "part1" => Puzzle.GetSolutionPart1(input),
    "part2" => Puzzle.GetSolutionPart2(input),
    _ => throw new ArgumentOutOfRangeException(nameof(part), $"Unexpected {nameof(part)} value: '{part}'")
};

Console.WriteLine(solution);