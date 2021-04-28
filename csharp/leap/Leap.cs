using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        // on every year that is evenly divisible by 4
        if (year % 4 == 0)
        {   
            // except every year that is evenly divisible by 100
            if (year % 100 == 0)
            {
                // unless the year is also evenly divisible by 400
                if (year % 400 == 0) 
                    return true;
                return false;
            }
            return true;
        } else {
            return false;
        }
    }
}