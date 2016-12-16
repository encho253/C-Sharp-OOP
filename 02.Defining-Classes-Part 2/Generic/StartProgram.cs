namespace Generic
{
    using System;

    public class StartProgram
    {
        static void Main()
        {
            GenericList<string> listArray = new GenericList<string>();
            listArray.Add("5");
            listArray.Add("55");
            listArray.Add("555");
            listArray.Add("5555");
            listArray.Add("55555");
            listArray.Add("555555");
            listArray.Add("5555555");

            listArray.RemoveAt(6);

            foreach (var item in listArray.ListArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
