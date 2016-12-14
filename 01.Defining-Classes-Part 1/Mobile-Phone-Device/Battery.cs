using System.Text;

namespace Mobile_Phone_Device
{
    public class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;

        public Battery()
        {

        }
        public Battery(BatteryType type)
        {
            this.Type = type;
        }
        public Battery(BatteryType type, string model)
            :this(type)
        {
            this.Model = model;
        }
        public Battery(BatteryType type,string model, double hIdle, double hTalk)
           :this(type,model)         
        {           
            this.HoursIdle = hIdle;
            this.HoursTalk = hTalk;
        }       
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }
        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Battery Hours Idle: ").Append(this.HoursIdle).Append("\r\n");
            builder.Append("Battery Hours Talk: ").Append(this.HoursTalk).Append("\r\n");
            builder.Append("Battery Model: ").Append(this.Model).Append("\r\n");
            builder.Append("Battery Type: ").Append(this.Type).Append("\r\n");

            return builder.ToString();
        }
    }
}