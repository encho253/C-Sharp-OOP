namespace VersionАttribute
{
    using System;

    public class StartMain
    {
        public static void Main()
        {
            var programVersion = typeof(Program).GetCustomAttributes(false);

            foreach (var item in programVersion)
            {
                var version = (AssemblyVersionAttribute)item;
                Console.WriteLine(version.Version);
            }                           
        }
    }
}
