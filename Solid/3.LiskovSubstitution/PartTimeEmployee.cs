namespace Solid.LiskovSubsitution
{
    public class Employee
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? lastname { get; set; }
    }
    public class PartTimeEmployee : Employee
    {
        public decimal DailyWage { get; set; }
    }
    public class FullTimeEmployee : Employee
    {
        public decimal HourWage { get; set; }
    }
}