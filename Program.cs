using System;
using System.Text;
namespace Homwork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Title = "Choise Language";
            Console.OutputEncoding = Encoding.UTF8;
            Lab.gI().addString();
            //
            int cLanguage = Menu.gI().ShowMenu(Menu.gI().Language);
            Menu.gI().positions = 0; // reset choise
            switch (cLanguage)
            {
                case 0:
                    Console.Title = "Lab HomeWork";
                    break;
                case 1:
                    Console.Title = "Kho Bài Tập Về Nhà";
                    break;
            }
            //convert list to array
            string[] SubLab = new string[Menu.gI().ListLap.Count];
            for (int i = 0; i < SubLab.Length; i++)
            {
                SubLab[i] = Menu.gI().ListLap[i][cLanguage];
            }
            bool check = true;
            while (check)
            {
                Console.Clear();
                int cLab = Menu.gI().ShowMenu(SubLab);
                check = Lab.gI().SystemChoise(cLab, cLanguage);
                Console.ReadLine();
            }
        }
        static void SubMain()
        {

        }
    }
}
