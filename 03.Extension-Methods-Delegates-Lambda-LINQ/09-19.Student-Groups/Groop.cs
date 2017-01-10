//Problem 16.* Groups
namespace _09.Student_Groups
{
    public class Groop
    {
        public Groop(string groopNumber)
        {
            this.GroupNumber = groopNumber;
        }

        public Groop(string groopNumber,string departName) : this(groopNumber)
        {
            this.DepartmentName = departName;
        }

        public string GroupNumber { get; set; }
        public string DepartmentName { get; set; }
    }
}
