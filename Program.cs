using System;

namespace Planner
{
    class Program
    {
        static void Main (string[] args)
        {
            Building FiveOneTwoEigth = new Building ("512 8th Avenue")
            {
                Width = 3000,
                Depth = 10000,
                Stories = 10,

            };
            Building ThreeZeroOne = new Building ("301 Plus Park Blvd")
            {
                Width = 351,
                Depth = 1587,
                Stories = 10,
            };

            FiveOneTwoEigth.Construct ();
            FiveOneTwoEigth.Purchase ("Kev the Dev");

            ThreeZeroOne.Construct ();
            ThreeZeroOne.Purchase ("John Wark");
            Console.WriteLine (FiveOneTwoEigth.Descrition);
            Console.WriteLine (ThreeZeroOne.Descrition);

        }
    }
}