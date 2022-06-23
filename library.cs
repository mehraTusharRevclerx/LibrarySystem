using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class library<T>
    {
        List<T> Books = new List<T>();


        public void Add(T item)
        {
            Books.Add(item);
            //if (count + 1 < Books.Count)
            //{
            //};

        }
        public T this[int index]
        {
            get { return this[index]; }
            set { this[index] = value; }
        }
        public void TotalBooksCount()
        {
            Console.WriteLine($"Total Book Count in Library is {Books.Count}");
        }

        public void DisplayAllBooks()
        {
            if (Books.Count <= 0)
            {
                Console.WriteLine("Library Does Not Contains Any Book Sorry :(");
                return;
            }
            else
            {
                Console.WriteLine($"\nAll Books Are Listed Down Below\n");
                int count = 1;
                foreach (var i in Books)
                {
                    Console.WriteLine($"{count}. {i}");
                    count++;
                }


            }
        }

        public void RemoveBookByIndex()
        {

            if (Books.Count <= 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Which Book You Want To Remove");
                string bookIndexs = Console.ReadLine();
                int bookIndex;
                while (!int.TryParse(bookIndexs, out bookIndex))
                {
                    bookIndexs = Console.ReadLine();
                }
                Books.RemoveAt(bookIndex - 1);
                Console.WriteLine("Your Book Was Removed SuccessFully");
            }
        }

    }
}
