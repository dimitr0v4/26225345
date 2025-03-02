namespace _262255
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
             Univerity test=new University {new Student("georgi",360),new Student("mila",400),new Student("alex",300) };
            Student s=new Student("dimitar",370);
            test.AddStudent(s);
            Console.WriteLine(test.FindByScore(360));
        }
    }
}
