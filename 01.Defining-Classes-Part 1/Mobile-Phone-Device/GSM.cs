namespace Mobile_Phone_Device
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        public static readonly GSM iphone4s = new GSM("Iphone 4S", "Apple", new Battery(BatteryType.NiMH), new Display());
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery batteryInfo;
        private Display displayInfo;
        private List<Call> callHistory;
      
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }
        public GSM(string model, string manufacturer, Battery batteryInfo, Display displayInfo)
            :this(model,manufacturer)
        {         
            this.BatteryInfo = batteryInfo;
            this.DisplayInfo = displayInfo;
        }
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery batteryInfo, Display displayInfo)
            : this(model, manufacturer, batteryInfo, displayInfo)
        {
            this.Price = price;
            this.Owner = owner;
        } 
                   
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Enter valid model name!");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Enter valid manufacturer!");
                }
                this.manufacturer = value;
            }
        }
        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery BatteryInfo
        {
            get
            {
                return this.batteryInfo;
            }
            set
            {
                this.batteryInfo = value;
            }
        }
        public Display DisplayInfo
        {
            get
            {
                return this.displayInfo;
            }
            set
            {
                this.displayInfo = value;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                this.callHistory = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("Model: ").Append(this.Model).Append("\r\n");
            builder.Append("Manufacturer: ").Append(this.Manufacturer).Append("\r\n");
            builder.Append("Price: ").Append(this.Price).Append("\r\n");                  
            builder.Append("Owner: ").Append(this.Owner).Append("\r\n");

            if (BatteryInfo != null)
            {
                builder.Append(this.BatteryInfo.ToString());
            }
            else
            {
                builder.Append("Battery Hours Idle: ").Append("\r\n");
                builder.Append("Battery Hours Talk: ").Append("\r\n");
                builder.Append("Battery Model: ").Append("\r\n");
                builder.Append("Battery Type: ").Append("\r\n");
            }

            if (DisplayInfo != null)
            {
                builder.Append(this.DisplayInfo.ToString());
            }
            else
            {
                builder.Append("Display Size: ").Append("\r\n");
                builder.Append("Display Colors: ").Append("\r\n");
            }       
          
            return builder.ToString();
        }
        public void AddCallHistory(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void DeleteCallHistory(int index)
        {
            this.CallHistory.Remove(callHistory[index]);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        public void PrintCallHistory()
        {
            foreach (var item in CallHistory)
            {
                Console.WriteLine(item);
            }
        }
        public void CallPrice()
        {
            double sum = 0;

            for (int i = 0; i < callHistory.Count; i++)
            {
                sum += (CallHistory[i].Duration / 60) * 0.37;
            }
            Console.WriteLine("The Total price is {0:F2} lv",sum);
        }
    }
}
