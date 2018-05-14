using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzzを開始します。");
            string FizzBuzz = "FizzBuzz";
            string Fizz = "Fizz";
            string Buzz = "Buzz";

            Console.WriteLine("任意の倍数で「Fizz」「Buzz」「FizzBuzz」と表示します。");

            Console.WriteLine("任意の倍数1を入力してください。");
            var NumberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("任意の倍数2を入力してください。");
            var NumberTwo = int.Parse(Console.ReadLine());

            for(int index = 1; index < 101; ++index)
            {
                if (index % NumberOne == 0 && index % NumberTwo == 0)
                {
                    Console.WriteLine(FizzBuzz);
                }
                else if (index % NumberOne == 0) 
                {
                    Console.WriteLine(Fizz);
                }
                else if (index % NumberTwo == 0)
                {
                    Console.WriteLine(Buzz);
                }
                else
                {
                    Console.WriteLine(index.ToString());
                }
            }
            Console.WriteLine("終了します");
            Console.ReadLine();
        }
    }
}
