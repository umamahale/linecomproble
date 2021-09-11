using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Day3
{
    class nuint
    {
        public int x, y;

        public nuint(int x, int y)

        {

            this.x = x;

            this.y = y;

        }
    }


    class GFG
    {
        private static readonly int val;



        // To find orientation of ordered triplet 

        // (p1, p2, p3). The function returns 

        // following values 

        // 0 --> p, q and r are collinear

        // 1 --> Clockwise

        // 2 --> Counterclockwise

        public static object orientation(Point p1, System.Drawing.Point p2, System.Drawing.Point p3)

        {

            // See 10th slides from following link 

            // for derivation of the formula

            



            if (val == 0) return 0; // collinear



            // clock or counterclock wise

            return (val > 0) ? 1 : 2;

        }

     

    

    public static void Main(String[] args)

        {

            Point p1 = new Point(0, 0);

            Point p2 = new Point(4, 4);

            Point p3 = new Point(1, 2);



            int o = (int)orientation(p1, p2, p3);



            if (o == 0)

                Console.WriteLine("Linear");

            else if (o == 1)

                Console.WriteLine("Clockwise");

            else

                Console.WriteLine("CounterClockwise");



        }
    }

}

