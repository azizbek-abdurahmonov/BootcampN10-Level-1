using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT1
{
    internal class CarRentalManagement
    {
        public List<CarRental> Cars = new List<CarRental>();

        public void Add(CarRental car)
        {
            Cars.Add(car);
        }

        public CarRental Rent(string BrandName)
        {
            foreach (CarRental car in Cars)
            {
                if (car.BrandName == BrandName && car.isRented == false)
                {
                    car.RentStartTime = DateTime.Now;
                    car.isRented = true;
                    return car;
                }
            }
            Console.WriteLine("Uzr, hozirda ijaraga moshina yo'q");
            return null;
        }

        public void Return(CarRental car)
        {
            foreach (var carB in Cars)
            {
                if (carB.Id == car.Id)
                {
                    car.isRented = false;
                    var seconds = (DateTime.Now - car.RentStartTime).TotalSeconds;
                    if (car is Bmw)
                    {
                        car.Balance += seconds * Bmw.RentPricePerHour;
                    }
                    if (car is Audi)
                    {
                        car.Balance += seconds * Audi.RentPricePerHour;
                    }
                }
            }
        }

        public void CalculateBalance()
        {
            var sum = default(double);
            foreach (var car in Cars)
            {
                sum += car.Balance;
            }
            Console.WriteLine($"Umumiy balance: {sum}");
        }

        public CarRentalManagement()
        {
            Cars = new List<CarRental>();
        }
    }
}
