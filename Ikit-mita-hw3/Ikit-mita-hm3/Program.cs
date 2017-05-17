using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryIkit_mita_hm3;

namespace Ikit_mita_hm3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое количество чисел использовать?");
            int numb = 0;
            try
            {
                numb = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                numb = 0;
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели недопустимое число");
                numb = 0;
            }
            while (numb<=0)
            {            
                Console.WriteLine("Введите положительное целое число!");           
                try { numb = int.Parse(Console.ReadLine());} catch (FormatException) { numb=0;}
            }                      
            Console.WriteLine("Введите имя Джея(лол)");            
            Jay jay=new Jay(Name());            
            Console.WriteLine("Введите имя Молчаливого Боба");
            SilentBob silentBob=new SilentBob(Name());
            Numberton numberton=new Numberton();
            numberton.NewNumber += silentBob.FetchNewNumber;
            numberton.NewNumber += jay.FetchNewNumber;
            for (int i = 0; i < numb; i++)
            {
                numberton.Generate();
            }
            if (jay.Score > silentBob.Score)
            {               
                Console.WriteLine($" У {jay.name} {jay.Score} очков");
                Console.WriteLine($" У {silentBob.name} {silentBob.Score} очков");
                Console.WriteLine($" Выиграл {jay.name} ");
            }
            else if (jay.Score < silentBob.Score)
            {
                Console.WriteLine($" У {jay.name} {jay.Score} очков");
                Console.WriteLine($" У {silentBob.name} {silentBob.Score} очков");
                Console.WriteLine($" Выиграл {silentBob.name} ");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Console.ReadKey();
        }

        public static string Name()
        {
            string Name = Console.ReadLine(); ;
            while (Name.Length == 0)
            {
                Console.WriteLine("Вы не ввели имя");
                Name = Console.ReadLine();
            }
            return Name;
        }        
    }
   
}
