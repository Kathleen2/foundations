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
//  Enhancement: Prevent duplicates of ItemIDNo  DONE
//  Figure out how to manage the menu FormatException errors when values can't be parsed to an int
//  try catch {} ???
//  Enhancement: Ensure the menu string can convert to an int between 1 and 5
//  Enhancement: fill in array with a current inventory before the menu runs DONE
// 4. case 1 - Add case and add several items - DONE
//      Decided not to ask for values that can be calculated.
// 5. write all cases with minumum code, stop messing with the format exception error
// 6. case 4 - list items is DONE
// 7. case 3 - delete item, is DONE
// 8. case 2 - change item,  is DONE
// 9. case 5 -  quit is DONE
// 10. default code is DONE
//    Enhancement: formatting on console list header and underlines is DONE
//    Enhancement: make the array dynamic. Can't figure this out.
//      Stack with one type but how to use in a Struct array?
//    Enhancement: list inventory for user before the change option is DONE
//    Enhancement: list inventory for user before the delete option is DONE

// Final Testing:
// All Menu item 1 through 5 work as expected, except format validation


using System;
//using System.Collections.Generic;
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

            /**************************************************************/
            /***                   Prefill Array items                  ***/
            /***          Comment out to test if (icount == 0)          ***/
            /**************************************************************/

            // A current inventory - for testing:

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

            /**************************************************************/
            /***               End of Prefill Array items               ***/
            /**************************************************************/

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
                string strx = Console.ReadLine();

                /**************************************************************/
                /***                Input Validation Attempts               ***/
                /**************************************************************/

                //// Trying input validation to prevent the Format Exception error
                //// check string length
                //int strlength = (strx.Length);
                //bool bparse = false;

                //if (strlength == 1)
                //{
                //    bparse = true;

                //}
                ////else
                ////{
                ////    bparse = false;
                ////}

                //// check ascii values
                //// The characters '1' through '5' equal ascii 49 through 53, if i need it 0 is ascii 48
                //// I have not found any way to do an SQL IN() so I went to ascii values
                //// The other option is regex but that's not learning C#!
                //char ch = strx[0];
                //int ascii = (int)ch;

                //if (bparse == true)
                //{
                //    if (ascii == 49 || ascii == 50 || ascii == 51 || ascii == 52 || ascii == 53)
                //    {
                //        bparse = true;
                //    }
                //    else
                //    {
                //        bparse = false;
                //        // should go to case default
                //    }
                //}

                //// if it won't parse send a console message
                //// should go to case default but I will just repeat the message

                //if (bparse == false)  // send the default try again message
                //{
                //    Console.Write("Invalid Option, try again! Please enter one number between 1 and 5.\n\n");
                //    break;
                //}

                /******************************************************************/
                /***             End of Input Validation Attempts               ***/
                /******************************************************************/

                int optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

                Console.WriteLine(); // provide an extra blank line on screen
               
                switch (optx)
                {
                    /********************************************/
                    /***          case 1 Add an item          ***/
                    /********************************************/

                    case 1: // add an item to the list if this option is selected
                        {
                            // If Add is chosen, initialize the array spot and use a function to add the itemIDNo first?:
                            // Item Number: read it from screen input, convert it to an int, and store it in the arra"y
                            // This is a new itemIDNo not saved to the array yet.
                            // Look for a matching itemIDNo to prevent a duplicate

                            int idnum = 0;

                            while (idnum == 0)
                            {
                                Console.Write("ID Number:  ");
                                string stridnum = Console.ReadLine();
                                idnum = int.Parse(stridnum);

                                for (int x = 0; x < icount; x++)
                                {
                                    if (itemdata[x].itemIDNo == idnum)
                                    {
                                        Console.WriteLine("Enter a different Item ID number. \"{0}\" is already entered.", itemdata[x].itemIDNo);
                                        idnum = 0;
                                     } // end if

                                 } // end for loop
                            } // end while loop
                       

                            // Description: screen input
                            Console.Write("Description:  ");
                            string desc = Console.ReadLine();

                            // Price per Item: screen input
                            Console.Write("Price per Item:  ");
                            string strprice = Console.ReadLine();
                            double dprice = double.Parse(strprice);

                            // Quantity on Hand: 
                            Console.Write("Quantity on hand:  ");
                            string striquant = Console.ReadLine();
                            int iquant = int.Parse(striquant);

                            // Our Cost per Item: business meaning?
                            // Seems like I should just calculate this, not read from console
                            // Calculate 50% of price
                            double dcost = (dprice * 0.5);
                            Console.Write("Our Cost per Item (50% of Price) = {0}\n", dcost);

                            // Value of Item: 
                            double dvalue = (dcost * iquant);
                            Console.Write("Value of Item (Cost X Quantity on Hand) = {0}\n", dvalue);

                            Console.WriteLine(); // provide an extra blank line.

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

                    /***********************************************/
                    /***          case 2 Change an item          ***/
                    /***********************************************/

                    case 2: //change items in the list if this option is selected
                            // No changes to the item id allowed!
                        {
                            // first check if there are any items in the inventory
                            if (icount == 0)
                            {
                                Console.WriteLine("There are 0 items in the inventory");

                            } // end of if no items in inventory 

                            else // if icount != 0, and the inventory has items
                            {
                                // Display all items in the inventory
                                Console.WriteLine("            All Items in Current Inventory           ");
                                Console.WriteLine("ItemID  Description           Price  QOH  Cost  Value");
                                Console.WriteLine("------  --------------------  -----  ---  ----  -----");

                                for (int i = 0; i < icount; i++)
                                {
                                    Console.WriteLine("{0,6}  {1,-20} {2,7:C2}  {3,4}  {4,7:C2}  {5,7:C2}", itemdata[i].itemIDNo, itemdata[i].sDescription, itemdata[i].dblPricePerItem, itemdata[i].iQuantityOnHand, itemdata[i].dblOurCostPerItem, itemdata[i].dblValueOfItem);
                                }
                                Console.WriteLine(); // provide an extra blank line at end of for loop.

                                // Read the console to find out which item to update
                                Console.Write("Please enter an Item ID No to change: ");
                                string strchgid = Console.ReadLine();
                                int chgid = int.Parse(strchgid);
                                bool fChfound = false;

                                // Search the inventory for the itemIDNo
                                for (int x = 0; x < icount; x++)
                                {
                                    // If the itemIDNo is found display the add menu field for update
                                    if (itemdata[x].itemIDNo == chgid)
                                    {
                                        fChfound = true;

                                        // update the array record except for the itemIDNo
                                        // show the console add screen but put the chgid in the itemIDNo field
                                        Console.WriteLine("ID Number: {0} ", itemdata[x].itemIDNo);

                                        // Description: screen input
                                        Console.Write("Description:  ");
                                        string chdesc = Console.ReadLine();
                                        itemdata[x].sDescription = chdesc;

                                        // Price per Item: screen input
                                        Console.Write("Price per Item:  ");
                                        string strprice = Console.ReadLine();
                                        double dchprice = double.Parse(strprice);
                                        itemdata[x].dblPricePerItem = dchprice;

                                        // Quantity on Hand:
                                        // Seems like I should calculate this, not ask the ask the user
                                        Console.Write("Quantity on hand:  ");
                                        string striquant = Console.ReadLine();
                                        int ichquant = int.Parse(striquant);
                                        itemdata[x].iQuantityOnHand = ichquant;

                                        // Our Cost per Item: Calculate 50% of price
                                        double dchcost = (dchprice * 0.5);
                                        Console.Write("Our Cost per Item (50% of Price) = {0}\n", dchcost);
                                        itemdata[x].dblOurCostPerItem = dchcost;

                                        // Value of Item:
                                        double dchvalue = (dchcost * ichquant);
                                        Console.Write("Value of Item (Cost X Quantity on Hand) = {0}\n", dchvalue);
                                        itemdata[x].dblValueOfItem = dchvalue;

                                        Console.WriteLine(); // provide an extra blank line.

                                        // Note - The count did not change
                                        // I have read this would not actually change unless the stack was a class with referenced data

                                        // Show the user the updated record with the update message
                                        Console.WriteLine("The following Item {0} was updated in inventory\n", chgid);
                                        Console.WriteLine("ItemID  Description           Price  QOH  Cost  Value");
                                        Console.WriteLine("------  --------------------  -----  ---  ----  -----");

                                            while (itemdata[x].itemIDNo == chgid)
                                            {
                                                Console.WriteLine("{0,6}  {1,-20} {2,7:C2}  {3,4}  {4,7:C2}  {5,7:C2}\n", itemdata[x].itemIDNo, itemdata[x].sDescription, itemdata[x].dblPricePerItem, itemdata[x].iQuantityOnHand, itemdata[x].dblOurCostPerItem, itemdata[x].dblValueOfItem);

                                                break;
                                            }
                                    } // end of if (itemdata[x].itemIDNo == chgid) loop
                                } //end of for (int x = 0; x < icount; x++)h loop                                    

                                // If the itemIDNo is not found let the user know
                                if (!fChfound)  // if not in the inventory
                                {
                                    Console.WriteLine("Item {0} was not found in inventory\n", chgid);
                                }
                            } //end of else if icount != 0 loop

                            break;

                        } // End of case 2

                    /***********************************************/
                    /***          case 3 Delete an item          ***/
                    /***********************************************/

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
                                Console.WriteLine(); // provide an extra blank line
                            }
                            // Enter the item to delete
                            Console.Write("Please enter an Item ID No to delete: ");
                            string strnewid = Console.ReadLine();
                            // This is a new ID because it is not saved in the array yet.
                            // Look for a matching itemIDNo to delete
                            int newid = int.Parse(strnewid);
                            bool fDeleted = false;

                            for (int x = 0; x < icount; x++)
                            {
                                // I could not get this itemprop to work
                                // the name is a hint? - it gets or sets the element at the specified index property
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

                    /***********************************************/
                    /***          case 4 List all items          ***/
                    /***********************************************/

                    case 4:  //list all items in current database if this option is selected
                        {
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
                                    //{index[,alignment][:formatString]}
                                    // Add {4:C2}  {5:C2}", itemdata[i].dblOurCostPerItem, itemdata[i].dblValueOfItem);
                                    // Add {5:C2}", itemdata[i].dblValueOfItem);

                                    Console.WriteLine("{0,6}  {1,-20} {2,7:C2}  {3,4}  {4,7:C2}  {5,7:C2}", itemdata[i].itemIDNo, itemdata[i].sDescription, itemdata[i].dblPricePerItem, itemdata[i].iQuantityOnHand, itemdata[i].dblOurCostPerItem, itemdata[i].dblValueOfItem);

                                }
                                Console.WriteLine();
                            }
                            break;
                        } // End of case 4

                    /*************************************************/
                    /***          case 5 Quit the program          ***/
                    /*************************************************/

                    case 5: //quit the program if this option is selected
                        {
                            Console.Write("Are you sure that you want to quit (y/n)?: ");
                            string strresp = Console.ReadLine();
                            string optquit = strresp.ToUpper();

                            if (optquit == "N")   
                            {
                                optx = 0; //as long as it is not 5, the process is not breaking
                                break;	
                            }
                            else
                            {
                                return;
                            }

                        }  //End of case 5

                    /***********************************************/
                    /***               Default case              ***/
                    /***********************************************/

                    default:
                        {
                            // works for integers
                            Console.Write("Invalid Option, try again! Please enter one number between 1 and 5.\n\n");
                            break;
                        } // End of case default

                } // End of switch

            } // End of While true loop

        } // End of Main method

    } // End of class MyInventory

} // End of namespace

