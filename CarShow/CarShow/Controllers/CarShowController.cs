using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using CarShow.Services;
using CarShow.Models;
namespace CarShow.Controllers
{

    [Route("api/[controller]")]
    public class CarShowController:ControllerBase
    {
        public ICarServices _service;
        public CarShowController(ICarServices service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<ICollection<CarModel>> GetCars()
        {
            try
            {
                return Ok(_service.GetCars());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{carId:long}")]
        public ActionResult<bool> GetCar(long carId)
        {
            try
            {
                var car = _service.GetCar(carId);
                return Ok(car);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{carId:long}")]
        public ActionResult<bool> DeleteCar(long carId)
        {
            try
            {
                var result = _service.DeleteCar(carId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public ActionResult<int> CreateCar([FromBody] CarModel newCar)
        {
            try
            {
                var car = _service.CreateCar(newCar);
                return Created($"/api/carshow/{car.Id}", car);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something unexpected happened.");
            }
        }
        [HttpPut("{carId:long}")]
        public ActionResult<CarModel> UpdateCar(long carId,[FromBody] CarModel carEdited)
        {
            try
            {
                var car = _service.UpdateCar(carId, carEdited);
                return Ok(car);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
