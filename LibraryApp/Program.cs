using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LibraryApp
{
    class Program
    {
        private static bool loopthingy = true;
        // used for the while loop

        private static List<BookClass> LibraryList = new List<BookClass>();
        //makes a list using the BookClass class
        
        static void Main(string[] args)
        {
            BookClass DefaultBook1 = new BookClass("WiiPressen: A History", "WiiPressen Author Man", false);
            LibraryList.Add(DefaultBook1);
            BookClass DefaultBook2 = new BookClass("All About Anime", "Sebastian Anime", false);
            LibraryList.Add(DefaultBook2);
            BookClass DefaultBook3 = new BookClass("Why Change is EVIL and Must be STOPPED at ALL COSTS", "Doctor Axel, PhD", false);
            LibraryList.Add(DefaultBook3);
            BookClass DefaultBook4 = new BookClass("How 2 Making Video Games", "Lukas Developer Man", false);
            LibraryList.Add(DefaultBook4);
            BookClass DefaultBook5 = new BookClass("Kanye > Everything Else", "Will I Am", false);
            LibraryList.Add(DefaultBook5);
            BookClass DefaultBook6 = new BookClass("What's Actually in YOUR Siracha Mayo?", "WiiPressen Author Man", false);
            LibraryList.Add(DefaultBook6);
            // This adds default books to the list so you don't have to add them yourself.
            while (loopthingy)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Welcome to the Library of ALL knowledge.");
                Console.WriteLine("Please select an option.");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("[1] Search for a Title");
                Console.WriteLine("[2] Search for an Author");
                Console.WriteLine("[3] Loan a Book");
                Console.WriteLine("[4] Return a Book");
                Console.WriteLine("[5] List all Books");
                Console.WriteLine("[6] SUPER SECRET ADMIN SETTINGS (SUPER SECRET)");
                Console.WriteLine("[7] Exit");
                Console.WriteLine("---------------------------------------------");
                // Nice UI ;)
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Insert Title:");
                        Console.WriteLine("---------------------------------------------");
                        string titleSearchInput = Console.ReadLine();
                        Console.WriteLine("---------------------------------------------");
                        for (int i = 0; i < LibraryList.Count; i++)
                        {
                            if (LibraryList[i].Title == titleSearchInput)
                            {
                                Console.WriteLine(LibraryList[i].Title + " - " + LibraryList[i].Author);
                            }
                        }
                        // Loops the list around so you can get all the titles
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Insert Author:");
                        Console.WriteLine("---------------------------------------------");
                        string authorSearchInput = Console.ReadLine();
                        Console.WriteLine("---------------------------------------------");
                        for (int i = 0; i < LibraryList.Count; i++)
                        {
                            if (LibraryList[i].Author == authorSearchInput)
                            {
                                Console.WriteLine(LibraryList[i].Title + " - " + LibraryList[i].Author);
                            }
                        }
                        // Does the same as the title one but for authors instead.
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Console.WriteLine("LIST OF ALL CURRENT BOOKS:");
                        Console.WriteLine("---------------------------------------------");
                        for (int i = 0; i < LibraryList.Count; i++)
                        {
                            Console.WriteLine(LibraryList[i].Title + " - " + LibraryList[i].Author);
                        }
                        // Prints out all the books using a for loop
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case "7":
                        loopthingy = false;
                        // Stops the while loop, shutting the program down.
                        break;
                    case "6":
                        Console.WriteLine("What is the Password?");
                        Console.WriteLine("---------------------------------------------");
                        Console.ReadLine();
                        Console.WriteLine("---------------------------------------------");
                        // This whole password part is useless LOL.
                        // It's just here for show.
                        // I could make it work, but then I'd have to tell you the password.
                        Console.WriteLine("Congratulations! You have achieved ADMIN access.");
                        Console.WriteLine("What do you wish to do?");
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("[1] Go Back");
                        Console.WriteLine("[2] Add a Book");
                        Console.WriteLine("[3] Remove a Book");
                        Console.WriteLine("---------------------------------------------");
                        string inputADMIN = Console.ReadLine();
                        switch (inputADMIN)
                        {
                            case "1":
                                break;
                            case "2":
                                Console.WriteLine("What is the book's title?");
                                string newBookTitle = Console.ReadLine();
                                Console.WriteLine("Who is the book's author?");
                                string newBookAuthor = Console.ReadLine();
                                BookClass book = new BookClass(newBookTitle, newBookAuthor, false);
                                LibraryList.Add(book);
                                Console.WriteLine("Your book has been added. Press any key to continue.");
                                Console.ReadKey();
                                break;
                            // This just takes your inputs and shoves them in the list as a new book.
                            case "3":
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("That's not an option");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    // Error message because they're cool
                }
            }
        }
    }
}