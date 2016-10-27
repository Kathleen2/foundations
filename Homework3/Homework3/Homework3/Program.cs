// Homework 3 Optional

/* Convert time entered in seconds to time displayed in days, hours, minutes, and any remaining seconds */
// 1 day = 86400 seconds;
// 1 hour = 3600 seconds
// 1 minute = 60 seconds

using System;

class TestTime
{
    static void Main()
    {
        while (true)
        {
            //int days = 04294967295
            //int hours = 0;
            //int mins = 0;
            //int secs = 0;

            Console.Write("Please write a large number of seconds between 1 and 4,294,967,295: ");

            string tSecs = Console.ReadLine();

            uint x = uint.Parse(tSecs);

            if (x >= 86400)
            {
                uint days = (x / 86400);
                uint rsecs = (x % 86400);
                uint hours = (rsecs / 3600);
                rsecs = (rsecs % 3600);
                uint mins = (rsecs / 60);

                Console.WriteLine("You wrote {0:N} total seconds.", tSecs);
                Console.WriteLine("That is {0} days, {1} hours, {2} minutes, and {3} seconds.", days, hours, mins, rsecs);
            }

            if (x >= 3600 && x < 86400)
            {
                uint days = 0;
                uint hours = (x / 3600);
                uint rsecs = (x % 3600);
                uint mins = (rsecs / 60);
                rsecs = (rsecs % 60);

                Console.WriteLine("You wrote {0} total seconds.", tSecs);
                Console.WriteLine("That is {0} days, {1} hours, {2} minutes, and {3} seconds.", days, hours, mins, rsecs);
            }

            if (x >= 60 && x < 3600)
            {
                uint days = 0;
                uint hours = 0;
                uint mins = (x / 60);
                uint rsecs = (x % 60);

                Console.WriteLine("You wrote {0} total seconds.", tSecs);
                Console.WriteLine("That is {0} days, {1} hours, {2} minutes, and {3} seconds.", days, hours, mins, rsecs);
            }

            Console.ReadLine();

        }// end of while true

    }  // end of Main
}  // end of class 
