namespace Solid.OpenClosed
{
    public interface IEmployee
    {
        void CalculateSalary();
    }
    public class PartTimeEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            System.Console.WriteLine("Part");
        }
    }
    public class SupportEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            System.Console.WriteLine("Support");
        }
    }
    public class SalaryCalculator
    {
        private readonly IEmployee employee;
        public SalaryCalculator(IEmployee emp)
        {
            this.employee = emp;
        }

        public void CalculateSalary()
        {
            this.employee.CalculateSalary();
        }

    }
}