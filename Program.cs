using System;
using System.Collections.Generic;


namespace Module_9
{
    public class SortFamily 
    { 
        public delegate void SortDelegate(List<string> vs);

        public event SortDelegate SortEven;
        
        public void SortEventHandler(List<string> list) 
        { 
             SortEven.Invoke(list);
        }
    }
    
    class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>() { "Ivanov", "Petrov", "Zhirov", "Cerman", "Nikolaev" };

            Console.WriteLine("Введите 1 для сортировки спиcка Фамилий от A до Z" + '\n' + "Введите 2 для сортировки списка Фамилий от Z до A");

            int number=0;
            bool Ischeck = true;
            
            while (Ischeck)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    Ischeck = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Введите правильное число 1 или 2");
                }
                finally 
                { 
                    Console.WriteLine("Значение успешно введено");
                }
            }

                    SortFamily sortFamily = new SortFamily();

                switch (number)
                {
                    
                    case 1:
                        sortFamily.SortEven += SortListAZ;
                        sortFamily.SortEventHandler(list);
                        break;
                    case 2:
                        sortFamily.SortEven += SortListZA;
                        sortFamily.SortEventHandler(list);
                        break;
                }
            
        }

        public static void SortListAZ(List<string> list1) 
        { 
            list1.Sort();

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }

        public static void SortListZA(List<string> list2)
        {
            list2.Sort();

            List<string> list3 = new List<string>() {"","","","","" };

            for (int i = 0; i < list2.Count; i++)
            {
                list3[i] = list2[list2.Count - i - 1];
            }

            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

        }
    }
}




    

