namespace Mobile_Phone_Device
{
    using System;
    using System.Text;

    public class Call
    {
        public DateTime Date { get; private set; }
        public string DialledPhoneNumber { get; private set; }
        public double Duration { get; private set; }
        public GSM Phone { get; private set; }

        public Call(GSM phone,DateTime date,string dialledPhoneNumber,double duration)
        {
            this.Phone = phone;
            this.Date = date;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Model: ").Append(Phone.Model).Append("\r\n");
            builder.Append("Manufacturer: ").Append(Phone.Manufacturer).Append("\r\n");
            builder.Append("Date: ").Append(Date).Append("\r\n");
            builder.Append("Dialled Phone Number: ").Append(DialledPhoneNumber).Append("\r\n");
            builder.Append("Duration: ").Append(Duration).Append("\r\n");
                  
            return builder.ToString();
        }
    }
}