using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                System.Console.WriteLine("Ocak Ayı");
                break;
                case 2:
                System.Console.WriteLine("Şubat Ayı");
                break;
                case 3:
                System.Console.WriteLine("Mart Ayı");
                break;
                default:
                break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                System.Console.WriteLine("Kış Mevsimindesiniz");
                break;
                case 3:
                case 4:
                case 5:
                System.Console.WriteLine("İlk Bahar Mevsimindesiniz");
                break;
                case 6:
                case 7:
                case 8:
                System.Console.WriteLine("Yaz Mevsimi");
                break;
                case 9:
                case 10:
                case 11:
                System.Console.WriteLine("Son bahar Mevisimi");
                break;
                
                default:
                break;
            }

        }
    }
}
