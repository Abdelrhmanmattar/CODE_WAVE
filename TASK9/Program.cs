
namespace ConsoleApp16
{
    class Program
    {
        public static void Main(string[] args)
        {
            Run_task1();
            Run_task2();
            Run_task3();
            Run_task4();
        }

        private static void Run_task1()
        {
            //1-Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            /*
             * in this code it will try to convert string to int using parse 
             * but it will found some chars can't convert to intgers 
             * so it will throw exception and excute catch scoope
             */
            string str = "data123";
            try
            {
                int num = int.Parse(str);
                Console.WriteLine($"Convert Done {num}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can't Convert");
            }
        }

        private static void Run_task2()
        {
            //2-Write C# program that Extract a substring from a given string.

            /*
             * substring function use to take index of first char based on 0
             * and length will take start from this index
             * 
             */
            string str2 = "my code is working!!!";
            string sub = str2.Substring(3, 4);
            Console.WriteLine($"\nsub : {sub}");
        }
        private static void Run_task3()
        {
            //3-Write C# program that take two string variables and print them as one variable

            string s1 = "abdelrhman";
            string s2 = "mattar";
            Console.WriteLine($"\n{s1} {s2}");
        }
        private static void Run_task4()
        {
            //4. Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a
            //variable then display the
            Console.Write("enter temp value:");
            string str_temp = Console.ReadLine();
            try
            {
                int temp = int.Parse(str_temp);
                string result = temp < 10 ? "Just Cold" :
                                temp > 30 ? "Just Hot" : "Just Good";

                Console.WriteLine($"\n temp is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("you enter wrong input");
            }
        }
    }
}
