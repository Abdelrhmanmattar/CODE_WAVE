namespace CODE11_2
{
    public struct Person
    {
        public string Name;
        public int Age;
        public Person(string name , int age)
        {
            this.Name = name;   this.Age = age;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Person[] people = new Person[3];
            Person oldest = new Person(string.Empty, int.MinValue);
            string name;    int age;
            for(int i=0;i<3;i++)
            {
                name = Console.ReadLine();
                age=int.Parse(Console.ReadLine());
                people[i]=new Person(name,age);
                Console.WriteLine($"person {i+1} added");
                if (people[i].Age>oldest.Age)
                    oldest = people[i];
            }
            Console.WriteLine($"Oldest {oldest.Name} is {oldest.Age}");
        }
    }
}