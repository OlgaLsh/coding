using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
    public struct Shooting
    {
        public double x;
        public double y;
        public double Score;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shooting Fire; // выстрел
            int Score = 0; // счет
            string Continue; // ответ на продолжение цикла

            do
            {
                Console.WriteLine("Введите значения x и y выстрела:");
                Fire.x = Double.Parse(Console.ReadLine());
                Fire.y = Double.Parse(Console.ReadLine());
                Fire.Score = Math.Sqrt(Math.Pow(Fire.x, 2) + Math.Pow(Fire.y, 2)); // расстояние от центра мишени до выстрела
                if (Fire.Score <= 3)
                { Console.WriteLine("Выстрел на 10 баллов"); Score += 10; }
                else
                {
                    if (Fire.Score <= 7)
                    { Console.WriteLine("Выстрел на 5 баллов"); Score += 5; }
                    else
                        if (Fire.Score <= 10)
                    { Console.WriteLine("выстрел на 1 балл"); Score += 1; }
                    else { Console.WriteLine("Мимо. 0 баллов"); Score += 0; }

                }
                Console.WriteLine("Играть далее? да или нет:");
                Continue = Console.ReadLine();
            } while (Continue == "да");
            Console.WriteLine("Набрано {0} баллов", Score);
        }
    }
}
