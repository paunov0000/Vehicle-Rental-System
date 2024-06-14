using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal interface IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Value { get; set; }
        public string CalculateRentalPrice(int rentalPeriod);
    }
}
