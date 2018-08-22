using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Quadrilateral
    {
        private const int sides = 4;
        private const int corners = 4;
        private const int sumOfAngles = 360;
        private const bool is2D = true;

        private int[][] cornerCoordinates;

        public Quadrilateral(int[][] cornerCoordinates)
        {
            CornerCoordinates = cornerCoordinates;
        }

        public int[][] CornerCoordinates
        {
            get
            {
                return cornerCoordinates;
            }
            set
            {
                cornerCoordinates = value;
            }
        }

    }
}
