namespace CODE11_3
{
    public class Hire_Date
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }

        public override string ToString()
        {
            return $"{this.year}/{this.month}/{this.day}";
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Hire_Date date = new Hire_Date { year = 2015, month = 10, day = 1 };
            Console.WriteLine(date);
        }
    }
}