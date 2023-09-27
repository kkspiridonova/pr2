using System.ComponentModel;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters;

namespace threeprogramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            while (opt != 4)
            {
                Console.WriteLine("Выберите программу:");
                Console.WriteLine("1. Игра угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей");
                Console.WriteLine("4. Выйти из меню");
                string nopt = Console.ReadLine();
                opt = Convert.ToInt32(nopt);
                switch (opt)
                {
                    case 1:
                    GameNumbers();
                        break;
                    case 2:
                    Table();
                        break;
                    case 3:
                        Delitely();
                        break;
                }

            }
        }
        static void GameNumbers()
        {
            Console.WriteLine("Угадайте число от 1 до 100!");
            Random random = new Random();
            int num = random.Next(1, 100);
            int intnum = 0;
           while (intnum != num)
            {
                string strnum = Console.ReadLine();
                intnum = Convert.ToInt32(strnum);
                if (intnum < num)
                {
                    Console.WriteLine("Больше!");
                }
                if (intnum > num)
                {
                    Console.WriteLine("Меньше!");
                }
            }
            Console.WriteLine("Победа!");
        }
        static void Table()
        {
            int[,] table = new int[10, 10];
            for(int ryad = 1; ryad < 10; ryad++)
            {
                for (int stolbec = 1; stolbec < 10; stolbec++)
                {
                    table[ryad, stolbec] = ryad * stolbec;
                    Console.Write(table[ryad, stolbec] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Delitely()
        {
            Console.WriteLine("Введите число:");
            string snum = Console.ReadLine();
            int inum = Convert.ToInt32(snum);
            for (int i = 1; i != inum+1; i++)
            {
                int f = inum % i;
                if (f == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        

    }
}