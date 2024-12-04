namespace aoc;

public static class Puzzle
{
    public static int GetSolutionPart1(IEnumerable<string> input)
    {
        var firstList = new List<int>();
        var secondList = new List<int>();
        foreach (var line in input)
        {
            var values = line.Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries);
            firstList.Add(int.Parse(values[0]));
            secondList.Add(int.Parse(values[1]));
        }
        firstList.Sort();
        secondList.Sort();

        var result = 0;
        for (var i = 0; i < firstList.Count; i++)
        {
            result += Math.Abs(firstList[i] - secondList[i]);
        }
        return result;
    }

    public static int GetSolutionPart2(IEnumerable<string> input)
    {
        var firstList = new List<int>();
        var secondListDict = new Dictionary<int, int>();
        foreach (var line in input)
        {
            var values = line.Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries);
            firstList.Add(int.Parse(values[0]));
            var secondValue = int.Parse(values[1]);
            if (secondListDict.ContainsKey(secondValue))
            {
                secondListDict[secondValue]++;
            }
            else
            {
                secondListDict.Add(secondValue, 1);
            }
        }

        var result = 0;
        for (int i = 0; i < firstList.Count; i++)
        {
            if (secondListDict.ContainsKey(firstList[i]))
            {
                result += firstList[i] * secondListDict[firstList[i]];
            }
        }

        return result;
    }
}