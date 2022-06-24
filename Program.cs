using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Program
    {
        static void Main()
        {
            library<string> lib = new library<string>();

            UserInput(lib);
            Console.ReadKey();
        }
        static void UserInput(library<string> lib)
        {
            Console.WriteLine("Welcome To information center");
            int option;
            do
            {
                Console.WriteLine("\nPlease Select Option Down Below:\n1.Add Book\n2.Remove Book\n3.Total No of Books\n4.Display All Books\n5.Cancel");
                string options = Console.ReadLine();
                while (!int.TryParse(options, out option))
                {
                    Console.WriteLine("Please Enter Correct Option");
                    options = Console.ReadLine();
                }

                switch (option)
                {
                    case 1:
                        AddBook(lib);
                        break;
                    case 2:
                        lib.DisplayAllBooks();
                        lib.RemoveBookByIndex();
                        break;
                    case 3:
                        lib.TotalBooksCount();
                        break;
                    case 4:
                        lib.DisplayAllBooks();
                        break;
                    case 5:
                        Cancel();
                        break;
                    default:
                        Console.WriteLine("Please Enter Correct Option");
                        break;
                }
            } while (option != 5);
        }
        static void Cancel()
        {
            Console.WriteLine("Thanks For Visiting information center Please Visit Again\nPress Any Key To Exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void AddBook(library<string> lib)
        {
            Console.WriteLine("Please Enter Your Book Name: ");
            string currBook = Console.ReadLine();
            while (string.IsNullOrEmpty(currBook))
            {
                Console.WriteLine("Please Provide Any Book Name");
                currBook = Console.ReadLine();
            }
            lib.Add(currBook);
            Console.WriteLine("Your Book Was Added\n");
        }
    }
}
