
using Ldl1;

internal class Program
{
    static Library library = new Library();

    static void Main(string[] args)
    {
        byte abc = 1;
        string nyes;
        string nno;

    exe:
        Console.WriteLine("What would you like to execute?");
        while (abc != 0)
        {
            Console.WriteLine("1) Add a book?");
            Console.WriteLine("2) Remove a book?");
            Console.WriteLine("3) Display all books in the library?");
            Console.WriteLine("4) End");
            try{
                nno = Console.ReadLine();
                
                switch (nno)
                {
                    case "1":library.AddBook(); break;
                    case "2":library.Remove(); break;
                    case "3":library.Display(); break;
                    case "4":abc = 0; break;
                } 
                
            } 
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); goto exe;
            }        

        nyes:
            Console.WriteLine("Would you like to continue? (yes/no)");
            nyes = Console.ReadLine();
            if (nyes == "no") { abc = 0; }
            else if (nyes == "yes") { abc = 1; goto exe; }
            else { Console.WriteLine("Write again"); goto nyes; }
        }
    }
}
