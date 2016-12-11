// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

// The Project plan
// 1. Struct DONE
// 2. Menu choices 1-5 DONE
// 3. Basic format the console list output DONE
//  Prevent duplicates of ItemIDNo  DONE
//  Figure out how to manage the FormatException errors when values can't be parsed to an int
//  try catch {} ???
//  Ensure the menu string can convert to an int between 1 and 5
//  Enhance my testing fill in array with a current inventory before the menu runs DONE
// 4. case 1 - Add case and add several items - DONE
//      not sure if the quantity on hand should be an add item.
//      I would not store anything that can be calculated but in this case i will since no database.
// 5. write all the cases with minumum code
// 6. case 4 - list items is DONE
// 7. case 3 - delete item, is DONE
// 8. case 2 - change item, 
// 9. case 5 -  quit  
// 10. default code
//    Enhance formatting on console list header and underlines DONE
//    Enhance array by making it dynamic  
//    Enhance delete code list inventory for user before the delete option
//    Enhance change code list inventory for user before the delete option


using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ITFdnFinalProject
{
    struct ItemData
    {
        public int itemIDNo;

        public string sDescription;
        public double dblPricePerItem;
        public int iQuantityOnHand;
        public double dblOurCostPerItem;
        public double dblValueOfItem;
    }


    class MyInventory
    {
        public static void Main()
        {
            // use an integer to keep track of the count and index of items in your inventory					
            int icount = 0;
            //bool fsuccess = false;

            // create an array of your ItemData struct
            ItemData[] itemdata = new ItemData[15];

            // prefill array with current inventory - hard code at least for further testing:
            itemdata[0].itemIDNo = 1;
            itemdata[0].sDescription = "Coffee, Cuban 2 lb";
            itemdata[0].dblPricePerItem = 15.00;
            itemdata[0].iQuantityOnHand = 10;
            itemdata[0].dblOurCostPerItem = 7.5; // (dblPricePerItem * 0.5)
            itemdata[0].dblValueOfItem = 75; //(dblOurCostPerItem * iQuantityOnHand)

            icount = icount + 1;

            itemdata[1].itemIDNo = 2;
            itemdata[1].sDescription = "Coffee, Sumatra 1 lb";
            itemdata[1].dblPricePerItem = 6.00;
            itemdata[1].iQuantityOnHand = 15;
            itemdata[1].dblOurCostPerItem = 3;
            itemdata[1].dblValueOfItem = 45;

            icount = icount + 1;

            itemdata[2].itemIDNo = 3;
            itemdata[2].sDescription = "Eggs, organic 18";
            itemdata[2].dblPricePerItem = 6.40;
            itemdata[2].iQuantityOnHand = 20;
            itemdata[2].dblOurCostPerItem = 3.2;
            itemdata[2].dblValueOfItem = 64;

            icount = icount + 1;

            itemdata[3].itemIDNo = 4;
            itemdata[3].sDescription = "Naan, Mini 18";
            itemdata[3].dblPricePerItem = 5.50;
            itemdata[3].iQuantityOnHand = 10;
            itemdata[3].dblOurCostPerItem = 2.75;
            itemdata[3].dblValueOfItem = 27.5;

            icount = icount + 1;

            itemdata[4].itemIDNo = 5;
            itemdata[4].sDescription = "Tamales, Beef 3 lb";
            itemdata[4].dblPricePerItem = 12.00;
            itemdata[4].iQuantityOnHand = 20;
            itemdata[4].dblOurCostPerItem = 6;
            itemdata[4].dblValueOfItem = 120;

            icount = icount + 1;

            itemdata[5].itemIDNo = 6;
            itemdata[5].sDescription = "Mangos, dried 2 lb";
            itemdata[5].dblPricePerItem = 17.00;
            itemdata[5].iQuantityOnHand = 15;
            itemdata[5].dblOurCostPerItem = 8.5;
            itemdata[5].dblValueOfItem = 127.5;

            icount = icount + 1;

            itemdata[6].itemIDNo = 7;
            itemdata[6].sDescription = "Apples, 1 lb";
            itemdata[6].dblPricePerItem = 1.50;
            itemdata[6].iQuantityOnHand = 10;
            itemdata[6].dblOurCostPerItem = 0.75;
            itemdata[6].dblValueOfItem = 7.5;

            icount = icount + 1;

            itemdata[7].itemIDNo = 8;
            itemdata[7].sDescription = "Lettuce, head";
            itemdata[7].dblPricePerItem = 1.40;
            itemdata[7].iQuantityOnHand = 15;
            itemdata[7].dblOurCostPerItem = 0.7;
            itemdata[7].dblValueOfItem = 7;

            icount = icount + 1;

            // use a never ending loop that shows the user what options they can select 
            // as long as no one Quits, continue the inventory update
            // in that loop, show what user can select from the list
            while (true)
            {
                // Menu list:
                Console.WriteLine("Inventory Database. What do you want to do?");
                Console.WriteLine("1 - Add an item");
                Console.WriteLine("2 - Change an item");
                Console.WriteLine("3 - Delete an item");
                Console.WriteLine("4 - List all items in the inventory");
                Console.WriteLine("5 - Quit");
                Console.WriteLine();
                Console.Write("Please choose an option number from this list (1, 2, 3, 4, or 5): ");

                // read the user's input and then create what case it falls
                string strx = Console.ReadLine();   // read user's input to get the option number

                int optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

                Console.WriteLine(); // provide an extra blank line on screen

                switch (optx)
                {
                    case 1: // add an item to the list if this option is selected
                        {
                            // If Add is chosen, initialize the array spot and use a function to add the itemIDNo first?:
                            // Item Number: read it from screen input, convert it to an int, and store it in the arra"y
                            // This is a new itemIDNo not saved to the array yet.
                            // Look for a matching itemIDNo to prevent a duplicate

                            Console.Write("ID Number:  ");
                            string stridnum = Console.ReadLine();
                            int idnum = int.Parse(stridnum);
                            //bool fDuplicate = false;
                            
                            for (int x = 0; x < icount; x++)
                            {
                                if (itemdata[x].itemIDNo == idnum)
                                {
                                    Console.WriteLine("Enter a different Item ID number.{0} is already entered.", itemdata[x].itemIDNo);
                                }
                                Console.Write("ID Number:  ");
                                stridnum = Console.ReadLine();
                                idnum = int.Parse(stridnum);
                            }
                            
                            // Description: screen input
                            Console.Write("Description:  ");
                            string desc = Console.ReadLine();

                            // Price per Item: screen input
                            Console.Write("Price per Item:  ");
                            string strprice = Console.ReadLine();
                            double dprice = double.Parse(strprice);

                            // Quantity on Hand: 
                            // Seems like I should calculate this, not ask the ask the user
                            Console.Write("Quantity on hand:  ");
                            string striquant = Console.ReadLine();
                            int iquant = int.Parse(striquant);

                            // Our Cost per Item: business meaning?
                            // Seems like I should just calculate this, not read from console
                            // Calculate 50% of price
                            double dcost = (dprice * 0.5);
                            Console.Write("Our Cost per Item (50% of Price) = {0}\n", dcost);

                            // Value of Item: business meaning? calculate cost * quantity? or price * quantity?
                            double dvalue = (dcost * iquant);
                            Console.Write("Value of Item (Cost X Quantity on Hand) = {0}\n", dvalue);

                            Console.WriteLine(); // provide an extra blank line. Switch to \n when I add the last menu code.

                            // Store the data in the inventory:
                            // It will go to the end of the array
                            itemdata[icount].itemIDNo = idnum;
                            itemdata[icount].sDescription = desc;
                            itemdata[icount].dblPricePerItem = dprice;
                            itemdata[icount].iQuantityOnHand = iquant;
                            itemdata[icount].dblOurCostPerItem = dcost;
                            itemdata[icount].dblValueOfItem = dvalue;

                            icount = icount + 1;

                            break;
                        }  // End of case 1



                    //case 2: //change items in the list if this option is selected
                    //        // No changes to the item id allowed!
                    //    {
                    //    Console.Write("Please enter an item ID No:");
                    //    string strchgid = Console.ReadLine();
                    //    int chgid = int.Parse(strchgid);
                    //    bool fFound = false;

                    //        for (int x = 0; x < icount; x++)
                    //        {
                    //            if (itemprop[x].itemIDNo == chgid)
                    //            {
                    //                fFound = true;
                    //                // code to show what has to happen if the item in the list is found
                    //                // reset the count to show a new count for your list 
                    //                // (Note: your list is now increased by one item)
                    //            }
                    //        }

                    //        if (!fFound) // and if not found
                    //        {
                    //            Console.WriteLine("Item {0} not found", chgid);
                    //        }

                    //        break;
                    //    } // End of case 2



                    case 3: //delete items in the list if this option is selected
                        {
                            // first check if there are any items in the inventory
                            if (icount == 0)
                            {
                                Console.WriteLine("There are 0 items in the inventory");
                            }

                            else
                            // Display all items in the inventory
                            {
                                Console.WriteLine("ItemID  Description           Price  QOH  Cost  Value");
                                Console.WriteLine("------  --------------------  -----  ---  ----  -----");

                                for (int i = 0; i < icount; i++)
                                {
                                    Console.WriteLine("{0,6}  {1,-20} {2,7:C2}  {3,4}  {4,7:C2}  {5,7:C2}", itemdata[i].itemIDNo, itemdata[i].sDescription, itemdata[i].dblPricePerItem, itemdata[i].iQuantityOnHand, itemdata[i].dblOurCostPerItem, itemdata[i].dblValueOfItem);
                                }
                                Console.WriteLine(); // provide an extra blank line at end of for loop.
                            }
                            // If the counter numberOfPets is not zero, the compiler drops to the for loop.
                            // In the for loop, first the var variable index is initialized to 0;
                            //     second, the conditional expression checks if the index value is less
                            //     than the value of the counter numberOfPets; as long as this is true, 
                            //     the compiler executes the for loop code block. 
                            // After the code block writes a line to the console window, the index value is
                            //     incremented and the conditional expression is compared to the new index value.
                            // This repeats until the index value = numberOfPets, and the for loop ends.
                            //for (var index = 0; index < numberOfPets; index++)
                            //{
                            ////    For each member of the array starting with the first index[0]
                            ////         the Console writes a text line with the index number (increased by 1
                            ////         for user readability), the field Name of the pet, and the field
                            ////         Type of the pet in that indexed location(the actual index is minus 1
                            ////         of the console index).
                            ////     A new line starts for the contents of the next struct index location.

                            //    Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            //}

                            // The user selects a pet to delete by entering the pets list number from 
                            //     the list they read on the console.

                            //Console.Write("Which pet to remove (1-{0})", numberOfPets);
                            //// A local variable petNumberToDelete is delared and intitialized from
                            ////    the console text input.
                            //var petNumberToDelete = Console.ReadLine();

                            //// The text string petNumberToDelete is cast to an an integer type variable
                            ////     with a Parse() method. The int variable identifier is indexToDelete.
                            //var indexToDelete = int.Parse(petNumberToDelete);

                            //// Squish the array from index to the end
                            //// The variable indexToDelete - 1 (minus 1 to account for the displayed
                            ////     number the user sees and enters), initializes the for loop which will
                            ////     delete the pet.
                            //// The loop's condtional expression checks to see if the index value is less than 
                            ////     the number of pets. As long as the expression evaluates to True, the pet in
                            ////     the next up index numbered location is copied into the current index number, 					effectively 
                            ////     overwriting the deleted pets memory location.
                            //// The for loop repeats, copying each member of a higher index number down one index
                            //// The incrementer raises the index value by one so it matches the numberOfPets 				counter.
                            //for (var index = indexToDelete - 1; index < numberOfPets; index++)
                            //{
                            //    // Just copy the pet from the next index up into the current index
                            //    // Example: the pet in index[5] is selected to be deleted, the values of the pet in 
                            //    //      index[6] are assigned to index[5], and the pet in index[5] is overwritten.

                            //    pets[index] = pets[index + 1];
                            //}

                            //// We have one less pet
                            //// The integer counter numberOfPets decrements by 1, because the count of indexs
                            //// is now shorter by the one deleted pet.

                            //numberOfPets--;



                            Console.Write("Please enter an Item ID No to delete:");
                            string strnewid = Console.ReadLine();
                            // This is a new ID because it is not saved in the array yet.
                            // Look for a matching itemIDNo to delete
                            int newid = int.Parse(strnewid);
                            bool fDeleted = false;

                            for (int x = 0; x < icount; x++)
                            {

                                // the name is a hint? - it gets or sets the element at the specified index property
                                // I could not get this itemprop to work
                                // if (itemprop[x].itemIDNo == newid)
                                if (itemdata[x].itemIDNo == newid)
                                {
                                    fDeleted = true;
                                    // delete the item if you found it
                                    int indexToDelete = x;
                                    for (var index = indexToDelete; index < icount; index++)
                                    {
                                        // Just copy the values from the next index up into the current index
                                        // Example: the item in index[1] is selected to be deleted, the values of the item in 
                                        // index[2] are assigned to index[2], and the item in index[1] is overwritten.

                                        itemdata[index] = itemdata[index + 1];
                                    }
                                    // reset the count to show a new count for your list 
                                    //(Note: your list is now reduced by one item)
                                    icount--;
                                }
                            }

                            if (fDeleted) // hint the user that you deleted the requested item
                            {
                                Console.WriteLine("Item {0} was deleted from inventory\n", newid);
                            }
                            else // if did not find it, hint the user that you did not find it in your list
                            {
                                Console.WriteLine("Item {0} was not found in inventory\n", newid);
                            }

                            break;
                        } // End of case 3

                    case 4:  //list all items in current database if this option is selected
                        {
                            //bool found = false;          // set a boolean flag
                            //found = true;
                            //{index[,alignment][:formatString]}
                            // first check if there are any items in the inventory
                            if (icount == 0)
                            {
                                Console.WriteLine("There are 0 items in the inventory");
                            }

                            else
                            {
                                Console.WriteLine("ItemID  Description           Price   QOH   Cost    Value");
                                Console.WriteLine("------  --------------------  ------  ----  ------  ------");

                                for (int i = 0; i < icount; i++)
                                {
                                    // Add {4:C2}  {5:C2}", itemdata[i].dblOurCostPerItem, itemdata[i].dblValueOfItem);
                                    // Add {5:C2}", itemdata[i].dblValueOfItem);

                                    Console.WriteLine("{0,6}  {1,-20} {2,7:C2}  {3,4}  {4,7:C2}  {5,7:C2}", itemdata[i].itemIDNo, itemdata[i].sDescription, itemdata[i].dblPricePerItem, itemdata[i].iQuantityOnHand, itemdata[i].dblOurCostPerItem, itemdata[i].dblValueOfItem);

                                }
                                Console.WriteLine();
                            }
                            break;
                        } // End of case 4


                    case 5: //quit the program if this option is selected

                        //  Console.Write("Are you sure that you want to quit(y/n)?");
                        //  string strresp = Console.ReadLine();
                             //write an inner case?
                        //
                        //  if (strresp == "n" || strresp = "N") // code  if optx is 5 or not 5?
                        //  {
                        //      optx = 0;   // as long as it is not 5, the process is not breaking	
                        //  }

                        //if (strresp == "y" || strresp = "Y") // code  if optx is 5 or not 5?
                        //{
                        //    optx = 5;   //if it is not 5, the process breaks - watch which loop
                        //}
                        break;
                        } // End of case 5


                    default:
                        {
                            // works for integers
                            // If the response from the console is anything other than an string/integer between 1 and 5
                            // try a string value

                            // Console.WriteLine("Invalid integer {0} or character {1} Option, try again", optx, strx);
                            Console.Write("Invalid Option, try again");
                            break;
                        } // End of case default

                } // End of switch

            } // End of While true loop

        } // End of Main method
    } // End of class MyInventory
} // End of namespace

