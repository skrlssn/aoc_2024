using Xunit;

namespace aoc;

public class PuzzleTests
{
    [Fact]
    public void GetSolutionPart1_ReturnsAddedNumbers()
    {
        var foo = new List<string>() {
            "3", "1", "2", "3", "4", "5", "6"
        };

        Puzzle.GetSolutionPart1(foo);
    }

    [Fact]
    public void GetSolutionPart2_ReturnsMultipliedNumbers()
    {
        throw new NotImplementedException();
    }
}