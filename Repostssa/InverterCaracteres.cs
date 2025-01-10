using System;

namespace Repostssa
{
    public class InverterCaracteres
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string para inverter:");
            string input = Console.ReadLine();

            string inverted = InverterString(input);

            Console.WriteLine("String invertida: " + inverted);
        }

        static string InverterString(string str)
        {
            char[] array = str.ToCharArray();
            int left = 0, right = array.Length - 1;

            while (left < right)
            {
                char temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }

            return new string(array);
        }
    }
}