using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzLibrary {
	public interface IFizzBuzzGenerator {
		int LowerBounds { get; set; }
		int UpperBounds { get; set; }
		Dictionary<int, string> DivisibleByList { get; set; }
		string Generate();
	}
}
