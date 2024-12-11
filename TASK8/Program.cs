
namespace CODE_WAVE_8
{

    class Program
    {

        public static void Main(string[] args)
        {
            RunTask1();
            Console.WriteLine("===========================================================");
            RunTask2();
            Console.WriteLine("===========================================================");
            RunTask3();
            Console.WriteLine("===========================================================");
        }

        private static void RunTask3()
        {
            try
            {
                Console.Write("enter first line:");
                int first = int.Parse(Console.ReadLine());

                Console.Write("enter second line:");
                int second = int.Parse(Console.ReadLine());

                Console.Write("enter third line:");
                int third = int.Parse(Console.ReadLine());

                bool result1 = (first > second) && (second > third);
                bool result2 = (first == second) && (second == third);
                bool result3 = ((first+second) == third);
                bool result4 = (first % second == 0) && (third % second == 0);
                bool result5 = (first == third) && (second != third);


                Console.WriteLine($"({first} > {second}) && ({second} > {third}) -> {result1}");
                Console.WriteLine($"({first} == {second}) && ({second} == {third}) -> {result2}");
                Console.WriteLine($"(({first} + {second}) == {third}) -> {result3}");
                Console.WriteLine($"({first} % {second} == 0) && ({third} % {second} == 0) -> {result4}");
                Console.WriteLine($"({first} == {third}) && ({second} != {third}) -> {result5}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }

        private static void RunTask2()
        {
            int result1 = -1 + 4 * 6;
            int result2 = (35 + 5) % 7;
            int result3 = 14 + -4 * 6 / 11;
            int result4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine("-1 + 4 * 6 = " + result1);
            Console.WriteLine("(35 + 5) % 7 = " + result2);
            Console.WriteLine("14 + -4 * 6 / 11 = " + result3);
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + result4);
        }

        private static void RunTask1()
        {
            try
            {
                Console.Write("enter first line:");
                int first = int.Parse(Console.ReadLine());

                Console.Write("enter second line:");
                int second = int.Parse(Console.ReadLine());

                Console.WriteLine($"{first} + {second} = {first + second}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}