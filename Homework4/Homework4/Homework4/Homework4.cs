// Homework4

using System;

class Homework4
{
    static void Main()
    {
        // Ask the user for an integer, then calculate and print all factorials of the consecutime integers from one to the integer.
        // 12 is the last number that can return a factorial as an integer type
        Console.Write("Enter the number of factorials you would like to see listed. Use a number between 1 and 12:   ");

        // Declare variables
        string sNum = Console.ReadLine();
        int iNum = int.Parse(sNum);
        //int iVal = 1;

        // Delare the array of type integer, allocate the memory needed with a length = to the number of factorials to list
        int[] aiMyArray = new int[iNum];
        int iResult = 1;       

        // Populate the array with integer values from 1 to iNum, each index has a null value when created
        for (int i = 0; i < iNum; i++)
        {
            aiMyArray[i] = i + 1;
            iResult = iResult * aiMyArray[i];

                // Print the result to test so far
            Console.WriteLine("The value in index {0} is {1:N0}.\tIt's factorial is {2:N0}", i, aiMyArray[i], iResult);
        }

        // next store the factorial value in a second array. make this two dimensional?

        // Keep the console open
        Console.ReadLine();

    } // End of Main
}  // End of class


