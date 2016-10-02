namespace SpeedTest.Interfaces
{
    public interface IEmployee
    {
        int EmployeeNumber { get; set; }
        string Name { get; set; }
        decimal PayPerHour { get; set; }
        string Position { get; set; }
    }
}
