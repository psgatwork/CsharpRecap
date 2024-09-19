using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOne
{
    public class Calculator
    {
        public int add(params int[] numbersToAdd)
        {
            return numbersToAdd.Sum();
        }

    }
}
