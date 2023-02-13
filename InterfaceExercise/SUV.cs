using System;
namespace InterfaceExercise
{
	public class SUV:IVehicle, ICompany
	{
		public SUV()
		{
		}
        public bool IsFourDoor { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public bool CanHonk { get ; set ; }
        public string CarColor { get ; set ; }
        public bool HasStereo { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public string Name { get ; set ; }
        public string Location { get ; set ; }
       
    }
}

