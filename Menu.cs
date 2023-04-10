using System;
using System.Text;
using System.Collections.Generic;
namespace Homwork2
{
    class Menu
    {
        //value
        static bool CheckKey;
        public int positions = 0;
        protected static Menu menu;
        public List<string[]> ListLap = new List<string[]>();
        public string[] Language = new string[2] {"Englist","Tiếng Việt"};
        public static Menu gI() 
        {
            if (menu == null) { menu = new Menu(); }
            return menu; 
        }
        //Functions
        public string Print(string s, int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            return (s != null) ? s : "Chưa bỏ chuỗi vào print";
        }
        //Handle
            //menu
        public void ClearConsole()
        {
            StringBuilder consles = new StringBuilder();
            Console.SetCursorPosition(0,0);
            for (int i = 0; i < Console.BufferHeight - 2; i++)
            {
                for (int y = 0; y < Console.WindowWidth; y++)
                {
                    consles.Append(" ");
                }
                consles.AppendLine();
            }
            Console.ResetColor();
            Console.WriteLine(consles);
        }
        private int HandleKey(string[] array)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
            {
                if (positions == 0)
                {
                    positions = array.Length;
                }
                positions--;
            }
            if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow)
            {
                positions++;
                if (positions == array.Length)
                {
                    positions = 0;
                }
            }
            if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Spacebar)
            {
                CheckKey = !CheckKey;
            }
            return positions;
        }
        public int ShowMenu(string[] array)
        {
            CheckKey = true;
            while (CheckKey)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(Print(array[i], 0, i));
                    if (i == positions)
                    {
                        Console.WriteLine(Print(" "+array[i], 0, i, ConsoleColor.Green));
                        Console.WriteLine(Print("<", array[i].Length + 1, i, ConsoleColor.Red));
                        Console.WriteLine(Print(">", 0, i, ConsoleColor.Red));
                    }
                }
                HandleKey(array);
                ClearConsole();
            }
            return positions;
        }
    }
}
