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
            while (numb<=0)
            {            
                Console.WriteLine("Введите положительное целое число!");           
                try
                {
                    numb = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    numb =0;
                }
                catch (OverflowException)
                {
                    numb = 0;
                    Console.WriteLine("Вы ввели слишком большое число");
                }
                
            }                               
            Jay jay=new Jay();                        
            SilentBob silentBob=new SilentBob();
            Numberton numberton=new Numberton();
            numberton.NewNumber += silentBob.FetchNewNumber;
            numberton.NewNumber += jay.FetchNewNumber;
            for (int i = 0; i < numb; i++)
            {
                numberton.Generate();
            }
            if (jay.Score > silentBob.Score)
            {               
                Console.WriteLine($" У {jay.Name} {jay.Score} очков");
                Console.WriteLine($" У {silentBob.Name} {silentBob.Score} очков");
                Console.WriteLine($" Выиграл {jay.Name} ");
            }
            else if (jay.Score < silentBob.Score)
            {
                Console.WriteLine($" У {jay.Name} {jay.Score} очков");
                Console.WriteLine($" У {silentBob.Name} {silentBob.Score} очков");
                Console.WriteLine($" Выиграл {silentBob.Name} ");
            }
            else
            {
                Console.WriteLine($" У {jay.Name} {jay.Score} очков");
                Console.WriteLine($" У {silentBob.Name} {silentBob.Score} очков");
                Console.WriteLine("Draw!");
            }
            Console.ReadKey();
        }              
    }
   
}
