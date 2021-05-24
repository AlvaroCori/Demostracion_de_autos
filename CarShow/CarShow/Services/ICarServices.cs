using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShow.Models;
namespace CarShow.Services
{
    public interface ICarServices
    {

        public ICollection<CarModel> GetCars();
        public CarModel GetCar(long carId);
        public bool DeleteCar(long carId);
        public CarModel CreateCar(CarModel newCar);

        public CarModel UpdateCar(long carId, CarModel carEdited);
    }
}
