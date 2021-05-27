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
                Date = new DateTime(2020, 9, 28),
                MainPhoto = "https://i.blogs.es/e82402/screenshot-4/1366_2000.jpg",
                TypeCar = "Sedan",
                Velocity = 290,
                Country = "Aleman",
                TypeEnergy = "Electrico",
                Transmission = "-",
                Description = "Los conceptos generalmente no salen de un stand en una feria tecnológica o presentación, sin embargo no ha sido así con el Vision AVTR. Este coche eléctrico de Mercedes-Benz, si bien no se producirá en masa, tiene una versión funcional con la que se puede circular. En el siguiente vídeo podemos ver cómo se imagina el fabricante aleman el coche del futuro."
            });
            _cars.Add(new CarModel()
            {
                Id = 2,
                Name = "Delorean",
                Company = "DMC",
                Date = new DateTime(1981, 1, 1),
                MainPhoto = "https://www.autopista.es/uploads/s1/57/16/51/9/article-delorean-dmc-12-deportivo-regreso-al-futuro-historia-105163-5624bc0d263c2.jpeg",
                TypeCar = "Deportivo",
                Velocity = 209,
                Country = "UK",
                TypeEnergy = "Gasolina",
                Transmission = "Automatica",
                Description = "Sin escatimar esfuerzos ni dinero convocó a renombrados personajes de la industria: Giorgetto Giugiaro realizó el styling de su auto, mientras que William T. Collins, exingeniero en jefe de Pontiac, le dio forma al proyecto que llevaría el nombre de DMC-12, sigla que corresponde a las iniciales de la empresa (DeLorean Motor Company), seguido del precio que calcularon que costaría el auto (12.000 dólares). Cuando el modelo se lanzó a la venta, su precio era más del doble de esa estimación, por lo que, a continuación, trataremos de sintetizar algunos de los imprevistos que DMC tuvo que afrontar y sus lógicos resultados."
            });
            _cars.Add(new CarModel()
            {
                Id = 3,
                Name = "Smera",
                Company = "Lumeneo",
                Date = new DateTime(2008, 10, 4),
                MainPhoto = "https://www.mad4wheels.com/img/free-car-images/mobile/5930/lumeneo-smera-2009-283414.jpg",
                TypeCar = "Compacto",
                Velocity = 110,
                Country = "España",
                TypeEnergy = "Electrico",
                Transmission = "-",
                Description = "El SMERA es un concept car de vehículo eléctrico de batería ultracompacto (BEV) producido por Lumeneo . El concept car es un automóvil biplaza basculante que se inclina hasta 25 ° en las curvas. Con una longitud de 2500 mm y una anchura de 960 mm (vía 655 mm), es algo entre un coche eléctrico y un scooter e incluye una batería de iones de litio ."
            });
            _cars.Add(new CarModel()
            {
                Id = 4,
                Name = "Cybertruck",
                Company = "Tesla",
                Date = new DateTime(2019, 1, 1),
                MainPhoto = "https://www.tesla.com/xNVh4yUEc3B9/04_Desktop.jpg",
                TypeCar = "Camioneta electrica",
                Velocity = 193,
                Country = "USA",
                TypeEnergy = "Electrico",
                Transmission = "Traccion trasera",
                Description = "El Tesla Cybertruck es la camioneta eléctrica de Tesla, un vehículo revelado recientemente que entrará en producción a finales de 2021 y del que ya se han reportado más de 250.000 reservas desde que fuera oficialmente presentado. Lo que más ha dado de qué hablar ha sido sin duda, el diseño futurista Tesla pick-up, el Cybertruck. Sus líneas planas, grandes superficies limpias y su aspecto rescatado del futuro, tienen como resultado una camioneta totalmente eléctrica que llega para competir en el segmento más ajustado del mercado estadounidense."
            }) ;
            _cars.Add(new CarModel()
            {
                Id = 5,
                Name = "Honda Civic LX",
                Company = "Honda",
                Date = new DateTime(1995, 1, 1),
                MainPhoto = "https://i.pinimg.com/originals/d7/a6/9b/d7a69b405ded79a8aed6b8677c9dc681.jpg",
                TypeCar = "Deportivo Compacto",
                Velocity = 190,
                Country = "USA",
                TypeEnergy = "Gasolina",
                Transmission = "Automatica - Manual",
                Description = "El 1995 Honda Civic LX está propulsado por un 1.5 litros , motor de cuatro cilindros con una potencia de salida de 102 caballos de fuerza a 5.900 rpm y 98 libras-pie de torque a 5.000 rpm. El LX también viene de serie con una transmisión de sobremarcha manual de cinco velocidades."
            });
            _cars.Add(new CarModel()
            {
                Id = 6,
                Name = "Subaru Impreza WRC",
                Company = "Subaru",
                Date = new DateTime(1994, 1, 1),
                MainPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Washauto06_subaru_impreza.jpg/245px-Washauto06_subaru_impreza.jpg",
                TypeCar = "Deportivo",
                Velocity = 180,
                Country = "Japon",
                TypeEnergy = "Gasolina",
                Transmission = "Manual",
                Description = "El Subaru Impreza WRC es un vehículo de rally basado en el Subaru Impreza con homologación World Rally Car. Fue usado principalmente por el equipo oficial de Subaru en el mundial y por equipos privados tanto en el mundial como en otras competiciones. Hizo su debut en 1994 y participó en el Campeonato Mundial de Rally hasta 2008."
            });
            _cars.Add(new CarModel()
            {
                Id = 7,
                Name = "Skoda Octavia Kit Car",
                Company = "Skoda",
                Date = new DateTime(1997, 9, 1),
                MainPhoto = "http://www.autosport.cz/img/technika/d48828684b34bcf9fb91a87703962118.jpg",
                TypeCar = "Deportivo",
                Velocity = 230,
                Country = "Republica Checa",
                TypeEnergy = "Gasolina",
                Transmission = "Manual",
                Description = "  Škoda Octavia 2.0 Kit Car para la venta, producción original de Skoda Motorsport, caja de cambios secuencial Sadev 6 velocidades, 3 juegos de 18 ruedas, 1050kg, frenos AP Racing, suspensión Proflex."
            });
            _cars.Add(new CarModel()
            {
                Id = 8,
                Name = "Córdoba WRC",
                Company = "SEAT",
                Date = new DateTime(1998, 1, 1),
                MainPhoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/SEAT_Cordoba_WRC.jpg/245px-SEAT_Cordoba_WRC.jpg",
                TypeCar = "Deportivo",
                Velocity = 200,
                Country = "España",
                TypeEnergy = "Gasolina",
                Transmission = "Manual",
                Description = "El SEAT Córdoba WRC es un vehículo de rally basado en el SEAT Córdoba con homologación World Rally Car. Fue construido por SEAT para participar en el Campeonato del Mundo de Rally en el equipo oficial, el SEAT World Rally Team que es gestionado por su departamento deportivo, SEAT Sport. Debutó en el Rally de Finlandia de 1998 y participó desde ese año hasta 2000."
            });

            _cars.Add(new CarModel()
            {
                Id = 9,
                Name = "Jeep Wrangler Rubicon 4xe",
                Company = "JEEP",
                Date = new DateTime(2021, 5, 1),
                MainPhoto = "https://soymotor.com/sites/default/files/styles/large/public/imagenes/noticia/jeep-wrangler-4xe-principal-soymotor.jpg",
                TypeCar = "Todoterreno",
                Velocity = 130,
                Country = "USA",
                TypeEnergy = "Gasolina",
                Transmission = "Automatico",
                Description = "El Jeep Wrangler 4xe 2021 combina un motor de gasolina de cuatro cilindros en línea y 2.0 litros con dos motores eléctricos para entregar una potencia total de 380 caballos, con un par máximo de 647 Newton metro. Posee 8 velocidades."
            });
            _cars.Add(new CarModel()
            {
                Id = 10,
                Name = "E4",
                Company = "Quantum",
                Date = new DateTime(2020, 10, 16),
                MainPhoto = "https://www.paginasiete.bo/u/fotografias/m/2019/9/14/f800x450-281133_332579_5050.jpg",
                TypeCar = "Carro de ciudad",
                Velocity = 55,
                Country = "Bolivia",
                TypeEnergy = "Electrico",
                Transmission = "-",
                Description = "En cualquier condición y tipo de conducción, se asegura un mínimo de 55 Km de autonomía. En determinadas condiciones es posible alcanzar más de 65 Km de autonomía."
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
            car.TypeCar = carEdited.TypeCar ?? car.TypeCar;
            car.MainPhoto = carEdited.MainPhoto ?? car.MainPhoto;
            car.Velocity = carEdited.Velocity ?? car.Velocity;
            car.Date = carEdited.Date ?? car.Date;
            car.Company = carEdited.Company ?? car.Company;
            car.Transmission = carEdited.Transmission ?? car.Transmission;
            car.TypeEnergy = carEdited.TypeEnergy ?? car.TypeEnergy;
            car.Country = carEdited.Country ?? car.Country;
            car.Description = carEdited.Description ?? car.Description;
            return car;
        }
    }
}
