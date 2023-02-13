using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}

        public bool HasTruckBed { get; set; }
        public bool HasBigWheels { get; set; }
        public bool CanHonk { get ; set ; }
        public string CarColor { get ; set ; }
        public bool HasStereo { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public string Name { get ; set ; }
        public string Location { get ; set ; }
        
    }
}

