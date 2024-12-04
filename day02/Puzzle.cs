namespace aoc;

public static class Puzzle
{
    public static int GetSolutionPart1(IEnumerable<string> input)
    {
        var safeRows = 0;
        foreach (var row in input)
        {
            var report = row
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            if (report[0] == report[1]) continue;

            var increasing = report[0] < report[1];

            var safe = true;
            for (int i = 1; i < report.Count; i++)
            {
                if (Math.Abs(report[i] - report[i - 1]) > 3) // to big a change
                {
                    safe = false;
                    break;
                }

                if (report[i] > report[i - 1]) // increasing
                {
                    if (!increasing)
                    {
                        safe = false;
                        break;
                    }
                }
                else if (report[i] < report[i - 1]) // decreasing
                {
                    if (increasing)
                    {
                        safe = false;
                        break;
                    }
                }
                else
                {
                    safe = false;
                    break; // equal
                }
            }
            if (safe)
            {
                safeRows += 1;
            }
        }

        return safeRows;
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