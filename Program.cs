using System;
using System.IO;

namespace Module_9
{
    class MyException : Exception 
    {
        public MyException(string Message) : base(Message) { }

    }
    class Program
    {
        public static void Main()
        {
            Exception[] exceptions = new Exception[5]
            {
                new DivideByZeroException(),
                new FormatException(),
                new FileNotFoundException(),
                new MyException("Создано свое исключение"),
                new DriveNotFoundException()
            };
                try
                {
                    foreach (Exception ex in exceptions)
                    {
                        Console.WriteLine("Отработало исключение "+ ex.GetType());
                    }
                }
                catch (Exception ex)
                {
                    if (ex is DivideByZeroException) Console.WriteLine(ex.Message);
                    if (ex is FileNotFoundException) Console.WriteLine(ex.Message);
                    if (ex is DriveNotFoundException) Console.WriteLine(ex.Message);
                    if (ex is FormatException) Console.WriteLine(ex.Message);
                    if (ex is MyException) Console.WriteLine(ex.Message);

                }
            
        }
    }
}




    

