using System.Collections.Generic;

namespace FizzBuzzLibrary {

    public interface IFizzBuzzGenerator {

		int LowerBounds { get; set; }
		int UpperBounds { get; set; }
		Dictionary<int, string> DivisibleByList { get; set; }
		string Generate();

    }

}
