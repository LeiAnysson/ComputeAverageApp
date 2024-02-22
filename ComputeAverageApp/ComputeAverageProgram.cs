using System;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double grdOne, grdTwo, grdThree, grdFour, grdFive;
            Console.WriteLine("Enter 5 grades separated by new Line: ");
            grdOne = Convert.ToInt32(Console.ReadLine());
            grdTwo = Convert.ToInt32(Console.ReadLine());
            grdThree = Convert.ToInt32(Console.ReadLine());
            grdFour = Convert.ToInt32(Console.ReadLine());
            grdFive = Convert.ToInt32(Console.ReadLine());
            double total = grdOne + grdTwo + grdThree + grdFour + grdFive;
            double avg = total / 5;

            Console.WriteLine("The average is " + avg + " and round off to " + Math.Round(avg));
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
