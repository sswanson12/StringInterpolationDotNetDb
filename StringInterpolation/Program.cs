namespace StringInterpolation;

class main
{
    static void Main(string[] args)
    {
        /*-----------------------------Date String Interpolation--------------------------------*/
        var today = DateTime.Now;

        var splitter = (today.ToString("f")).Split(',');
        var dayOfWeek = splitter[0];
        var dayOfMonth = today.ToString("dd");
        var monthNumber = today.ToString("MM");
        var month = (today.ToString("M")).Remove((today.ToString("M")).IndexOf(' '));
        var year = today.ToString("yyyy");
        var hour = today.ToString("hh");
        var minutes = today.ToString("mm");
        var seconds = today.ToString("ss");
        var amOrPm = today.ToString("tt");

        //January 22, 2019 (right aligned in a 40 character field)
        var simpleDate = $"{month} {dayOfMonth}, {year}";
        Console.WriteLine($"{simpleDate,40}");
        
        //2019.01.22
        Console.WriteLine($"{year}.{monthNumber}.{dayOfMonth}");
        
        //Day 22 of January, 2019
        Console.WriteLine($"Day {dayOfMonth} of {month}, {year}");
        
        //Year: 2019, Month: 01, Day: 22
        Console.WriteLine($"Year: {year}, Month: {monthNumber}, Day: {dayOfMonth}");

        //            Tuesday (10 spaces total, right aligned)
        Console.WriteLine($"{dayOfWeek,10}");
        
        //     11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
        String fullTime12hr = $"{hour}:{minutes} {amOrPm}";
        Console.WriteLine($"{fullTime12hr,10}{dayOfWeek,10}");
        
        //h:11, m:01, s:27
        Console.WriteLine($"h:{hour}, m:{minutes}, s:{seconds}");
        
        //2019.01.22.11.01.27
        Console.WriteLine($"{year}.{monthNumber}.{dayOfMonth}.{hour}.{minutes}.{seconds}");
        
        
        /*----------------------------Pi String Interpolation-------------------------------*/

        var pi = Math.PI;

        //Output as currency
        Console.WriteLine($"{pi:C}");

        //Output as right-aligned (10 spaces), number with 3 decimal places
        Console.WriteLine($"{pi:F3}");
    }
}