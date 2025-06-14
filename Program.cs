// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

    }

    /* The replaced if-elseif-else statement by the Switch case above
    if (i == 0)
    {
        animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
    }
    else if (i == 1)
    {
        animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
    }
    else if (i == 2)
    {
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
    }
    else if (i == 3)
    {
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
    }
    else
    {
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
    }
    */

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options

do {
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    /*
    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    readResult = Console.ReadLine();
    */

    switch(menuSelection)
    {
        case "1":
            // List all current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    // Console.WriteLine(ourAnimals[i, 0]);
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "2":
            // Add a new animal friend to the ourAnimals array
            // Console.WriteLine("this app feature is coming soon  -  please check back to see progress.");
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                        petCount += 1;
                }

            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }
           
            bool validEntry = false;
            // get species (cat or dog) - string animalSpecies is a required field 
            do
            {
                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    animalSpecies = readResult.ToLower();
                    if (animalSpecies != "dog" && animalSpecies != "cat")
                    {
                        validEntry = false;
                    }
                    else
                    {
                        if (animalSpecies == "dog")
                        {
                            animalID = "d" + (petCount + 1).ToString();
                        }
                        else
                        {
                            animalID = "c" + (petCount + 1).ToString();
                        }
                        validEntry = true;
                    }
                }
            } while (validEntry == false);

            // get the pet's age. can be ? at initial entry.
            do
            {
                int petAge;
                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalAge = readResult;
                    if (animalAge != "?")
                    {
                        validEntry = int.TryParse(animalAge, out petAge);
                    }
                    else
                    {
                        validEntry = true;
                    }
                }
            } while (validEntry == false);

            // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
            do
            {
                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPhysicalDescription = readResult.ToLower();
                    if (animalPhysicalDescription == "")
                    {
                        animalPhysicalDescription = "tbd";
                    }
                }
            } while (animalPhysicalDescription == "");

            // get a description of the pet's personality - animalPersonalityDescription can be blank.
            do
            {
                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPersonalityDescription = readResult.ToLower();
                    if (animalPersonalityDescription == "")
                    {
                        animalPersonalityDescription = "tbd";
                    }
                }
            } while (animalPersonalityDescription == "");

            // get the pet's nickname. animalNickname can be blank.
            do
            {
                Console.WriteLine("Enter a nickname for the pet");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalNickname = readResult.ToLower();
                    if (animalNickname == "")
                    {
                        animalNickname = "tbd";
                    }
                }
            } while (animalNickname == "");

            // store the pet information in the ourAnimals array (zero based)
            ourAnimals[petCount, 0] = "ID #: " + animalID;
            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
            ourAnimals[petCount, 2] = "Age: " + animalAge;
            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

            while (anotherPet == "y" && petCount < maxPets)
            {
                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            // Console.WriteLine("Press the Enter key to continue.");
            // readResult = Console.ReadLine();
            break;
        case "3":
            // Ensure animal ages and physical descriptions are complete.
            // Console.WriteLine("UNDER CONSTRUCTION  - please check back next month to see progress.");

            bool validInput = false;
            bool validString = false;
            // Store numeric age value
            int numericAge = 0;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 2] == "Age: ?")
                {                    
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();
                        validInput = int.TryParse(readResult, out numericAge);
                        if (readResult != null && validInput == true)
                        {                           
                            animalAge = numericAge.ToString();
                            ourAnimals[i, 2] = "Age: " + animalAge;
                            break;
                        }

                        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
                        readResult = Console.ReadLine();
                    } while (validInput == false);
                }

                if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 4] == "Physical description: ")
                {
                    do
                    {
                        Console.WriteLine("Enter a physical description for ID #: c4 (size, color, breed, gender, weight, housebroken)");
                        readResult = Console.ReadLine();

                        if (readResult != null && readResult.Length > 0)
                        {                          
                            animalPhysicalDescription = readResult.ToString();
                            ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                            validString = true;
                            break;
                        }

                        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
                        readResult = Console.ReadLine();
                    } while (validString == false);
                }
            }

            Console.WriteLine("Age and physical description fields are complete for all of our friends.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "4":
            // Ensure animal nicknames and personality descriptions are complete
            // Console.WriteLine("UNDER CONSTRUCTION  - please check back next month to see progress.");

            bool valid_String2 = false;
            bool valid_String = false;         

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 3] == "Nickname: ")
                {                    
                    Console.WriteLine();
                    do
                    {
                        Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();

                        if (readResult != null && readResult.Length > 0)
                        {                          
                            animalNickname = readResult.ToString();
                            ourAnimals[i, 3] = "Nickname: " + animalNickname;
                            validString = true;
                            break;
                        }

                        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
                        readResult = Console.ReadLine();
                    } while (valid_String == false);
                }

                if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 5] == "Personality: ")
                {
                    do
                    {                    
                        Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
                        readResult = Console.ReadLine();

                        if (readResult != null && readResult.Length > 0)
                        {                          
                            animalPersonalityDescription = readResult.ToString();
                            ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                            valid_String2 = true;
                            break;
                        }

                        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
                        readResult = Console.ReadLine();
                    } while (valid_String2 == false);
                }
            }

            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "5":
            // Edit an animal’s age
            Console.WriteLine("UNDER CONSTRUCTION  - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "6":
            // Edit an animal’s personality description
            Console.WriteLine("UNDER CONSTRUCTION  - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "7":
            // Display all cats with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION  - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "8":
            // Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION  - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        default:
            break;
    }

} while(menuSelection != "exit");
