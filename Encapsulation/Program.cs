//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point A=new Point();
            //A.SetX(2);
            //A.SetY(4);
            //Console.WriteLine($"X={A.GetX()}, Y={A.GetY()}");
            //A.Print();

#if CONSTRUCTORS_CHECK
            Point B = new Point();// Конструктор по умолчанию
            B.X = 7;
            B.Y = 8;
            B.Print();
            Point С = new Point(11, 12);// Конструктор по умолчанию
            С.Print();
            //Console.WindowWidth;
            //Console.SetWindowSize;

            Point D = С;// Здесь копируется не объект, а ссылка на него
            D.Print();
            D.X = 111;
            С.Print();

            //Объекты копируются следующим образом
            Point E = new Point(D);//Здесь вызывается конструктор копирования
            E.Print();
            E.X = 11;
            D.Print();

            E = new Point(B);
            E.Print(); 
#endif
            Point A = new Point(2, 3);
            Point B= new Point(7, 8);
            Point C = new Point(A + B);
            C.Print();
            for (Point i = new Point(); i.X < 10; i++)
            {
                i.Print();
            }
            Point n = new Point(10, 10);
            for (Point i = new Point(); i != n; ++i)
            { 
                i.Print();  
            }
        }
    }
}
