using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinomial
{
    public class Model
    {
        double a, b, c;

        public double A
        {
            get { return a; }
        }

        public bool InterpretA(String locA)
        {
            try
            {
                a = Convert.ToDouble(locA);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public double B
        {
            get { return b; }
        }

        public bool InterpretB(String locB)
        {
            try
            {
                b = Convert.ToDouble(locB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public double C
        {
            get { return c; }
        }

        public bool InterpretC(String locC)
        {
            try
            {
                c = Convert.ToDouble(locC);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
