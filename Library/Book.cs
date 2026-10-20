using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{

    public class Book
    {
        // Private backing fields
        private string title;
        private string author;
        private int isbn;


        // Public properties
        public string Title
        {
            get { return title; }


            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set
            {
                // Ensure authorname does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot be blank or contain numbers.");
                }
            }
        }
        public int ISBN
        {
            get { return isbn; }
            set
            {
                // Validate ISBN entry and ensure it contains between 10 and 13 digits
                if (value < 0)
                {
                    Console.WriteLine("Error: ISBN must be non-negative.");
                }
                if ((value.ToString().Length < 10 || value.ToString().Length > 13))
                {
                    Console.WriteLine("Error: ISBN must contain between 10 and 13 digits.");
                }
                isbn = value;
            }
           
        }

        // Parameterised constructor
        public Book(string bookTitle, string bookAuthor, int bookIsbn)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookIsbn;
        }

        // Method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
    
