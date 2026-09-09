using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Notes_service
{
	public class Program
	{
		class Note
		
			string name;
			string description;
			int priorites;

			public Note(int priorites, string name) 
			{
				this.priorites = priorites;
				this.name = name;
			}

			public Note(int priorites, string name, string description)
			{
				this.priorites = priorites;
				this.name = name;
				this.description = description;
			}

			public void show_note() 
			{
				Console.WriteLine($"{name}\n{description}\nПриоритет: {priorites}");
			}
		}
		public static void Main(string[] args)
		{
			Note obj1 = new Note(1,"Заметка 1","Моя первая Заметка");
			obj1.show_note();
		}
	}
}
