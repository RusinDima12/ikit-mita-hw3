using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIkit_mita_hm3
{
    public abstract class Gambler
    {
        public string Name { get; set; }
        public int Score { get; internal set; }

        public abstract void FetchNewNumber(int number);

        public Gambler(string name)
        {
            Name = name;
        }

    }
}
