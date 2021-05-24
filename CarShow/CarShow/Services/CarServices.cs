using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShow.Models;
namespace CarShow.Services
{
    public class CarServices : ICarServices
    {
        ICollection<CarModel> _cars;
        public CarServices()
        {
            _cars = new List<CarModel>();
            _cars.Add(new CarModel()
            {
                Id = 1,
                Name = "Vision AVTR",
                Company = "Mercedes",
                Date = new DateTime(2070, 10, 20),
                MainPhoto = "https://i.blogs.es/e82402/screenshot-4/1366_2000.jpg",
                Model = "Sedan",
                Velocity = 290,
                Description = "Los conceptos generalmente no salen de un stand en una feria tecnológica o presentación, sin embargo no ha sido así con el Vision AVTR. Este coche eléctrico de Mercedes-Benz, si bien no se producirá en masa, tiene una versión funcional con la que se puede circular. En el siguiente vídeo podemos ver cómo se imagina el fabricante aleman el coche del futuro."
            });
            _cars.Add(new CarModel()
            {
                Id = 2,
                Name = "Delorean",
                Company = "DMC",
                Date = new DateTime(1981, 1, 1),
                MainPhoto = "https://www.autopista.es/uploads/s1/57/16/51/9/article-delorean-dmc-12-deportivo-regreso-al-futuro-historia-105163-5624bc0d263c2.jpeg",
                Model = "Deportivo",
                Velocity = 209,
                Description = "Sin escatimar esfuerzos ni dinero convocó a renombrados personajes de la industria: Giorgetto Giugiaro realizó el styling de su auto, mientras que William T. Collins, exingeniero en jefe de Pontiac, le dio forma al proyecto que llevaría el nombre de DMC-12, sigla que corresponde a las iniciales de la empresa (DeLorean Motor Company), seguido del precio que calcularon que costaría el auto (12.000 dólares). Cuando el modelo se lanzó a la venta, su precio era más del doble de esa estimación, por lo que, a continuación, trataremos de sintetizar algunos de los imprevistos que DMC tuvo que afrontar y sus lógicos resultados."
            });
            _cars.Add(new CarModel()
            {
                Id = 3,
                Name = "Smera",
                Company = "Lumeneo",
                Date = new DateTime(2008, 10, 4),
                MainPhoto = "https://www.mad4wheels.com/img/free-car-images/mobile/5930/lumeneo-smera-2009-283414.jpg",
                Model = "Compacto",
                Velocity = 110,
                Description = "El SMERA es un concept car de vehículo eléctrico de batería ultracompacto (BEV) producido por Lumeneo . El concept car es un automóvil biplaza basculante que se inclina hasta 25 ° en las curvas. Con una longitud de 2500 mm y una anchura de 960 mm (vía 655 mm), es algo entre un coche eléctrico y un scooter e incluye una batería de iones de litio ."
            });
            _cars.Add(new CarModel()
            {
                Id = 4,
                Name = "Cybertruck",
                Company = "Tesla",
                Date = new DateTime(2019, 1, 1),
                MainPhoto = "https://www.tesla.com/xNVh4yUEc3B9/04_Desktop.jpg",
                Model = "Camioneta electrica",
                Velocity = 193,
                Description= "El Tesla Cybertruck es la camioneta eléctrica de Tesla, un vehículo revelado recientemente que entrará en producción a finales de 2021 y del que ya se han reportado más de 250.000 reservas desde que fuera oficialmente presentado. Lo que más ha dado de qué hablar ha sido sin duda, el diseño futurista Tesla pick-up, el Cybertruck. Sus líneas planas, grandes superficies limpias y su aspecto rescatado del futuro, tienen como resultado una camioneta totalmente eléctrica que llega para competir en el segmento más ajustado del mercado estadounidense."
            });
        }
        public CarModel CreateCar(CarModel newCar)
        {
            var newId = _cars.OrderByDescending(t => t.Id).First().Id + 1;
            newCar.Id = newId;
            _cars.Add(newCar);
            return newCar;
        }

        public bool DeleteCar(long carId)
        {
            var car = _cars.FirstOrDefault(c => c.Id == carId);
            var result = false;
            if (car != null)
            {
                _cars.Remove(car);
                result = true;
            }
            return result;
        }

        public CarModel GetCar(long carId)
        {
            var car = _cars.FirstOrDefault(c=>c.Id==carId);
            return car;
        }

        public ICollection<CarModel> GetCars()
        {
            return _cars;
        }

        public CarModel UpdateCar(long carId, CarModel carEdited)
        {
            var car = _cars.FirstOrDefault(c => c.Id == carId);
            car.Name = carEdited.Name ?? car.Name;
            car.Model = carEdited.Model ?? car.Model;
            car.MainPhoto = carEdited.MainPhoto ?? car.MainPhoto;
            car.Velocity = carEdited.Velocity ?? car.Velocity;
            car.Date = carEdited.Date ?? car.Date;
            car.Description = carEdited.Description ?? car.Description;
            return car;
        }
    }
}
