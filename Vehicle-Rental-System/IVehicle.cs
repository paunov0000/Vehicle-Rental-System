using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal interface IVehicle
    {
        public string CalculateRentalPrice(int rentalPeriod, string customerFirstName, string customerLastName);
    }
}
