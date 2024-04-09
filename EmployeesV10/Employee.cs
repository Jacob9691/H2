
namespace EmployeesV10
{
    public class Employee
    {
        #region Properties
        public string Name { get; set; }
        public int HoursPerWeek { get; set; }
        #endregion

        #region Constructor
        public Employee(string name, int hoursPerWeek)
        {
            Name = name;
            HoursPerWeek = hoursPerWeek;
        }
        #endregion
    }
}
