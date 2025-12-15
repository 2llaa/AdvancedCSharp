using System.Text;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region a test of singletone design pattern
            Console.WriteLine("a test if the two references is assigned to the same point!");
            Point2d pointt1 = Point2d.MakeObj;
            Point2d pointt2 = Point2d.MakeObj;

            Console.WriteLine(pointt1.GetHashCode());
            Console.WriteLine(pointt2.GetHashCode());
            #endregion


            Point3d point1 = new Point3d();
            Point3d point2 = new Point3d(4,5,6); 

            if(point1==point2)
                Console.WriteLine($"\nThe two points are equal and their coordinates is: {point1.ToString()}");
            else
                Console.WriteLine($"\nThe two points coordinates is:\n p1={point1} ,\n p2={point2}");
                
            int n = 0;
            List<Point3d> points = new List<Point3d>();

            Console.WriteLine("\nEnter another 2 points coordinates:\n");
            Console.WriteLine("Enter the first point coordinates:");

            try
            {
                do
                {
                    
                    Console.WriteLine("please enter the first coordinate");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("please enter the second coordinate");
                    int y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("please enter the third coordinate");
                    int z = Convert.ToInt32(Console.ReadLine());

                    Point3d p = new Point3d(x, y, z);

                    points.Add(p);
                  
                    Console.WriteLine("\nEnter the second point coordinates:");

                    n++;
                }
                while (n < 2);

                //used StringBuilder for converting list to string
                var builder = new StringBuilder();
                foreach (var item in points)
                {
                    builder.Append(item).Append("\n");
                }

                Console.WriteLine("The 2 points coordinates is:\n");
                Console.WriteLine(builder.ToString());
            }
            catch 
            {
                Console.WriteLine("Somthing goes wrong, please enter the right formate (numbers only)!");
            }

        }
    }
}
