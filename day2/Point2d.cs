using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Point2d
    {
        #region Singletone design pattern implementation
        private Point2d() : this(10, 10)
        {
        }
        private Point2d(int x, int y)
        {
            X = x;
            Y = y;
        }
        internal static Point2d MakeObj { get; set; } = new Point2d();
        #endregion
        internal int X { get; set; }
        internal int Y { get; set; }
    }
}
