namespace Mobile_Phone_Device
{
    using System;

    public class Start
    {
        public static void Main()
        {
            GSM phoneOne = new GSM("Galaxy S6", "Samsung");

            Console.WriteLine(phoneOne.ToString());

            GSMTest printPhones = new GSMTest();
            printPhones.PrintPhones();

            printPhones.DisplayInfoIphone4S();
                        
            GSMCallHistoryTest.TestCallHistory();
        }
    }
}