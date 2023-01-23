using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushka_Intelectual_Demo_Of_Research
{
    internal class RightAngled : Pair
    {
        public float getSqare()
        {
            return (first * second) / 2;
        }
        public float getGipotenuse()
        {
            return (float)Math.Sqrt(first * first + second * second);
        }
    }
}
