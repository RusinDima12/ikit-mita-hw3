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

        public void Generate()
        {
            Random rand=new Random();
            NewNumber(rand.Next(1000));
        }
    }

    public static class IsMyEven
    {
        public static bool IsEven(int number)
        {
            return number%2 == 0;
        }
    }
}
