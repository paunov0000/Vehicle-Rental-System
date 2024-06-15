using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System.Vehicles
{
    internal class Car : IVehicle
    {
        private string _brand;
        private string _model;
        private decimal _value;
        private int _safetyRating;
        private decimal _dailyRentalPrice = 20M;
        private decimal _insuranceCostPerDay;
        private bool _hasHighSafetyRating;
        public Car(string brand, string model, decimal value, int safetyRating)
        {
            _brand = brand;
            _model = model;
            _value = value;
            _safetyRating = safetyRating;
            _insuranceCostPerDay = value * 0.01M / 100;
            _hasHighSafetyRating = safetyRating > 3;
        }

        public string CalculateRentalPrice(int rentalPeriod, string customerFirstName, string customerLastName)
        {
            if (rentalPeriod > 7)
            {
                _dailyRentalPrice -= 5;
            }

            if (_hasHighSafetyRating)
            {
                _insuranceCostPerDay = _insuranceCostPerDay - (_insuranceCostPerDay * 0.9M);
            }

            CultureInfo culture = new CultureInfo("en-US");
            string formattedVehicleValue = _value.ToString("C", culture);
            string formattedTotalCost = ((_dailyRentalPrice + _insuranceCostPerDay) * rentalPeriod).ToString("C", culture);
            string formattedDailyRentalPrice = _dailyRentalPrice.ToString("C", culture);
            string formattedInsurancePerDayCost = _insuranceCostPerDay.ToString("C", culture);
            string formattedTotalInsuranceCost = (_insuranceCostPerDay * rentalPeriod).ToString("C", culture);
            string formattedTotalRentalCost = (_dailyRentalPrice * rentalPeriod).ToString("C", culture);

            StringBuilder output = new StringBuilder();
            DateTime currentDate = DateTime.Now;

            output.AppendLine($"A car valued at {formattedVehicleValue}, and has a security rating of {_safetyRating}.\n");

            output.AppendLine("XXXXXXXXXX");
            output.AppendLine($"Date: {currentDate}");
            output.AppendLine($"Customer: {customerFirstName} {customerLastName}");
            output.AppendLine($"Rented vehicle: {_brand} {_model}\n");

            output.AppendLine($"Reservation start date: {currentDate}");
            output.AppendLine($"Reservation end date: {currentDate.AddDays(rentalPeriod)}");
            output.AppendLine($"Actual rental days: {rentalPeriod} {(rentalPeriod > 1 ? "days" : "day")}\n");

            output.AppendLine($"Rental cost per day: {formattedDailyRentalPrice}");
            output.AppendLine($"Insurance per day: {formattedInsurancePerDayCost}\n");

            output.AppendLine($"Total rent: {formattedTotalRentalCost}");
            output.AppendLine($"Total insurance cost: {formattedTotalInsuranceCost}");
            output.AppendLine($"Total cost: {formattedTotalCost}");
            output.AppendLine("XXXXXXXXXX");

            return output.ToString();
        }
    }
}
