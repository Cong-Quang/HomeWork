using System;
using System.Collections.Generic;

namespace Homwork2
{
    class Lab
    {
        protected static Lab lab;
        HomeWork homeWork = new HomeWork();
        List<string[]> ListData = new List<string[]>();
        public static Lab gI()
        {
            if (lab == null) { lab = new Lab(); }
            return lab;
        }
        public bool SystemChoise(int choise,int langguage)
        {
            Console.SetCursorPosition(0,0);
            if (choise == 0)
            {
                Console.Write($"{ListData[0][langguage]}: ");
                int C_array = int.Parse(Console.ReadLine());
                float[] array = new float[C_array];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{ListData[1][langguage]} [{i}]: ");
                    array[i] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine($"{ListData[2][langguage]}: {homeWork.find_number_largest(array)}");
            }
            else if (choise == 1)
            {
                Console.Write($"{ListData[0][langguage]}: ");
                int C_array = int.Parse(Console.ReadLine());
                float[] array = new float[C_array];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{ListData[1][langguage]} [{i}]: ");
                    array[i] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine($"{ListData[3][langguage]}: {homeWork.find_number_smallest(array)}");
            }
            else if (choise == 2)
            {
                Console.Write($"{ListData[0][langguage]}: ");
                int C_array = int.Parse(Console.ReadLine());
                int[] array = new int[C_array];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{ListData[1][langguage]} [{i}]: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                array = homeWork.Sort_array_descending(array);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else if (choise == 3)
            {
                Console.Write($"{ListData[0][langguage]}: ");
                int C_array = int.Parse(Console.ReadLine());
                int[] array = new int[C_array];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{ListData[1][langguage]} [{i}]: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.Write($"{ListData[4][langguage]}: ");
                int Tcout = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"{ListData[5][langguage]}: {homeWork.Count_the_Spawn_Number(array, Tcout)}");
            }
            else if (choise == 4)
            {
                Console.Write($"{ListData[0][langguage]}: ");
                int C_array = int.Parse(Console.ReadLine());
                int[] array = new int[C_array];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{ListData[1][langguage]} [{i}]: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"{ListData[6][langguage]}: {homeWork.find_number_second(array)}");
            }
            else if (choise == Menu.gI().ListLap.Count-1)
            {
                return false;
            }
            return true;
        }
        void add_listdata()
        {
            ListData.Add(new string[] { "Input your length Array","Nhập độ dài mảng"});
            ListData.Add(new string[] { "Input array","Nhập vào mảng"});
            ListData.Add(new string[] { "Biggest number", "Số lớn nhất"});
            ListData.Add(new string[] { "Smallest number", "Số nhỏ nhất"});
            ListData.Add(new string[] { "Number to count", "số cần đếm" });
            ListData.Add(new string[] { "The number of occurrences", "Số lần xuất hiện"});
            ListData.Add(new string[] { "2nd largest number", "Số lớn thứ 2" });
            //ListData.Add(new string[] {});
        }
        void addListLap()
        {
            Menu.gI().ListLap.Add(new string[] { "Find largest number in array", "Tìm số lớn nhất trong mảng" });
            Menu.gI().ListLap.Add(new string[] { "Find smallest number in array", "Tìm số nhỏ nhất trong mảng" });
            Menu.gI().ListLap.Add(new string[] { "Sort array descending", "Sắp xếp mảng giảm dần" });
            Menu.gI().ListLap.Add(new string[] { "Count number spawn", "Đếm số lần xuất hiệnh của số"});
            Menu.gI().ListLap.Add(new string[] { "Find second largest number in array", "Tìm số lớn thứ hai trong mảng" });



            Menu.gI().ListLap.Add(new string[] { "Exit", "Thoát" });
            /*Menu.gI().ListLap.Add(new string[] { });*/
        }
        public void addString()
        {
            add_listdata();
            addListLap();
        }
    }
    class HomeWork
    {
        public float find_number_largest(float[] aray)
        {
            float max = aray[0];
            for (int i = 0; i < aray.Length; i++)
            {
                if (aray[i] > max) max = aray[i];
            }
            return max;
        }
        public float find_number_smallest(float[] aray)
        {
            float min = aray[0];
            for (int i = 0; i < aray.Length; i++)
            {
                if (aray[i] < min) min = aray[i];
            }
            return min;
        }
        public int[] Sort_array_descending(int[] aray)
        {
            for (int i = 0; i < aray.Length; i++)
            {
                for (int t = 0; t < aray.Length; t++)
                {
                    if (aray[t] < aray[i])
                    {
                        int temp = aray[i];
                        aray[i] = aray[t];
                        aray[t] = temp;
                    }
                }
            }
            return aray;
        }
        public int Count_the_Spawn_Number(int[] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    count++;
                }
            }
            return count;
        }
        public int find_number_second(int[] arr)
        {
            int min1 = arr[0];
            int min2 = int.MaxValue;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min1)
                {
                    min2 = min1;
                    min1 = arr[i];
                }
                else if (arr[i] < min2 && arr[i] != min1)
                {
                    min2 = arr[i];
                }
            }
            return min2;
        }

    }
}