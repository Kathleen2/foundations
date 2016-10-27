/* Calulate the factorial of an integer n given by the user. Please enter a small number.

for (init; condition; increment)
{
   statement(s);
}
Sal Khan: n! is the number of ways of arranging n items in a sequence. If I have {a,b,c}
it can be arranged in 3!=6 ways: {(abc),(acb)(bac)(bca)(cab)(cba)} Now, consider a set
that has one object: {a}, it can only be arranged in one way, the way it already is, so 1!=1.
Same thing when the set is empty, {}. How may ways are there to arrange {}.
It too can only be arranged the way that it already is as well, so 0!=1.
The factorial n! of a number n = 3 is 1*2*3= 6
The factorial of 0 is considered to be 1
The factorial of 1 is 1
*/


using System;

class Homework3Integer
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Please enter a positive integer between 1 and 20: ");
            string strNum = Console.ReadLine();
            long x = long.Parse(strNum);
            long lresult = 1;

            // If 0 is entered
            if (x == 0)
            {
                Console.WriteLine("The number you entered is {0}. The factorial of {{}}! is {2}", strNum, strNum, lresult);
            }

            // Decrement starting with the number entered
            if (x >= 1 && x < 21)
            {
                lresult = 1;

                for (int i = (int)x; 0 < i && i <= x; i--)
                {
                    lresult = x * lresult;
                    x--;
                }
                Console.WriteLine("The number you entered is {0}. The factorial of {1:N0}! is {2:N0}", strNum, strNum, lresult);
            }

            // Another way - Increment starting with the number entered
            /* if (x >= 1 && x < 21)
             {
                 long lx2up = 1;
                 lresult = 1;

                 for (int i = 1; 0 < i && i <= (int)x; i++)
                 {
                     lresult = lx2up * lresult;
                     lx2up++;
                 }
                 Console.WriteLine("The number you entered is {0}. The factorial of {1:N0}! is {2:N0}", strNum, strNum, lresult);
             }
             */
            // If the number entered is larger than I asked for
            else if (x >= 21)
            {
                Console.WriteLine("The number you entered is {0}. Please enter a number between 1 and 20.", strNum);
            }

            Console.ReadLine();

        }// end of while true

    }  // end of Main

}  // end of class 

