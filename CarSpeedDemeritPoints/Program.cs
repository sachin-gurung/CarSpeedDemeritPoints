using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSpeedDemeritPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            int carSpeed;
            int Points = 0;
            int counter;

            Console.Write("Enter the speed limit in km/hr: ");
            speedLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter the car speed in km/hr: ");
            carSpeed = int.Parse(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int speedDifference = carSpeed - speedLimit;
                for (counter = 5; counter <= speedDifference; counter++)
                {
                    if (counter % 5 == 0)
                    {
                        Points++;
                    }
                }
            }
            Console.Write("Demerit points: ");
            Console.WriteLine(Points);

            if (Points > 12)
                Console.WriteLine("Your Lincense is suspended");
        }
    }
}
/*
Enter the speed limit in km/hr: 70
Enter the car speed in km/hr: 85
Demerit points: 3
Press any key to continue . . .
*/
