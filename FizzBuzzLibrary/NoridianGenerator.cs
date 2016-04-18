using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary {

	public class NoridianGenerator : IFizzBuzzGenerator {
		private Dictionary<int, string> _divisibleByList;
		private int _lowerBounds;
		private int _upperBounds;

		public NoridianGenerator() {
			_divisibleByList = new Dictionary<int, string>();
		}

		public NoridianGenerator(int lowerBounds, int upperBounds)
			: this() {
			_lowerBounds = lowerBounds;
			_upperBounds = upperBounds;
		}

		public Dictionary<int, string> DivisibleByList {
			get { return _divisibleByList; }
			set { _divisibleByList = value; }
		}

		public int LowerBounds {
			get { return _lowerBounds; }
			set { _lowerBounds = value; }
		}

		public int UpperBounds {
			get { return _upperBounds; }
			set { _upperBounds = value; }
		}

		public string Generate() {
			StringBuilder sb = new StringBuilder();

			for (int i = _lowerBounds; i <= _upperBounds; i++) {
				string divisibleByValue = String.Empty;

				if (IsDivisibleBy(2, i)) {
					divisibleByValue += _divisibleByList[2];
				}

				if (IsDivisibleBy(7, i)) {
					divisibleByValue += _divisibleByList[7];
				}
				
				if (divisibleByValue == String.Empty) {
					divisibleByValue = Convert.ToString(i);
				}
				sb.Append(divisibleByValue + '\n');
			}

			return sb.ToString().Trim();
		}

		private bool IsDivisibleBy(int number, int value) {
			return (value % number) == 0;
		}
	}
}
