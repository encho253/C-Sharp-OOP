using System.Text;

namespace Mobile_Phone_Device
{
    public class Display
    {
        private double? size;
        private string numberOfColors;

        public Display()
        {

        }       
        public Display(double? size,string colors)
        {
            this.Size = size;
            this.NumberOfColors = colors;
        }
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public string NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Display Size: ").Append(this.Size).Append("\r\n");
            builder.Append("Display Colors: ").Append(this.NumberOfColors).Append("\r\n");
            return builder.ToString();
        }
    }
}
