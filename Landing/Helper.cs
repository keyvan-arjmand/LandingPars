namespace Landing;

public static class Helper
{
    public static string ToStringList(this List<string> o)
    {
        string word = string.Empty;
        int index = 0;
        foreach (var i in o)
        {
            if (index != o.Count)
            {
                word += i + ",";

            }
            else
            {
                word += i ;

            }

            index++;
        }

        return word;
    }
}