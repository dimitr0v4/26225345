namespace _262256
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
             Company c = new Company ();
            c.firm.Add(new Employee("georgi",3000));
            c.firm.Add(new Employee("mila", 3001));
            c.firm.Add(new Employee("alex", 3002));
            Console.WriteLine(c.FindEmployeeBySalary(3002));
        }
    }
}
