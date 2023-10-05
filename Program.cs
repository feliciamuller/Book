using System.Reflection;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv titeln på boken: ");
            string title = Console.ReadLine();

            Console.WriteLine("Skriv författaren av boken: ");
            string author = Console.ReadLine();

            Console.WriteLine("Skriv en summering av boken: ");
            string summary = Console.ReadLine();

            //create objekt of the class Book 
            Book myBook = new Book(title, author, summary);

            //calls method
            myBook.PrintBookInfo();

        }
    }
}