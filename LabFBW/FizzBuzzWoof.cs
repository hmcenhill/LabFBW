using System;
using System.Collections.Generic;
using System.Text;

namespace LabFBW
{
    public class FizzBuzzWoof
    {
        public void Run()
        {
            for (var i = 1; i <= 1000; i++)
            {
                Console.WriteLine(Convert(i));
            }
        }
        public string Convert(int i)
        {
            var result = "";
            if (i % 3 == 0 || i.ToString().Contains("3"))
            {
                result += "Fizz";
            }
            if (i % 5 == 0 || i.ToString().Contains("5"))
            {
                result += "Buzz";
            }
            if (i % 7 == 0 || i.ToString().Contains("7"))
            {
                result += "Woof";
            }
            if (result == "")
            {
                return i.ToString();
            }
            return result;
        }
    }
}
