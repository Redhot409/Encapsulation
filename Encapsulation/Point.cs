//#define POINT_DISTANCE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Point
    {
        //double x;
        //double y;
        //public double X
        //{
        //    get
        //    {
        //        return x;
        //    }
        //    set 
        //    {
        //        ///if(value...)....фильтрация данных
        //        x = value;
        //    }
        //}

        //public double Y
        //{
        //    get { return y; }
        //    set { y = value; }
        //}


        //public double GetX()
        //{
        //    return x;
        //}
        //public double GetY() 
        //{
        //    return y;
        //}
        //public  void SetX(double x) 
        //{
        //    this.x = x;
        //}
        //public void SetY(double y) 
        //{
        //    this.y = y;
        //}

        public double X { get; set; }//Автосвойста для Х
        public double Y { get; set; }//Автосвойста для У

        ///////////////////Distance

#if POINT_DISTANCE
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x = 0, double y = 10)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Constructor:\t {GetHashCode()}");
        }
        ~Point()
        {
            Console.WriteLine($"Destructor:\t{GetHashCode()}");
        }

        public double Distance(Point other)// метод дитсанс
        {
            double dx = this.X - other.X;
            double dy = this.Y - other.Y;
            return Math.Round(Math.Sqrt(dx * dx + dy * dy), 5);
        }
        public static double Distance(Point a, Point b)//статический метод
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;
            return Math.Round(Math.Sqrt(dx * dx + dy * dy), 5);
        }

        public void Print()
        {
            Console.WriteLine($"X={X}, Y={Y}");
        } 
#endif

        /// Constructors:
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Constructor:{this.GetHashCode()}");
        }
        ~Point()
        {
            Console.WriteLine($"Destructor:\t{this.GetHashCode()}");
        }

        ///     Operators    ///// 

        public static Point operator +(Point left, Point right)
        {
            Point res = new Point();
            res.X = left.X + right.X;
            res.Y = left.Y + right.Y;
            return res;

        }

        public static Point operator ++(Point obj)
        {
            obj.X++;
            obj.Y++;
            return obj;
        }

        public static bool operator ==(Point left, Point right)
            {
                return left.X == right.X && left.Y == right.Y;
            }
        public static bool operator !=(Point left, Point right)
        {
            return !(left==right);

        }

        public Point(Point other)
        {
            this.X = other.X;
            this.Y = other.Y;
            Console.WriteLine($"CopyConstructor: {this.GetHashCode()}");
        }

        public void Print()
        {
            Console.WriteLine($"X={X}, Y={Y}");
        }
    }
}
