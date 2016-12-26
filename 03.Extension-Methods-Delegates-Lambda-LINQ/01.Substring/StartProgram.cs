namespace Substring
{
    using System.Text;
    using System;

    public class StartProgram
    {
        public static void Main()
        {
            string text = "pesho";
            var builder = new StringBuilder();

            builder = text.SubstringMethod(0,3);

            Console.WriteLine(builder);
        }
    }
}
