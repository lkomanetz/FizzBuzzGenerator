using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLibrary;
using System.Collections.Generic;

namespace FizzBuzzLibrary.UnitTests {

	[TestClass]
	public class UnitTest1 {

		IFizzBuzzGenerator _generator;

		[TestInitialize]
		public void Initialize() {
			_generator = new NoridianGenerator();
			_generator.LowerBounds = 1;
			_generator.UpperBounds = 10;
			_generator.DivisibleByList = new Dictionary<int, string>() {
				{ 2, "Cross" },
				{ 7, "Shield" }
			};
		}
		[TestMethod]
		public void NoridianTest() {
			string generatedString = _generator.Generate();
			string expected = "1\nCross\n3\nCross\n5\nCross\nShield\nCross\n9\nCross";
			AssertOutput(expected, generatedString);
		}

		private void AssertOutput(string expected, string actual) {
			Assert.IsTrue(expected.Length == actual.Length, "Values are of different size");

			bool isTheSame = false;
			string[] expectedArray = expected.Split('\n');
			string[] actualArray = actual.Split('\n');

			for (int i = 0; i < expectedArray.Length; i++) {
				isTheSame = expectedArray[i].Equals(actualArray[i]);

				if (!isTheSame) {
					break;
				}
			}

			Assert.IsTrue(isTheSame, "Values are not the same.");
		}
	}
}
