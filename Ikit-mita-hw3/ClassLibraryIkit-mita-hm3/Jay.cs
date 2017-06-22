using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryIkit_mita_hm3
{
    public class Jay:Gambler
    {       
        public Jay() : base("Jay")
        {
        }

        public override void FetchNewNumber(int number)
        {
            if (number.IsEven())
            {
                Score++;
            }
        }
    }
}
