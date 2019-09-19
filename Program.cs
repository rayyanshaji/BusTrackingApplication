using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrackingApp
{
    // C# program to calculate 
    // Distance Between Two 
    // Points on Earth 
    using System;

    class GFG
    {
        static double toRadians(
            double angleIn10thofaDegree)
        {
            // Angle in 10th 
            // of a degree 
            return (angleIn10thofaDegree *
                        Math.PI) / 180;
        }
        static double distance(double lat1,
                            double lat2,
                            double lon1,
                            double lon2)
        {

            // The math module contains 
            // a function named toRadians 
            // which converts from degrees 
            // to radians. 
            lon1 = toRadians(lon1);
            lon2 = toRadians(lon2);
            lat1 = toRadians(lat1);
            lat2 = toRadians(lat2);

            // Haversine formula 
            double dlon = lon2 - lon1;
            double dlat = lat2 - lat1;
            double a = Math.Pow(Math.Sin(dlat / 2), 2) +
                    Math.Cos(lat1) * Math.Cos(lat2) *
                    Math.Pow(Math.Sin(dlon / 2), 2);

            double c = 2 * Math.Asin(Math.Sqrt(a));

            // Radius of earth in 
            // kilometers. Use 3956 
            // for miles 
            double r = 3963;

            // calculate the result 
            return (c * r);
        }

        // Driver code 
        static void Main()
        {
            Console.WriteLine("Enter Lat 1");
            double lat1 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Enter Lat 2");
            double lat2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Enter Long 1");
            double lon1 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Enter Long 2");
            double lon2 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine(distance(lat1, lat2,
                            lon1, lon2) + "Miles");
            Console.ReadLine();
        }
    }
}

// This code is contributed by 
// Manish Shaw(manishshaw1) 


