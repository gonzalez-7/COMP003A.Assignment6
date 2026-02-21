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

				switch (choice)
				{
					case 1:
						Console.Write("Item 1: ");
						book1.Display();

						Console.Write("Item 2: ");
						book2.Display();

						Console.Write("Item 3: ");
						book3.Display();

						Console.WriteLine();
						break;
					case 2:
						Console.Write("Select item (1-3); ");
						int itemChoice = int.Parse(Console.ReadLine());

						switch (itemChoice)
						{
							case 1:
								book1.ToggleCompleted();
								Console.WriteLine("Updated Item 1.");
								break;
							case 2:
								book2.ToggleCompleted();
								Console.WriteLine("Updated Item 2.");
								break;
							case 3:
								book3.ToggleCompleted();
								Console.WriteLine("Updated Item 3.");
								break;
						}
						Console.WriteLine();
						break;
					case 3:
						Console.WriteLine("Program ended.");
						break;
				}
			} while (choice != 3);
		}
	}
}
