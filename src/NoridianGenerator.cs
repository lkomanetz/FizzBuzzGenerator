using System;
using System.Collections.Generic;

namespace FizzBuzzLibrary {

    public class NoridianGenerator : IFizzBuzzGenerator {

        public NoridianGenerator(int lower, int upper) {
            this.DivisibleByList = new Dictionary<int, string>();
            this.UpperBounds = upper;
            this.LowerBounds = lower;
        }

        public Dictionary<int, string> DivisibleByList { get; set; }
        public int LowerBounds { get; set; }
        public int UpperBounds { get; set; }

        public string Generate() {
            if (this.DivisibleByList.Count == 0) {
                throw new Exception("DivisibleByList cannot be empty.");
            }

            string output = String.Empty;
            for (int i = LowerBounds; i <= UpperBounds; ++i) {
                string divisibleByValue = String.Empty;
                if (i % 2 == 0) {
                    divisibleByValue += DivisibleByList[2];
                }

                if (i % 7 == 0) {
                    divisibleByValue += DivisibleByList[7];
                }

                if (divisibleByValue == String.Empty) {
                    divisibleByValue = i.ToString();
                }

                output += $"{divisibleByValue}\n";
            }

            return output;
        }

    }

}