using System.Globalization;

public class DayOfProgrammers {    

    // 256th day of the year
    // inclusive year range from 1700 to 2700
    // from 1700 to 1917 russia used the julian calender
    // since 1919 they used the Gregorian calendar system

    const int DAYS_IN_8_MONTHS = 243;
    const int DAY_OF_PROGRAMMERS = 256;
    const int FALL_MONTH = 9;

    public static string dayOfProgrammer(int year){

        if(year >= 1700 && year <= 2700) {

            if (year >= 1700 && year <= 1917) {

                return Julian256Day(year);

            }

             if(year >= 1918 && year <= 2700){

                return Gregorian256Day(year);

             }
        }

        return "Year out of range!";

    }

    //julian calendar
    // In both calendar systems, februar is the only month with variable amount of day
        // it has 29 days during a leap year
        // in julian leap years are devisible by 4
        // it has 28 days during all other years

    public static string Julian256Day(int year){
        
        bool isLeapYear = year % 4 == 0;

        int daysIn8Months = DAYS_IN_8_MONTHS;

        if (isLeapYear)
        {
            daysIn8Months = DAYS_IN_8_MONTHS + 1;
        }
        
        var dayOf9thMonth = DAY_OF_PROGRAMMERS - daysIn8Months;

        return $"{dayOf9thMonth:D2}.{FALL_MONTH:D2}.{year}";
    }

    //gregorian calendar
    // the transitian from julian to gregorian occured in 1918
        //when the next day after january 31st was February 14th
        // this means in 1918 february 14th was the 32nd day of the year
    // In both calendar systems, februar is the only month with variable amount of day
        // it has 29 days during a leap year
        // in gregorian leap years are either:
            //devisible by 400
            //devisible by 4 and not divisible by 100
        // it has 28 days during all other years

    public static string Gregorian256Day(int year){       

        var daysIn8Months = DAYS_IN_8_MONTHS;

        bool isLeapYear = year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

        if(isLeapYear) {

            daysIn8Months = DAYS_IN_8_MONTHS + 1;
        }

        if(year == 1918) {

            string format = "dd.MM.yyyy";
            var skippedFrom = DateOnly.ParseExact("31.01.1918", format, CultureInfo.InvariantCulture);
            var skippedTo = DateOnly.ParseExact("14.02.1918", format, CultureInfo.InvariantCulture);

            // We need to also extract 1 to gain the days between the to dates
            var skippedDays = skippedTo.DayNumber - skippedFrom.DayNumber - 1;

            daysIn8Months = DAYS_IN_8_MONTHS - skippedDays;
        }

        var dayOf9thMonth = DAY_OF_PROGRAMMERS - daysIn8Months;

        return $"{dayOf9thMonth:D2}.{FALL_MONTH:D2}.{year}";
    }
}