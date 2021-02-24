using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

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
            // BookClass DefaultBook1 = new BookClass("WiiPressen: A History", "WiiPressen Author Man", false);
            // LibraryList.Add(DefaultBook1);
            // BookClass DefaultBook2 = new BookClass("All About Anime", "Sebastian Anime", false);
            // LibraryList.Add(DefaultBook2);
            // BookClass DefaultBook3 = new BookClass("Why Change is EVIL and Must be STOPPED at ALL COSTS", "Doctor Axel, PhD", false);
            // LibraryList.Add(DefaultBook3);
            // BookClass DefaultBook4 = new BookClass("How 2 Making Video Games", "Lukas Developer Man", false);
            // LibraryList.Add(DefaultBook4);
            // BookClass DefaultBook5 = new BookClass("Kanye > Everything Else", "Will I Am", false);
            // LibraryList.Add(DefaultBook5);
            // BookClass DefaultBook6 = new BookClass("What's Actually in YOUR Siracha Mayo?", "WiiPressen Author Man", false);
            // LibraryList.Add(DefaultBook6);
            // BookClass DefaultBook7 = new BookClass("Diet foods YOU won't believe!", "David G Stand", false);
            // LibraryList.Add(DefaultBook7);
            // BookClass DefaultBook8 = new BookClass("Basketball during a crisis", "Samuel Bell Jackson", false);
            // LibraryList.Add(DefaultBook8);
            // BookClass DefaultBook9 = new BookClass("Fashion, a guide", "Lishi Dumpling", false);
            // LibraryList.Add(DefaultBook9);
            // BookClass DefaultBook10 = new BookClass("Underrated Ecchi", "Sebastian Anime", false);
            // LibraryList.Add(DefaultBook10);
            // BookClass DefaultBook11 = new BookClass("Snaigk", "Lukas Developer Man", false);
            // LibraryList.Add(DefaultBook11);
            // This adds default books to the list so you don't have to add them yourself.
            // I HAVE TO REWRITE ALL THIS SO IT SAVES IN A TEXT FILE AAAAAAAAAAAAAAAAAAAAAAA
            // :)

            using (StreamReader sr = File.OpenText("Books.txt"))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] linearray = s.Split("|");
                    bool isborrowed = linearray[2] == "True";
                    BookClass book = new BookClass(linearray[0],linearray[1],isborrowed);
                    LibraryList.Add(book);
                }
                // makes an array and splits the books with the designated separator "|"
                // checks to see if the book is borrowed
                // creates a book using these attributes
                // adds a book to the librarylist using what was written in the text file
            }
            // This wasn't as hard as I thought it would be
            
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
                        string titleSearchInput = Console.ReadLine().ToLower();
                        // I had to make the program case insensitive because my brother doesn't like to use capital letters
                        bool titleFound = false;
                        Console.WriteLine("---------------------------------------------");
                        for (int i = 0; i < LibraryList.Count; i++)
                        {
                            if (LibraryList[i].Title.ToLower() == titleSearchInput)
                            {
                                Console.WriteLine(LibraryList[i].Title + " - " + LibraryList[i].Author);
                                titleFound = true;
                            }
                        }
                        if (titleFound == false)
                        {
                            Console.WriteLine("Title not found!");
                        }
                        // Matches books with the title inputted and prints them
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Insert Author:");
                        Console.WriteLine("---------------------------------------------");
                        string authorSearchInput = Console.ReadLine().ToLower();
                        bool authorFound = false;
                        Console.WriteLine("---------------------------------------------");
                        for (int i = 0; i < LibraryList.Count; i++)
                        {
                            if (LibraryList[i].Author.ToLower() == authorSearchInput)
                            {
                                Console.WriteLine(LibraryList[i].Title + " - " + LibraryList[i].Author);
                                authorFound = true;
                            }
                        }
                        if (authorFound == false)
                        {
                            Console.WriteLine("Author not found!");
                        }
                        // Does the same as the title one but for authors instead.
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Which book would you like to loan?");
                        Console.WriteLine("---------------------------------------------");
                        for (int i = 0; i < LibraryList.Count; i++)
                        {
                            if (LibraryList[i].IsBorrowed == false)
                            {
                                Console.WriteLine(LibraryList[i].Title + " - " + LibraryList[i].Author);
                            }
                            // Fun Fact: I'm retarded.
                            // I tried to make it: if(LibraryList[i].IsBorrowed == true){
                            //                     break;}
                            // That didn't work, and all I needed was to make a false check.
                            // Haha, it took me so long to find that out :^)
                        }
                        Console.WriteLine("---------------------------------------------");
                        string loanSelection = Console.ReadLine().ToLower();
                        bool bookFoundLoan = false;
                        Console.WriteLine("---------------------------------------------");
                        for (int i = 0; i < LibraryList.Count; i++)
                        {
                            if (LibraryList[i].Title.ToLower() == loanSelection)
                            {
                                if (LibraryList[i].IsBorrowed == false)
                                {
                                    LibraryList[i].IsBorrowed = true;
                                    Console.WriteLine("Book Loaned!");
                                    Console.WriteLine("---------------------------------------------");
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    bookFoundLoan = true;
                                } // This checks if the book is borrowed, if it isn't then it loans the book.
                                else if(LibraryList[i].IsBorrowed == true)
                                {
                                    Console.WriteLine("That book has already been loaned!");
                                    Console.WriteLine("---------------------------------------------");
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    bookFoundLoan = true;
                                } // If the book is already loaned, it tells you.
                            }
                        }
                        if (bookFoundLoan == false)
                        {
                            Console.WriteLine("No Book Found!");
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                        // If the book can't be found, it'll tell you that as well.
                    case "4":
                        Console.WriteLine("Which book are you returning?");
                        Console.WriteLine("---------------------------------------------");
                        for (int i = 0; i < LibraryList.Count; i++)
                        {
                            if (LibraryList[i].IsBorrowed == true)
                            {
                                Console.WriteLine(LibraryList[i].Title + " - " + LibraryList[i].Author);
                            }
                        }
                        Console.WriteLine("---------------------------------------------");
                        string returnSelection = Console.ReadLine().ToLower();
                        bool bookFoundReturn = false;
                        Console.WriteLine("---------------------------------------------");
                        for (int i = 0; i < LibraryList.Count; i++)
                        {
                            if (LibraryList[i].Title.ToLower() == returnSelection)
                            {
                                if (LibraryList[i].IsBorrowed == true)
                                {
                                    LibraryList[i].IsBorrowed = false;
                                    Console.WriteLine("Book Returned!");
                                    Console.WriteLine("---------------------------------------------");
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    bookFoundReturn = true;
                                }
                                else if (LibraryList[i].IsBorrowed == false)
                                {
                                    Console.WriteLine("That book is still here!");
                                    Console.WriteLine("---------------------------------------------");
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    bookFoundReturn = true;
                                }
                            }
                        }
                        if (bookFoundReturn == false)
                        {
                            Console.WriteLine("No Book Found!");
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                        // THIS IS BASICALLY THE SAME AS THE LOANING, BUT IN REVERSE
                    case "5":
                        Console.Clear();
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
                        Console.Clear();
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
                                Console.WriteLine("---------------------------------------------");
                                Console.WriteLine("What is the book's title?");
                                string newBookTitle = Console.ReadLine();
                                Console.WriteLine("Who is the book's author?");
                                string newBookAuthor = Console.ReadLine();
                                BookClass bookAdd = new BookClass(newBookTitle, newBookAuthor, false);
                                LibraryList.Add(bookAdd);
                                Console.WriteLine("Your book has been added. Press any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            // This just takes your inputs and shoves them in the list as a new book.
                            case "3":
                                Console.WriteLine("---------------------------------------------");
                                Console.WriteLine("What is the Title of the Book you want to remove?");
                                string removeBook = Console.ReadLine();
                                bool removeBookFound = false;
                                Console.WriteLine("---------------------------------------------");
                                for (int i = 0; i < LibraryList.Count; i++)
                                {
                                    if (LibraryList[i].Title == removeBook)
                                    {
                                        LibraryList.Remove(LibraryList[i]);
                                        removeBookFound = true;
                                        Console.WriteLine("Book removed!");
                                        Console.WriteLine("---------------------------------------------");
                                        Console.WriteLine("Press any key to continue.");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                                if (removeBookFound == false)
                                {
                                    Console.WriteLine("Book not found!");
                                    Console.WriteLine("---------------------------------------------");
                                    Console.WriteLine("Press any key to continue.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("That's not an option");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    // Error message, because you're epic.
                }
            }
            using (StreamWriter sw = File.CreateText("Books.txt"))
            {
                for (int i = 0; i < LibraryList.Count; i++)
                {
                    BookClass book = LibraryList[i];
                    sw.WriteLine(book.Title + "|" + book.Author + "|" + book.IsBorrowed);
                }
                // Writes whatever was in LibraryList when the program was stopped to the file.
            }
        }
    }
}