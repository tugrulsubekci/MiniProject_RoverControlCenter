using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_RoverControlCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] allRovers = { lunokhod, apollo, sojourner };

            DirectAll(allRovers);

            Object[] xx = { lunokhod, apollo, sojourner, sputnik };

            foreach (Object o in xx)
            {
                Console.WriteLine($"Tracking a....{o.GetType()}");
            }

            IDirectable[] yy = { lunokhod, apollo, sojourner, sputnik };
            
            DirectAll(yy);
            
            //to keep console open
            Console.ReadLine();

            

        }
        public static void DirectAll(Rover[] allRovers)
        {
            foreach (Rover rover in allRovers)
            {
                Console.WriteLine(rover.GetInfo());
                Console.WriteLine(rover.Explore());
                Console.WriteLine(rover.Collect());
            }
        }
        public static void DirectAll(IDirectable[] probes)
        {
            foreach (IDirectable probe in probes)
            {
                Console.WriteLine(probe.GetInfo());
                Console.WriteLine(probe.Explore());
                Console.WriteLine(probe.Collect());
            }
        }
    }
}
