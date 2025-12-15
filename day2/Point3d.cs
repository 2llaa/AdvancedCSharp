using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Point3d
    {
        public Point3d() : this(10, 10, 10)
        {
        }
        internal Point3d(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
       
        internal int X { get; set; }
        internal int Y { get; set; }
        internal int Z { get; set; }

        public override string ToString()
        {
            return $"X={this.X} , Y={this.Y} , Z={this.Z}";
        }
        public static bool operator ==(Point3d point1,Point3d point2)
        {
            return point1.X == point2.X && point1.Y == point2.Y && point1.Z == point2.Z;
        }
        public static bool operator !=(Point3d point1, Point3d point2)
        {
            return point1.X != point2.X || point1.Y != point2.Y || point1.Z != point2.Z;
        }
    }
}
