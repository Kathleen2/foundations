//Assignment #6

//Copy this block into your Visual Studio.

// Review and Redo this code line by line at home.  

// Place comments on each line and describe what the code is doing

using System;

namespace Assignment6Structure
{
    // A structure holds a collection of fields about something. In this case, pets.
    // Public is an access modifier keyword meaning the contents of this struct
    //     are visible / accessible outside of this structure.
    // Struct is a data type allocated on stack running memory, like enum and the simple
    //     data types. It's not yet referenced to a memory storage location in the heap.
    // The identifier for this struct type is Pet.

    public struct Pet
    {
        // These are fields within the struct Pet. Fields are declared outside of a class.
        public string Name;          // Declares Name as a string data type
        public string TypeOfPet;     // Declares TypeOfPet as a string data type
    }

    class Program
    {
        // A Main() method is the entry point to a C# program.
        // The static modifier to the Main() method means this method is called directly from class Program, 
        //     I can't make an object to instantiate the Program class before 
        //     the compiler starts the Main() method. Main() always has to be static
        //     or the program can't start.
        // Void means this method does not return any value

        static void Main()
        {
            // The following are local variables because they are declared inside a method. 
            // Var types are implicitly assigned by the compiler when it reads the value
            //     assigned to the var. The type can't be changed after the complier initializes it.
            // Var types can't be assigned a value of an incompatible type after initialization.

            var numberOfPets = 0;  // Compiler reads the declaration of numberOfPets as var, and it 
                                   //     is initialized to 0, so the compiler typed it as integer.
                                   // This counter is declared and initialized outside of the while
                                   //     and for loops.

            var pets = new Pet[10];  // Pets is instantiated (a new instance of the struct Pet),
                                     //    as local variable of struct type Pet
                                     // This creates an array of type struct with 10 members.

            while (true)  // The while loop starts and runs until the user closes the console or
                            // until the console closes with a break.
            {
                // The Write() method enters a text string to the Console window. It does not wrap 
                //     to a new line. It is used here to ask for user input.

                // Option C was added to close the console window.
                Console.Write("A)dd D)elete L)ist pets or C)lose this window: ");

                // The ReadLine() method gets any text entry when it is entered on the console.
                // The text is assigned to the var type named choice. The compiler
                //     initialized it to string.
                // I think the default type for ReadLine returned values is string.
                var choice = Console.ReadLine();

                // This switch is a control statement that receives a data string value from 
                //     the console entered value of the variable choice. The complier reads down the 
                //     list of switch cases and executes the code block within the matching case. It could
                //     move through several cases if the first case sends the program execution to another
                //     case with a goto statement. But gotos are not recommended.
                // If no case label contains a matching value, control is transferred to the default
                //     section, if there is one.

                // This is the switch statement.(choice) is the switch expresssion from the value
                //     entered on the console. It must match a case value for a switch code block
                //     to execute. Case label values must be a type that can be a constant.
                switch (choice)
                {
                    // If choice equals "A" or "a" the compiler executes this block, if not it will drop
                    //     to the next case in the switch list and compare it"s value to choice.
                    // This case is the Add a pet to the array option.
                    // The code asks the user to input text with a pet's name and the type of pet.
                    // These values are stored in the struct fields, then the counter variable 
                    //     numberOfPets is incremented to account for the added pet.

                    // Using several switch labels means OR, so either case will work. 
                    case "A":
                    case "a":
                        {
                            Console.Write("Name :");
                            var name = Console.ReadLine();

                            Console.Write("Type of pet :");
                            var typeOfPet = Console.ReadLine();

                            // Always add the pet at the end of the array
                            // The variable name from console entry is assigned to the
                            //     struct field Name. 
                            pets[numberOfPets].Name = name;

                            // The variable typeOfPet from console entry is assigned to the
                            //     struct field TypeOfPet.
                            pets[numberOfPets].TypeOfPet = typeOfPet;

                            // the integer counter numberOfPets increments by 1
                            numberOfPets++;

                            // These break statements stop the execution of a case within the switch
                            //     statement. The compiler exits this particular case but remains within
                            //     the while loop so the console window stays open.
                            break;   
                        }

                    // If choice = "D" or "d" the compiler executes this block, if not it will drop
                    //     to the next case in the switch list and compare it"s value to choice.
                    // This case is to Delete a pet from the array, after checking to verify there is
                    //      a pet to delete. A pet is deleted by re-assigning the fields,  
                    //      then the counter is decremented to account for the deleted pet.
                    case "D":
                    case "d":
                        {
                            // First check to see if there are any members in the array.
                            if (numberOfPets == 0)
                            {
                            // If there are no pets to delete, tell the user.
                              Console.WriteLine("No pets");

                            // If there are no pets to delete, leave this case and return to
                            // the console window.
                               break;
                            }

                            // If the counter numberOfPets is not zero, the compiler drops to the for loop.
                            // In the for loop, first the var variable index is initialized to 0;
                            //     second, the conditional expression checks if the index value is less
                            //     than the value of the counter numberOfPets; as long as this is true, 
                            //     the compiler executes the for loop code block. 
                            // After the code block writes a line to the console window, the index value is
                            //     incremented and the conditional expression is compared to the new index value.
                            // This repeats until the index value = numberOfPets, and the for loop ends.
                            for (var index = 0; index < numberOfPets; index++)
                            {
                                // For each member of the array starting with the first index [0]
                                //     the Console writes a text line with the index number (increased by 1 
                                //     for user readability), the field Name of the pet, and the field 
                                //     Type of the pet in that indexed location (the actual index is minus 1
                                //     of the console index).
                                // The {1,-10} placeholder format means write the pets name followed 
                                //      by 10 spaces after the name. 
                                // A new line starts for the contents of the next struct index location.

                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            // The user selects a pet to delete by entering the pets list number from 
                            //     the list they read on the console.

                            Console.Write("Which pet to remove (1-{0})", numberOfPets);

                            // A local variable petNumberToDelete is delared and intitialized from
                            //    the console text input.
                                var petNumberToDelete = Console.ReadLine();

                            // The text string petNumberToDelete is cast to an an integer type variable
                            //     with a Parse() method. The int variable identifier is indexToDelete.
                            var indexToDelete = int.Parse(petNumberToDelete);

                            // Squish the array from index to the end
                            // The variable indexToDelete - 1 (minus 1 to account for the displayed
                            //     number the user sees and enters), initializes the for loop which will
                            //     delete the pet.
                            // The loop's condtional expression checks to see if the index value is less than 
                            //     the number of pets. As long as the expression evaluates to True, the pet in
                            //     the next up index numbered location is copied into the current index number, effectively 
                            //     overwriting the deleted pets memory location.
                            // The for loop repeats, copying each member of a higher index number down one index
                            // The incrementer raises the index value by one so it matches the numberOfPets counter.
                            for (var index = indexToDelete - 1; index < numberOfPets; index++)
                            {
                                // Just copy the pet from the next index up into the current index
                                // Example: the pet in index[5] is selected to be deleted, the values of the pet in 
                                //      index[6] are assigned to index[5], and the pet in index[5] is overwritten.

                                pets[index] = pets[index + 1];
                            }

                            // We have one less pet
                            // The integer counter numberOfPets decrements by 1, because the count of indexs
                            // is now shorter by the one deleted pet.

                            numberOfPets--;

                            // Leave this case and return to the console window.
                            break;
                        }

                    // If choice = "L" or "l" the compiler executes this block, if not it will drop
                    //     to the next case in the switch list and compare it"s value to choice.
                    // This case is to send a Lists of all pets in the struct array to the console window.
                    //  Its reads the struct array to get each pets index, name and type. 

                    case "L":
                    case "l":
                        {
                            // First check to see if there are any members in the struct array.
                            if (numberOfPets == 0)
                            {
                                // If there are no pets tell the user.
                                Console.WriteLine("No pets");
                            }

                            // If the counter numberOfPets is not zero, the compiler drops to the for loop.
                            // First the integer variable index is defined and initialized to 0; 
                            // Second, the conditional expression checks if the index value is less
                            //     than the value of the counter numberOfPets; as long as this is True, 
                            //     the compiler writes the members of the next index to the console. 
                            // Third, after the code block writes a line to the console window, the index value is
                            //     incremented by 1 and the conditional expression is compared to the new index value.
                            // This repeats until the index value = numberOfPets, and the for loop ends.

                            for (int index = 0; index < numberOfPets; index++)
                            {
                                // For each member of the struct array starting with the first index [0]
                                //     the Console writes a text line with the index number (increased by 1 
                                //     for user readability), the field Name of the pet, and the field 
                                //     Type of the pet in that indexed location (the actual index is minus 1
                                //     of the console index).
                                // The {1,-10} placeholder format means write the pets name followed 
                                //      by 10 spaces after the name. 
                                // A new line starts for the contents of the next struct index location.

                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            // After the for loop finishes, leave this case and return to
                            //     the console window.
                            break;
                        }

                    // I added another option C to close the console window.
                    case "C":
                    case "c":
                        {
                            return;
                        }

                        // If the text entered is not a valid character that matches to a case
                        //     the compiler ends at this last default case. 
                    default:
                        {
                            // The console writes the Invalid option message with an empty box. 
                            Console.WriteLine("Invalid option [{0}]", choice);

                            // The break statement causes the compiler to exit this last case and return
                            //     to the console window where the user can choose one of the listed options.
                            break;
                        }

                } // End of switch
            }  // End of While loop
        } // End of Main method
    }  // End class Program
}  // End namespace
