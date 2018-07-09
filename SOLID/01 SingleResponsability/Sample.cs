using System;

namespace SOLID._01_SingleResponsability
{
    public class Sample
    {
        public void Sum(int a, int b)
        {
            var c = a + b;
            var m = "";
            if (c > 0 && c <= 10) m = "Value between 0 and 10";
            else if (c > 10 && c <= 20) m = "Value between 11 and 20";
            else if (c > 20 && c <= 30) m = "Value between 11 and 20";
            Console.WriteLine(string.Format("The sum is: {0} and is in range {1}", c, m));
        }
    }
}
