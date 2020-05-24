using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        var output = new StringBuilder();

        while (takeDown > 0)
        {
            if (startBottles > 1)
            {
                var ending = startBottles - 1 > 1 ? "s" : "";
                output.Append(startBottles)
                    .Append(" bottles of beer on the wall, ")
                    .Append(startBottles)
                    .Append(" bottles of beer.\n")
                    .Append("Take one down and pass it around, ")
                    .Append(startBottles - 1)
                    .Append(" bottle")
                    .Append(ending)
                    .Append(" of beer on the wall.");
            }
            else if (startBottles == 1)
            {
                output.Append("1 bottle of beer on the wall, 1 bottle of beer.\n");
                output.Append("Take it down and pass it around, no more bottles of beer on the wall.");
            }
            else if (startBottles == 0)
            {
                output.Append("No more bottles of beer on the wall, no more bottles of beer.\n");
                output.Append("Go to the store and buy some more, 99 bottles of beer on the wall.");
            }

            startBottles--;
            takeDown--;

            if (takeDown > 0)
            {
                output.Append("\n\n");
            }
        }

        return output.ToString();
    }
}