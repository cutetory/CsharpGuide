using System;

namespace reverse
{
    internal class Reverse
    {
        static void Main(string[] args)
        {
/*
    pangram에 들어있는 문장의 단어들을 거꾸로 출력하기. 단, 각 단어들의 순서는 그대로 하기 
*/
            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] tempToReverse = message[i].ToCharArray();
                Array.Reverse(tempToReverse);
                newMessage[i] = new string(tempToReverse);
            }

            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);
        }
    }
}
