using System;
using System.Linq;
using System.Threading;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int counter = 0;
            foreach (char x in str)
            {
                if (x == letter)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
