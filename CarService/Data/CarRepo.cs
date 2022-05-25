using System;
using System.Collections.Generic;
using System.Linq;
using CarService.Models;

namespace CarService.Data
{
    public class CarRepo : ICarRepo
    {
        private readonly AppDbContext context;

        public void AddCar(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            this.context.Add(car);
            this.context.SaveChanges();
        }

        public void DeleteCarById(int Id)
        {
            var car = this.context.Cars.FirstOrDefault(r => r.Id == Id);
            if (car != null)
            {
                this.context.Cars.Remove(car);
                this.context.SaveChanges();
            }
            else
            {
                throw new Exception("There is no existing car with that id.");
            }
        }

        public IEnumerable<Car> GetAllCars()
        {
            return this.context.Cars.ToList();
        }

        public Car GetCarById(int Id)
        {
            return this.context.Cars.FirstOrDefault(r => r.Id == Id);
        }

        public bool SaveChanges()
        {
            return (this.context.SaveChanges() >= 0);
        }
    }
}