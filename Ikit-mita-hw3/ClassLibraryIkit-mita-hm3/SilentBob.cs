using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIkit_mita_hm3
{
    public class SilentBob:Gambler
    {
        
        public SilentBob() : base("SilentBob")
        {
        }

        public override void FetchNewNumber(int number)
        {
            if (!number.IsEven())
            {
                Score++;
            }
        }
    }
}
