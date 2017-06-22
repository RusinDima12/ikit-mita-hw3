using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIkit_mita_hm3
{
    public class Numberton
    {
        public delegate void Number(int number);

        public event Number NewNumber;
        Random rand=new Random();
        public void Generate()
        {
            
            NewNumber(rand.Next(0,100));
        }
    }

    public static class IsMyEven
    {
        public static bool IsEven(this int number)
        {
            return number%2 == 0;
        }
    }
}
