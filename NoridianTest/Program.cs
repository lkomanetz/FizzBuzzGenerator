
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLibrary;

namespace NoridianTest {
	public class Program {

		static void Main(string[] args) {
			IFizzBuzzGenerator generator = new NoridianGenerator(1, 100);
			Console.Write(generator.Generate());
			Console.ReadLine();
		}

	}

}