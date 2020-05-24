using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> _highScores;

    public HighScores(List<int> list) => _highScores = list;

    public List<int> Scores() => _highScores;

    public int Latest() => _highScores.LastOrDefault();

    public int PersonalBest() => _highScores.Max();

    public List<int> PersonalTopThree()
    {
        const int top = 3;
        return _highScores.OrderByDescending(i => i).Take(top).ToList();
    }
}