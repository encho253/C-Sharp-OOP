namespace Mobile_Phone_Device
{
    using System;

    public class GSMTest
    {
        public void PrintPhones()
        {
            GSM[] mobilePhones = this.CreatePhones();
            foreach (var item in mobilePhones)
            {
                Console.WriteLine(item);
            }
        }

        public GSM[] CreatePhones()
        {
            GSM[] mobilePhones =
            {
                new GSM("GALAXY S7 Edge", "SAMSUNG", new Battery(BatteryType.LiIon), new Display()),
                new GSM("G5", "LG", 800, "Encho Enevski", new Battery(BatteryType.NiCd), new Display(5.2, "16M")),
                new GSM("M2", "Sony", 200, "Encho Enevski", new Battery(BatteryType.LiIon, "HS4-555", 80, 20), new Display(5, "16M")),
                new GSM("P9", "Huawei")
            };

            return mobilePhones;
        }

        public void DisplayInfoIphone4S()
        {
            Console.WriteLine(GSM.Iphone4s);
        }
    }
}