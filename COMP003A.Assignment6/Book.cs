using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Assignment6
{
	internal class Book
	{
		// store the state of the book
		public string Title;
		public int Pages;
		public bool Completed;

		// Initializes all fields when a new Book object is created
		public Book(string title, int pages, bool completed)
		{
			Title = title;
			Pages = pages;
			Completed = completed;
		}

		// Display method
		public void Display()
		{
			Console.WriteLine($"Title={Title}, Pages={Pages}, Completed={Completed}");
		}
		// Action method
		public void ToggleCompleted()
		{
			Completed = !Completed;
		}
	}
}
