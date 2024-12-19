
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAY10
{
    public class EX_2
    {
        public int value { get; set; }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int taskChoice = 0;
            while(taskChoice != 7)
            {
                taskChoice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (taskChoice)
                {
                    case 1:
                        TASK1();
                        break;
                    case 2:
                        TASK2();
                        break;
                    case 3:
                        TASK3();
                        break;
                    case 4:
                        TASK4();
                        break;
                    case 5:
                        TASK5();
                        break;
                    case 6:
                        TASK6();
                        break;
                    case 7:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter a number between 1 and 7.");
                        break;
                }
            }
        }

        public static void TASK1()
        {
            //-Explain the difference between passing (Value type parameters)
            //by value and by reference then write a suitable c# example.
            int data = 10;
            Console.WriteLine($"data before VALUE_Typeby_val    {data} ");
            TASKClass.VALUE_Typeby_val(data);
            Console.WriteLine($"data after VALUE_Typeby_val     {data} ");

            TASKClass.VALUE_Typeby_ref(ref data);
            Console.WriteLine($"data after VALUE_Typeby_ref     {data} ");
        }

        public static void TASK2()
        {
            //-Explain the difference between passing(Reference type parameters)
            //by value and by reference then write a suitable c# example.
            EX_2 ex = new EX_2 { value= 10 };

            Console.WriteLine($"ex before {ex.value}        {ex.GetHashCode()}");
            TASKClass.Ref_typeby_val(ex);
            Console.WriteLine($"ex after {ex.value}        {ex.GetHashCode()}");

            TASKClass.Ref_typeby_ref(ref ex);
            Console.WriteLine($"ex after {ex.value}        {ex.GetHashCode()}");
        }

        public static void TASK3()
        {
            //-Create a function named "IsPrime"
            //, which receives an integer number and retuns true if it is prime, or false if it is not:
            Console.WriteLine(TASKClass.IsPrime(20));

            Console.WriteLine(TASKClass.IsPrime(13));
        }

        public static void TASK4()
        {
            //-Create a function named MinMaxArray, to return the minimum and maximum values
            //stored in an array, using reference parameters

            List<int> ints = new List<int>() { 5, 10, 2, 30, 70 };
            int max, min;
            TASKClass.MinMaxArray(ref ints, out min, out max);
            Console.WriteLine($"{max}       {min}");
        }
        public static void TASK5()
        {

            TrafficLightController trafficLight = new TrafficLightController();
            foreach(var item in Enum.GetValues(typeof(TrafficLight)))
            {
                trafficLight.DisplaySignal((TrafficLight)item);
            }
        }

        public static void TASK6()
        {
            OrderController orderController = new OrderController();
            foreach (var item in Enum.GetValues(typeof(OrderStatus)))
            {
                orderController.DisplayOrderStatus((OrderStatus)item);
            }
        }
    }

}