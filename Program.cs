using System;

namespace finding_indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "I like cheese";

            int i = 0; // start index

            // loop until we explicitly break
            while (true)
            {
                // check for an e startingf at index i
                i = s.IndexOf("e", i);

                if (i == -1)
                    break; // no more e's
                else
                    Console.WriteLine($"Found an e at index: {i}");

                // move to the next index after the e we found.
                i++;

            }
        }
    }
}