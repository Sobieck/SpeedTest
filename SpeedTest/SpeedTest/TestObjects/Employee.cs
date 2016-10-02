using SpeedTest.Interfaces;

namespace SpeedTest.TestObjects
{
    public class Employee : IEmployee
    {
        public int EmployeeNumber { get; set; }
        public string Name { get; set; }
        public decimal PayPerHour { get; set; }
        public string Position { get; set; }
    }
}
