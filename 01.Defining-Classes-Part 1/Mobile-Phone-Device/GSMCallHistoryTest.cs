namespace Mobile_Phone_Device
{
    using System;

    public class GSMCallHistoryTest
    {
       public static void TestCallHistory()
        {
            GSM phoneOne = new GSM("Galaxy S6", "Samsung");

            Call first = new Call(phoneOne, DateTime.Now, "0876050549", 123);
            phoneOne.AddCallHistory(first);

            Call second = new Call(phoneOne, DateTime.Now, "0876050548", 200);
            phoneOne.AddCallHistory(second);

            Call third = new Call(phoneOne, DateTime.Now, "0876980549", 250);
            phoneOne.AddCallHistory(third);
                        
            phoneOne.PrintCallHistory();
            Console.WriteLine("***************************");
            phoneOne.CallPrice();
            Console.WriteLine("***************************");

            phoneOne.DeleteCallHistory(2);
            phoneOne.PrintCallHistory();
            Console.WriteLine("***************************");
            phoneOne.CallPrice();
            Console.WriteLine("***************************");

            phoneOne.ClearCallHistory();
            phoneOne.PrintCallHistory();      
        }
    }
}
