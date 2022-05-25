using System.Collections.Generic;
using CarService.Models;

namespace CarService.Data
{
    public interface ICarRepo
    {
        bool SaveChanges();

        IEnumerable<Car> GetAllCars();

        Car GetCarById(int Id);

        void AddCar(Car car);

        void DeleteCarById(int Id);
    }
}