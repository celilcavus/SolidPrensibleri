namespace Solid.Customer
{
    public class Customer
    {
        public string? Name { get; set; }
    }

    public class CustomerValidator
    {
        public bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

    }

    public class CustomerManager
    {
        public void SayHello(string name)
        {
            System.Console.WriteLine("Hello" + name);
        }
    }

}