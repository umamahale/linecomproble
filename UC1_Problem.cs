﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class UC1_Problem
    {
        static void quadrant(int x, int y)

        {

            if (x > 0 && y > 0)

                Console.WriteLine("lies in First quadrant");



            else if (x < 0 && y > 0)

                Console.WriteLine("lies in Second quadrant");



            else if (x < 0 && y < 0)

                Console.WriteLine("lies in Third quadrant");



            else if (x > 0 && y < 0)

                Console.WriteLine("lies in Fourth quadrant");



            else if (x == 0 && y > 0)

                Console.WriteLine("lies at positive y axis");



            else if (x == 0 && y < 0)

                Console.WriteLine("lies at negative y axis");



            else if (y == 0 && x < 0)

                Console.WriteLine("lies at negative x axis");



            else if (y == 0 && x > 0)

                Console.WriteLine("lies at positive x axis");



            else

                Console.WriteLine("lies at origin");

        }



        // Driver Code 

        public static void Main()

        {

            int x = 1, y = 1;



            // Function Calling 

            quadrant(x, y);

        }

    }

}

