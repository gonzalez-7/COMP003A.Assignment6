namespace COMP003A.Assignment6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// this tracks books and lets the user display the books or update one using a menu loop
			Book book1 = new Book("Atomic Habits", 320, false);
			Book book2 = new Book("Clean Code", 464, true);
			Book book3 = new Book("The Pragmatic Programmer", 352, false);

			int choice = 0;

			do
			{
				Console.WriteLine("1. Display All");
				Console.WriteLine("2. Update One Item");
				Console.WriteLine("3. Exit");
				Console.Write("Enter choice: ");

				choice = int.Parse(Console.ReadLine());
			}
		}
	}
}
