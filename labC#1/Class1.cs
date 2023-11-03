using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labC_1
{
    internal class Quadrangle
    {
        double  kyt1, kyt2;
        public double ab { get; private set; }
        public double bc { get; private set; }
        public double cd { get; private set; }
        public double ad { get; private set; }

        public Quadrangle(double ab, double bc, double cd, double ad)
        {
            this.ab = ab;
            this.bc = bc;
            this.cd = cd;
            this.ad = ad;
        }

        public Quadrangle(double kyt1, double kyt2)
        {
            this.kyt1 = kyt1;
            this.kyt2 = kyt2;
        }

        public Quadrangle()
        {
            Random random = new Random();
            ab = random.Next(1,11);
            bc = random.Next(1,11);
            cd = random.Next(1,11);
            ad = random.Next(1,11);
        }


        public string Perevirka1()
        {
            if (ab == cd && bc == ad && ab != bc && ab != ad && cd != bc && cd != ad)
            {

                return "True";
            }
            else return "False";
        }

        public string Perevirka2()
        {
            double prkyt = kyt1 + kyt2;
            if (prkyt == 180)
            {

                return "True";
            }
            else return "False";
        }
    }
}
