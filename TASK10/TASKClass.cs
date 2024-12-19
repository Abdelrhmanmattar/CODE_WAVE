using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAY10
{
    public static class TASKClass
    {
        public static void VALUE_Typeby_val(int val)
        {
            val++;
        }
        public static void VALUE_Typeby_ref(ref int val)
        {
            val++;
        }
        public static void Ref_typeby_val(EX_2 data)
        {
            data.value = 20;
            Console.WriteLine(data.value);
            data = new EX_2 { value = 50 };
        }

        public static void Ref_typeby_ref(ref EX_2 data)
        {
            data.value = 40;
            Console.WriteLine(data.value);
            data = new EX_2 { value = 70 };
        }

        public static void MinMaxArray(ref List<int> list , out int min , out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;
            foreach(var item in list)
            {
                if (item > max) max = item;
                if (item < min) min = item;
            }
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false; 
            if (number == 2) return true; 
            if (number % 2 == 0) return false;

            for(int i=3;i<Math.Sqrt(number);i++)
            {
                if(number%i== 0) return false;
            }
            return true;
        }
    }
}
