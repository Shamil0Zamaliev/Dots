using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dots
{
    internal class Dot
    {
        private double x;
        private double y;
        private double z;

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Z { get { return z; } set { z = value; } }

        public Dot(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }

        public void Show()
        {
            Console.WriteLine($"({X},{Y},{Z})");
        }


        public double Dist0 () 
        {
            return Math.Sqrt((x*x) + (y*y) + (z*z));
        }
        
        public static double Distance_between(Dot a, Dot b)
        {
            return Math.Sqrt(Math.Pow((a.x - b.x), 2) + Math.Pow((a.y - b.y), 2) + Math.Pow((a.z - b.z), 2));
        }

        public static Dot operator +(Dot a, Dot b)
        {
            Dot c = new (a.x+b.x, a.y + b.y, a.z + b.z);
            return c;
        }

        public static void straigh_line_equation (Dot a, Dot b )
        {
            Console.WriteLine($"(X - {a.x})/{b.x - a.x} = (Y - {a.y})/{b.y - a.y} = (Z- {a.z})/{b.z - a.z}");
        }

        public static void plane_equation(Dot a, Dot b, Dot c)
        {
           double A, B, C, D;
            A = a.y* (b.z - c.z) + b.y* (c.z - a.z) + c.y* (a.z - b.z); 
            B = a.z* (b.x - c.x) + b.z* (c.x - a.x) + c.z* (a.x - b.x); 
            C = a.x* (b.y - c.y) + b.x* (c.y - a.y) + b.x* (a.y - b.y);
            D =-(a.x* (b.y* c.z - c.y* b.z) + b.x* (c.y* a.z - a.y* c.z) + c.x* (a.y* b.z - b.y* a.z));
            Console.WriteLine($"({A}x) + ({B}y) + ({C}z) + ({D}) = 0");
        }

        public static double Scalar(Dot a, Dot b)
        {
            return (a.x * b.x + a.y * b.y + a.z * b.z);
        }

        public static Dot operator *(Dot a, Dot b)
        {
            Dot c = new ((a.y*b.z-a.z*b.y), (a.x*b.z-a.z*b.x), (a.x*b.y-a.y*b.x));
            return c;
        } 
        




    }
}
