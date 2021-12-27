using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Random random = new Random();
        int firstValue = 0,
            resultValue = 0, 
            userResultValue = 0;     // предлагаем выбрать число на которое будет показана таблица умножения от 1 до 10
        //выводим попорядку все примеры умножения для выбранного числа попутно проверяя результаты и считая баллы

        Console.Write("Введите число таблицу умножения которого вы хотите проверить: ");
        firstValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Дальше необходимо ввести ответы на предложенные примеры:");
        bool[] arrayAnswers = new bool[11];
        for (int i = 0; i <= 10; i++)
        { 
            Console.Write ($@"{i}. {firstValue} * {i} = ");
            userResultValue = Convert.ToInt32(Console.ReadLine());
            resultValue = firstValue * i;
            if (resultValue == userResultValue)
            {
                arrayAnswers[i] = true;
                //Console.WriteLine(" - ВЕРНО!");                
            }
            else
            {
                arrayAnswers[i] = false;
                //Console.WriteLine(" - НЕ верно!");
            }
        }    
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($@"{i}. {arrayAnswers[i]}");
        }
        Console.ReadLine();        
    }
}