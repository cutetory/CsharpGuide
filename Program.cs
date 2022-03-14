using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGuide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string_practice.test_fun();
            collection_practice.test_fun();
        }
    public class string_practice
    { 
        public static void test_fun()
        {
            //사용 할 변수들
            string aFriend = "Maria";
            string firstFriend = "Mason";
            string secondFriend = "Sage";
            string greeting = "      Hello World!       ";
            string trimmedGreeting = greeting;
            string songLyrics = "You say goodbye, and I say hello";
            var result = songLyrics.Contains("goodbye");

            //method(함수) 만들어보기
            string fun(string temp1, string temp2)
            {
                string temp3 = temp1 + temp2;
                return temp3;
            }

            Console.WriteLine("Hello " + aFriend);

            // +로 합치는 것보다 $(문자열보간/String interpolation)을 권장합니다.

            Console.WriteLine($"Hello {aFriend}");

            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");

            Console.WriteLine($"띄어쓰기 전:[{greeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"띄어쓰기 후:[{trimmedGreeting}]");

            string replaceTest = fun("test", " success");
            replaceTest = replaceTest.Replace("test", "Programming");
            Console.WriteLine(replaceTest);

            Console.WriteLine(result);

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
        }
    }

    public class collection_practice
    {
        public static void test_fun()
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            names.Add("Maria");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"두번째는 {names[1]}");

            var index = names.IndexOf("Maria");
            Console.WriteLine($"{names[index]}는 {index + 1}번째");
        }
    }
    }
}
