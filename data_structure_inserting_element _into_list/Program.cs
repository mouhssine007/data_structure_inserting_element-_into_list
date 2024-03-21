using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_inserting_element__into_list
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// list intialization 
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			// adding an element at the end 
			numbers.Add(11);
			Console.WriteLine("after adding 11 : " + string.Join(",",numbers));
			// insertinh an element at a specific position 
			numbers.Insert(0, 0);
			Console.WriteLine("after inserting at the 0 of the begining " + string.Join(",", numbers));
			// inserting multipple elements 
			numbers.InsertRange(5,new List<int> { 55,44});
			Console.WriteLine("after inseting 55 and 44 at the index 5 : " + string.Join(",", numbers));

			Console.ReadLine();
		}
	}
}
