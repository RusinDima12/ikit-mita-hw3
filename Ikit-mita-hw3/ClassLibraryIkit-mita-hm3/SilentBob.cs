using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIkit_mita_hm3
{
    public class SilentBob:Gambler
    {
        public int Score { get; private set; }
        public SilentBob(string Name) : base(Name)
        {
        }

        public override void FetchNewNumber(int number)
        {
            if (!IsMyEven.IsEven(number))
            {
                Score++;
            }
        }
    }
}
