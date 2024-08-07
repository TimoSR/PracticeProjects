namespace LeetCode.HackerRank.Problem_Solving.DateTime;

public class TimeConversion
{
    // A lot of slicing
    
    public static string timeConversion(string s)
    {
        var prefix = s.Substring(s.Length - 2);
        var time = s.Remove(s.Length - 2);
        var values = time.Split(":");
        var hours = int.Parse(values[0]);
        var minutes = int.Parse(values[1]);
        var seconds = int.Parse(values[2]);

        if (prefix == "AM")
        {
            if (hours == 12)
            {
                hours = 0;
            }
        }

        if (prefix == "PM")
        {
            if (hours != 12)
            {
                hours += 12;
            }
        }

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }
    
    public static string GPTtimeConversion(string s)
    {
        // Get the last two characters (AM/PM) using the ^ operator
        var prefix = s[^2..]; // equivalent to s.Substring(s.Length - 2)
    
        // Get the string excluding the last two characters (time part) using the .. operator
        var time = s[..^2]; // equivalent to s.Remove(s.Length - 2)
    
        var values = time.Split(':');

        int hour = int.Parse(values[0]);
        int minute = int.Parse(values[1]);
        int second = int.Parse(values[2]);

        if (prefix == "AM" && hour == 12)
        {
            hour = 0;
        }
        else if (prefix == "PM" && hour != 12)
        {
            hour += 12;
        }

        return $"{hour:D2}:{minute:D2}:{second:D2}";
    }


    
    public static string timeConversionEasy(string s)
    {
        return TimeOnly.Parse(s).ToString("HH:mm:ss");
        //return TimeOnly.Parse(s).ToString("HH:mm:ss:ff");
    }
}