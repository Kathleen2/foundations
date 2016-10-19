/* Convert time entered in seconds to time displayed in days, hours, minutes, and any remaining seconds */
// 1 day = 86400;
// 1 hour = 3600 seconds
// 1 mins = 60 seconds\

using System;

    class TestTime

    {
        static void Main()
        {
        //int days = 0;
        //int hours = 0;
        //int mins = 0;
        //int secs = 0;

        Console.Write("Please write a large number of seconds: ");

        string tSecs = Console.ReadLine();

        int x = int.Parse(tSecs);

        //Console.ReadLine();

        if (x >= 86400)
            {
            int days = (x / 86400);
            int rsecs = (x % 86400);
            int hours = (rsecs/3600);
            int secs = (rsecs % 3600);

            Console.WriteLine("You wrote {0} total seconds.", tSecs);
            Console.WriteLine("That is {0} days, {1} hours, and {3} seconds.", days, hours, secs);
            Console.ReadLine();
            }


        }
    }
