namespace Generic
{
    using System;

    public class StartProgram
    {
        public static void Main()
        {
            GenericList<string> listArrayString = new GenericList<string>();

            listArrayString.Add("Stoqncho");
            listArrayString.Add("Ivancho");
            listArrayString.Add("Dragancho");
            listArrayString.Add("Petkancho");
            listArrayString.Add("Toshancho");
            listArrayString.Add("Goshancho");
            listArrayString.Add("Trifonancho");
            Console.WriteLine("Print List after added some elements");
            Console.WriteLine(listArrayString.ToString());

            Console.WriteLine("Min element {0}", listArrayString.Min());
            Console.WriteLine("Max element {0}", listArrayString.Max());

            listArrayString[1] = "Ivan";
            Console.WriteLine("List after set element at given position");
            Console.WriteLine(listArrayString.ToString());

            int index = listArrayString.IndexOf("Petkancho");
            Console.WriteLine("Print index by its value");
            Console.WriteLine("Index of: {0}", index);

            listArrayString.RemoveAt(6);
            listArrayString.RemoveAt(4);
            listArrayString.RemoveAt(2);
            Console.WriteLine("After remove some elements from the List");
            Console.WriteLine(listArrayString.ToString());

            listArrayString.Clear();
            Console.WriteLine("Print List after List.Clear() method:");
            Console.WriteLine(listArrayString.ToString());

            Console.WriteLine("Create new GinericList from integers");

            GenericList<int> listArrayInt = new GenericList<int>();
            listArrayInt.Add(5);
            listArrayInt.Add(55);
            listArrayInt.Add(555);
            listArrayInt.Add(5555);
            Console.WriteLine("Print List after added some elements");
            Console.WriteLine(listArrayInt.ToString());

            Console.WriteLine("Min element {0}", listArrayInt.Min());
            Console.WriteLine("Min element {0}", listArrayInt.Max());

            listArrayInt[1] = 666;
            Console.WriteLine("List after set element at given position");
            Console.WriteLine(listArrayInt.ToString());

            int indexInt = listArrayInt.IndexOf(555);
            Console.WriteLine("Print index by its value");
            Console.WriteLine("Index of: {0}", indexInt);

            listArrayInt.RemoveAt(1);
            listArrayInt.RemoveAt(2);
            listArrayInt.RemoveAt(0);
            Console.WriteLine("After remove some elements from the List");
            Console.WriteLine(listArrayInt.ToString());

            listArrayInt.Clear();
            Console.WriteLine("Print List after List.Clear() method:");
            Console.WriteLine(listArrayInt.ToString());
        }
    }
}
