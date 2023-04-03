// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

var oMyName = new Book("Hernan", "Di Tano", 1983, "Accion", "El Quinto Elemento", new int[] {2,3,4,5});
Console.WriteLine(oMyName.FullName("Sasa"));
int [] myArray = {2, 3, 4, 5, 6};
Book.Array(myArray);
Console.ReadLine();

namespace ConsoleApp2
{
    class Book
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int YearOfRelease { get; private set; }
        public string Genre { get; private set; }
        public string NameOfBook { get; private set; }
        public int[] myArray { get; private set; }

        public Book(string myname, string myLastName, int year, string genre, string nameBook, int[] array)
        {
            Name = myname;
            LastName = myLastName;
            YearOfRelease = year;
            Genre = genre;
            NameOfBook = nameBook;
            myArray = array;
        }

        public string FullName(string result)
        {
            string my_book =
                $"The Book is named {NameOfBook} of Genre: {Genre}, Released in {YearOfRelease}. Written by {Name} {LastName}";
            return my_book;
        }

        public static void Array(int[] arr)
        {
            Console.WriteLine(arr);
                for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i);
            }
        }

       

    }
}


