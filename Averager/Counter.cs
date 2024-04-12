using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averager
{
    internal class Counter
    {
        // TODO lite variabler
        int value = 0;
        // ökar räknaren med ett
        public void Increment()
        {
            // TODO
            value++;
        }

        // återställer värdet till noll
        public void Reset()
        {
            // TODO
            value = 0;
        }

        // ger värdet på räknaren
        public int GetValue()
        {
            // TODO
            return value;
        }
    }
}
