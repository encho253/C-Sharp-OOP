namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartProgram
    {
        static void Main()
        {
            List<string> collection = new List<string>()
            {
                "Hello",
                "How Are You",
                "Mecho"
            };
            string maxString = collection.MaxLenghtOfString();
            Console.WriteLine(maxString);
        }
    }
}
