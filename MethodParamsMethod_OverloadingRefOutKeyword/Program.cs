using System;
using System.Linq;

namespace MethodParamsMethod_OverloadingRefOutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Add();
            //    var result = Add2(20);

            //    int number1 = 20;
            //    int number2 = 100;
            //    var result2 = Add3(number1, number2);
            //    // yazarken referans tip oluyor. Add3 te methodun içindeki number1 kullanılır fakat gösterilen değer tip olur yani ana programa yazılan
            //    // Ayrıca burada ref int ve out int kullanılabilir buna keyword denir. ayrıntıla olarak bakabiliriz.
            //    Console.WriteLine(result2);
            //   Console.WriteLine(number1);
            // Console.WriteLine(Multiply(2,5,6));

            Console.WriteLine(Add4(5, 8, 9, 6, 3, 2, 10));
            Console.ReadLine();

        }

        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;

        }

        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        //Params Keyword
        static int Add4(params int[] numbers)   //static int Add4(int number, params int[] numbers)   diye kullanabilir..
        {
            return numbers.Sum();
        }
    }
}
