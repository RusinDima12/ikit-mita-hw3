using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIkit_mita_hm3
{
    public abstract class Gambler
    {
        public readonly string name;
        public int Score { get; private set; }

        public abstract void FetchNewNumber(int number);

        public Gambler(string Name)
        {
            name = Name;
        }

    }
}
