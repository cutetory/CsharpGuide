using System;
using System.Text;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            /*
    3의 배수 fizz 5의 배수 buzz 3,5(15의배수)의 배수는 FizzBuzz
    Stringbuilder와 문자열 보간 기능을 사용했음.
    fizzArray는 int형 배열, fizzArray_string은 최종 출력 될 배열
*/
            int[] fizzArray = new int[100];
            string[] fizzArray_string = new string[100];

            for (int i = 0; i < fizzArray.Length; i++)
            {
                fizzArray[i] = i + 1;

                if (fizzArray[i] % 3 == 0 || fizzArray[i] % 5 == 0)
                {
                    if (fizzArray[i] % 3 == 0 && fizzArray[i] % 5 != 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        fizzArray_string[i] = sb.Append($"{fizzArray[i]} - Fizz").ToString();
                    }
                    else if (fizzArray[i] % 5 == 0 && fizzArray[i] % 3 != 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        fizzArray_string[i] = sb.Append($"{fizzArray[i]} - Buzz").ToString();
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        fizzArray_string[i] = sb.Append($"{fizzArray[i]} - FizzBuss").ToString();
                    }
                }
                else
                {
                    fizzArray_string[i] = fizzArray[i].ToString();
                }

                Console.WriteLine(fizzArray_string[i]);
            }

        }
    }
}
