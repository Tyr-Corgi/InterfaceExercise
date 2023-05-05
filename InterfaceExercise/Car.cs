using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
            
        }
        public int Tires { get ; set ; }
        public int HowManyDoors { get ; set ; }
        public int Seats { get ; set ; }
        public double GasMilage { get ; set ; }
        public double Year { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public string CorpName { get ; set ; }
        public bool Bankrupt { get ; set ; }
    }
}
