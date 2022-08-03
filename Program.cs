using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  Напишите метод, который проверяет является ли переданное число «палиндромом». 
 *  Число передаётся в качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
    Палиндром — число, которое читается одинаково как справа налево, так и слева направо. Например:
        1221 — палиндром;
        3443 — палиндром;
        7854 — не палиндром.
 */
namespace Task4_1
{
    class Program
    {
        static bool CheckPalindrom(int number)
        {
            int firstDigit, lastDigit, count = 0;
            int temp = number;
            // Подсчет количества знаков в числе
            while (temp > 0)
            {
                temp /= 10;
                count++;
            }
            //Проверка числа на палиндром
            firstDigit = number;
            for (int i = 0; i < count/2; i++)
            {
                firstDigit %= 10;
                lastDigit = number / (int)Math.Pow(10, (count-1-i));

                if (firstDigit == lastDigit)
                {
                    number = number - (lastDigit * (int)Math.Pow(10, (count - 1 - i)));
                    firstDigit = number / (int)Math.Pow(10, (i + 1));
                }
                else
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("\n Введите произвольое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(CheckPalindrom(number))
            {
                Console.WriteLine("\n Введеное число является палиндромом!\n\n");
            }
            else
                Console.WriteLine("\n Введеное число не является палиндромом!\n\n");

        }
    }
}
