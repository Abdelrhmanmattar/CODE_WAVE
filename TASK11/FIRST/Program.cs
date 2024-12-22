namespace CODE11
{
    class Program
    {
        public static void Main(string[] args)
        { 
            Employee employee1 =
                new Employee(Guid.NewGuid(), "Abdelrhman", Security.Guest, 15000, DateTime.Now, "M");

            Employee employee2 =
                new Employee(Guid.NewGuid(), "Omar", Security.DBA, 12000, new DateTime(2023,12,20), "M");

            Employee employee3 =
                new Employee(Guid.NewGuid(), "Reem", Security.Secretary, 10000, new DateTime(2020, 11, 15), "F");

            Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Console.WriteLine(employee3);

            Console.ReadKey();
        }
    }
}