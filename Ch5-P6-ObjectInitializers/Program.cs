using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P6_ObjectInitializers
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine(" ***** Fun with Object Init Syntax ***** \n ");

            #region Understanding Object Initialization Syntx

            //// Make a Point by setting each property manually.
            //Point firstPoint = new Point();
            //firstPoint.X = 10;
            //firstPoint.Y = 10;
            //firstPoint.DisplayStats();

            //// Or make a Point via a custom constructor.
            //Point anotherPoint = new Point(20, 20);
            //anotherPoint.DisplayStats();

            //// Or make a Point using object init syntax.
            //Point finalPoint = new Point { X = 30, Y = 30 };
            //finalPoint.DisplayStats();

            #endregion

            #region Calling Custom Constructors with Initialization Syntax

            //// Here, the default constructor is called implicitly.
            //Point finalPoint = new Point { X = 30, Y = 30 };

            //// Here, the default constructor is called explicitly.
            //Point finalPoint = new Point() { X = 30, Y = 30 };


            //// Calling a custom constructor.
            //Point pt = new Point(10, 16) { X = 100, Y = 100 };
            //pt.DisplayStats();

            //Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            //goldPoint.DisplayStats();

            #endregion

            #region Initializing Data with Initialization Syntax

            // Create and initialize a Rectangle.
            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point(PointColor.Gold) { X = 10, Y = 10 },
                BottomRight = new Point(PointColor.LightBlue) { X = 200, Y = 200 }
            };

            myRect.DisplayStats();

            #endregion

            Console.ReadLine();
        }
    }
}
