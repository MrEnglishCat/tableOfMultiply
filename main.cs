using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Random random = new Random(); // random можно использовать вместо ввода с клавиатуры 
        int firstValue = 0,
            resultValue = 0, 
            userResultValue = 0;     // предлагаем выбрать число на которое будет показана таблица умножения от 1 до 10
        //выводим попорядку все примеры умножения для выбранного числа попутно проверяя результаты и считая баллы

        Console.Write("Введите число таблицу умножения которого вы хотите проверить: ");
        firstValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Дальше необходимо ввести ответы на предложенные примеры:");
        bool[] arrayAnswers = new bool[11];
        for (int i = 1; i < 11; i++)
        { 
            Console.Write ($@"{i}. {firstValue} * {i} = ");
            userResultValue = Convert.ToInt32(Console.ReadLine());
            resultValue = firstValue * i;
            if (resultValue == userResultValue)
            {
                arrayAnswers[i-1] = true;
                //Console.WriteLine(" - ВЕРНО!");                
            }
            else
            {
                arrayAnswers[i-1] = false;
                //Console.WriteLine(" - НЕ верно!");
            }

            //Console.Write ()
        }    
        for (int i = 1; i <= 11; i++)
        {
            if (i == 11) break;
            Console.WriteLine($@"{i}. {arrayAnswers[i-1]}");
        }
        Console.ReadLine();        
    }
}