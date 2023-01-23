using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushka_Intelectual_Demo_Of_Research
{
    internal class Pair
    {
        public float first { get; private set; }
        public float second { get; private set; }

        public Pair()
        {
            setValues(0, 0);
        }

        public Pair(float f, float s)
        {
            setValues(f, s);
        }

        public void setValues(float f, float s)
        {
            if ((float)Math.Sqrt(f * f + s * s) > f + s)
            {
                Console.WriteLine("Треугольник с данными значениями не может существовать");
                return;
            }

            first = f; 
            second = s;
        }

        public void setFirst(float f)
        {
            first = f;
        }

        public void setSecond(float s)
        {
            second = s;
        }
    }
}
