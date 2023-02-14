using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class truck : IVehicle, ICompany
    {
        public truck()
        {
        }
        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;
        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 Wheel drive {GetType().Name} now driving forward . . .");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward . . .");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");

            }
        }
        public void Park()
        {
            Console.WriteLine();

        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}