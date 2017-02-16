using System;
using System.Collections.Generic;

namespace FizzBuzzLibrary {

    public class SanfordGenerator : IFizzBuzzGenerator {

        public SanfordGenerator(int lower, int upper) {
            this.DivisibleByList = new Dictionary<int, string>();    
            this.UpperBounds = upper;
            this.LowerBounds = lower;
        }

        public Dictionary<int, string> DivisibleByList { get; set; }
        public int LowerBounds { get; set; }
        public int UpperBounds { get; set; }

        public string Generate() {
            if (this.DivisibleByList.Count == 0) {
                throw new Exception("DivisibleByList cannot be zero.");
            }

            string output = String.Empty;
            for (int i = LowerBounds; i <= UpperBounds; ++i) {
                string divisibleByValue = String.Empty;

                if (i % 3 == 0) {
                    divisibleByValue += DivisibleByList[3];
                }

                if (i % 5 == 0) {
                    divisibleByValue += DivisibleByList[5];
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