    using System;

    class Game
    {

        private static string[] inventory;
        private int maxInventorySlots;  

        public Game()
        {
            maxInventorySlots = 5;
            inventory = new string[maxInventorySlots];
        }
    public void Start()
    {
        Console.WriteLine("Welcome to Escape the Dungeon! Type 'enter' to begin");
            string userInput = Console.ReadLine();

            if (userInput == "enter")
            {
                ChapterOneA();
            }
            else
            {
                Console.WriteLine("Please type 'enter' to begin the game");
                
            }
        }

        static void ChapterOneA()
        {
            Console.WriteLine("In the mystical realm of Elvenland, a dark dungeon emerges, known as the shadowplace. Legends of the Ancients spoke of this place as filled with unimaginable riches hidden inside, guarded by powerful creatures. Many have delved inside, but none have returned. You, a brave adventurer seeking glory and riches, decided to embark on this journey.");

            Console.WriteLine("You are standing outside. In front of you is a large wooden door. The door appears old. You remember your own abilities, such as look, use, shout, and move");

            string userInput;

            do
            {
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    Console.WriteLine("Exiting the game. Goodbye!");
                    return; // Exit the program
                }

                options1(userInput);

            } while (true);
        }

        static void options1(string userInput)
        {
            if (userInput == "look")
            {
                Console.WriteLine("You are standing outside. In front of you is a large wooden door.");
            }
            else if (userInput == "use")
            {
                Console.WriteLine("You open the large wooden door. It makes a terrible sound, and reveals behind it only darkness. A torch appears in your hand.");
                ChapterOneB();

            }
            else if (userInput == "shout")
            {
                Console.WriteLine("You scream at the top of your lungs. Nobody answers.");
            }
            else if (userInput == "move")
            {
                Console.WriteLine("The door is closed. You must open it first.");
            }
            else if (userInput == "inventory")
            {
                DisplayInventory();
            }
            else
            {
                Console.WriteLine("That is not one of your abilities");
            }
        }

        static void ChapterOneB()
        {
            Console.WriteLine("You are standing in a narrow room");
            string userInput;

            do
            {
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    Console.WriteLine("Exiting the game. Goodbye!");
                    return; // Exit the program
                }

                options2(userInput);

            } while (true);
        }

        static void options2(string userInput)
        {
            if (userInput == "look")
            {
                Console.WriteLine("You see cryptic inscriptions on the walls. You cannot read the inscriptions. But you have a feeling that they represent the history of this place.  ");
            }
            else if (userInput == "use")
            {
                Console.WriteLine("You don't see anything you can use.");
                

            }
            else if (userInput == "shout")
            {
                Console.WriteLine("You cannot hear your own voice.");
            }
            else if (userInput == "move")
            {
                Console.WriteLine("You move forward.");
                ChapterOneC();
            }
            else if (userInput == "inventory")
            {
                DisplayInventory();
            }
            else
            {
                Console.WriteLine("That is not one of your abilities");
            }
        }

        static void ChapterOneC()
        {
            string userInput;

            do
            {
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    Console.WriteLine("Exiting the game. Goodbye!");
                    return; // Exit the program
                }

                options3(userInput);

            } while (true);
        }

        static void options3(string userInput)
        {
            if (userInput == "look")
            {
                Console.WriteLine("In front of you, you see two doors, one on the left and one on the right. You see a dagger lying on the floor.");
            }
            else if (userInput == "use")
            {
                Console.WriteLine("You pick up the dagger.");
                AddToInventory("Dagger");

            }
            else if (userInput == "shout")
            {
                Console.WriteLine("You don't have the energy at the moment.");
            }
            else if (userInput == "move")
            {
                Console.WriteLine("move towards what door? left or right?");
            }
            else if (userInput == "move left")
            {
                Console.WriteLine("You move towards the left door.");
                ChapterOneD();
            }

            else if (userInput == "move right")
            {
                Console.WriteLine("You move towards the right door. You suddenly feel a sharp pain in your chest. You have been stabbed!");
                {
                    Random random = new Random();

                    int randomInRange = random.Next(1, 10);
                    if (randomInRange < 5 )
                    {
                        Console.WriteLine("Game Over");
                        DeathEvent();
                    }
                    else if (randomInRange >= 5)
                    {
                        Console.WriteLine("You pull out the blade that is lodged in you and smear magic juice on the wound. You feel fine");
                        ChapterOneD();
                    }
                }
            }
            else if (userInput == "inventory")
            {
                DisplayInventory();
            }
            else
            {
                Console.WriteLine("That is not one of your abilities");
            }
        }

        static void ChapterOneD()
        {
            string userInput;

            do
            {
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    Console.WriteLine("Exiting the game. Goodbye!");
                    return; // Exit the program
                }

                options4(userInput);

            } while (true);
        }

        static void options4(string userInput)
        {
            if (userInput == "look")
            {
                Console.WriteLine("In front of you you see a large man he is holding a knife");
            }
            else if (userInput == "use")
            {
                Console.WriteLine("You stab the man in the heart. The man disappears and becomes a treasure chest. you open the chest and you are suddenly teleported to your bed. It was all a dream! THE END");
                DeathEvent();

            }
            else if (userInput == "shout")
            {
                Console.WriteLine("You don't have the energy at the moment.");
            }
            else if (userInput == "move")
            {
                Console.WriteLine("you are too scared to move forward");
            }
        

        
            else
            {
                Console.WriteLine("That is not one of your abilities");
            }   
        }

        static void DeathEvent()
        {
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
                {
                    Console.WriteLine("Exiting the game. Goodbye!");
                    return; // Exit the program
                }
        }

        static void AddToInventory(string item)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == null)
                {
                    inventory[i] = item;
                    Console.WriteLine($"Added {item} to your inventory.");
                    return;
                }
            }
            Console.WriteLine("Your Inventory is full. You cannot add more items.");
        }

        static void DisplayInventory()
        {
            Console.WriteLine("Inventory:");
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] != null)
                {
                    Console.WriteLine($"{i+ 1}. {inventory[i]}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. - Empty -");
                }
            }
        }
        }

        
        

    
