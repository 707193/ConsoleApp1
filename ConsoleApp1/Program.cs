using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _707193
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new CountrySide();
            a.Run();


            Console.WriteLine(UsingRecursion.CalculateRecursively(3, 4));


        }

        class prabh
        {
            static int j = 0;

            public void jyot()
            {
                //let's write a trace message

                Console.WriteLine(prabh.j++);
                int Sum = 0;
                Sum += 1;
                jyot();

            }
        }


        class UsingRecursion
        {
            // Create an application which 
            // calculates the sum of all the numbers from n to m recursively:

            public static int CalculateRecursively(int n, int m)
            {
                int sum = n;

                if (n < m)
                {
                    n++;
                    return sum += CalculateRecursively(n, m);
                }
                return sum;
            }


        }

        class CountrySide
        {
            // Create the LinkedList to reflect the Map in the PowerPoint Instructions
            Village Maeland;
            Village Helmholtz;
            Village Alst;
            Village Wessig;
            Village Badden;
            Village Uster;
            Village Schvenig;

            public void Run()
            {
                Village Maeland = new Village("Maeland", false);
                Village Helmholtz = new Village(" Helmholtz", false); 
                Village Alst = new Village("Alst", false);
                Village Wessig = new Village("Wessig", false);
                Village Badden = new Village("Badden", true);
                Village Uster = new Village("Uster", false);
                Village Schvenig = new Village(" Schvenig ", false);

                Maeland.west = Schvenig;
                Maeland.east = Wessig;
                Maeland.distanceToWestVillage = 14;
                Maeland.distanceToEastVillage = 19;

                Helmholtz.west = Schvenig;
                Helmholtz.east = Wessig;
                Helmholtz.distanceToWestVillage = 14;
                Helmholtz.distanceToEastVillage = 19;


                Alst.west = Schvenig;
                Alst.east = Wessig;
                Alst.distanceToWestVillage = 14;
                Alst.distanceToEastVillage = 19;

                Wessig.west = Schvenig;
                Wessig.east = Wessig;
                Wessig.distanceToWestVillage = 14;
                Wessig.distanceToEastVillage = 19;

                Badden.west = Schvenig;
                Badden.east = Wessig;
                Badden.distanceToWestVillage = 14;
                Badden.distanceToEastVillage = 19;


                Uster.west = Schvenig;
                Uster.east = Wessig;
                Uster.distanceToWestVillage = 14;
                Uster.distanceToEastVillage = 19;

                Schvenig.west = Schvenig;
                Schvenig.east = Wessig;
                Schvenig.distanceToWestVillage = 14;
                Schvenig.distanceToEastVillage = 19;



            }
            public void travelVillages()
            {

            }
        }


        class Village
        {
            public Village(string _villageName, bool _isAHere)
            {
                isAstrildgeHere = _isAHere;
                VillageName = _villageName;
            }

            public Village west;
            public Village east;
            public string VillageName;
            public int distanceToNextVillage;
            public int distanceToWestVillage;
            public int distanceToEastVillage;
            public int distanceToPreviousVillage;
            public bool isAstrildgeHere;
        }

    }
}
}