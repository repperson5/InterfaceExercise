using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; }
        public bool HasSteeringWheel { get; set; }

        public bool CanHonk { get ; set ; }
        public string CarColor { get; set; }
        public bool HasStereo { get; set ; }
        public int NumberOfWheels { get ; set ; }
        public string Name { get ; set ; }
        public string Location { get ; set; }
    }
}

