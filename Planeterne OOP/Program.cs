using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet mercury = new Planet("Mercury", 0.330, 4879, 5479, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);
            Planet venus = new Planet("Venus",4.87, 12194, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);
            Planet jorden = new Planet("Earth",5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false);
            Planet mars = new Planet("Mars",0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
            Planet jupiter = new Planet("Jupiter",1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
            Planet saturn = new Planet("Saturn",568, 129536, 687, 9.0, 10.7, 10.7, 1433.5, 10.747, 9.7, -140, 62, true);
            Planet uranus = new Planet("Uranus",86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.589, 6.8, -195, 27, true);
            Planet neptun = new Planet("Neptun",102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true);
            Planet pluto = new Planet("Pluto",0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);

            List<Planet> Plantes = new List<Planet>();
            Plantes.Add(mercury);
            Plantes.Add(venus);
            Plantes.Add(jorden);
            Plantes.Add(mars);
            Plantes.Add(jupiter);
            Plantes.Add(saturn);
            Plantes.Add(uranus);
            Plantes.Add(neptun);
            Plantes.Add(pluto);
            Console.WriteLine(Plantes.Count());

            /*List<Planet> Temperatureundernul = new List<Planet>();
            foreach (var item in Plantes)
            {
                if (item.Temperature < 0)
                {
                    Temperatureundernul.Add(item);
                }
            }
            foreach (var item in Temperatureundernul)
            {
                Console.WriteLine(item.Name);
            }*/

            List<Planet> kilometer = new List<Planet>();
            foreach (var item in Plantes)
            {
                if (item.Diameter > 10000 && item.Diameter < 50000)
                {
                    kilometer.Add(item);
                }
            }

            foreach (var item in kilometer)
            {
                Console.WriteLine(item.Name);
            }




            /*foreach (var item in Plantes)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Mads);
                Console.WriteLine(item.Diameter);
                Console.WriteLine(item.Density);
                Console.WriteLine(item.Gravity);
                Console.WriteLine(item.LenghtOfDay);
                Console.WriteLine(item.DistanceFromSun);
                Console.WriteLine(item.OrbitalPeriod);
                Console.WriteLine(item.OrbitalVelocity);
                Console.WriteLine(item.Temperature);
                Console.WriteLine(item.NumberOfMoons);
                Console.WriteLine();

            }*/


            Console.ReadKey();
        }
    }
}
