using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzLibrary {
	public class SanfordGenerator : IFizzBuzzGenerator {
		private Dictionary<int, string> _divisibleByList;
		private int _lowerBounds;
		private int _upperBounds;

		public SanfordGenerator() {
			_divisibleByList = new Dictionary<int, string>() {
				{ 3, "Sanford" },
				{ 5, "Health" }
			};
		}

		public SanfordGenerator(int lowerBounds, int upperBounds)
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
			if (_divisibleByList == null ||
				_divisibleByList.Count == 0) {
				throw new Exception("DivisibleByList property not implemented.");
			}

			StringBuilder sb = new StringBuilder();

			for (int i = _lowerBounds; i <= _upperBounds; i++) {
				string divisibleByValue = String.Empty;

				if (IsDivisibleBy(3, i)) {
					divisibleByValue += _divisibleByList[2];
				}

				if (IsDivisibleBy(5, i)) {
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
