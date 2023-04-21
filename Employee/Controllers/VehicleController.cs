using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Employee.Models;
using Employee.Repository.Interfaces;


namespace Employee.API.Controllers
{
    [Route("api/Employee/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;

        }

        // GET: api/<controller>
        [HttpGet("select/{VehicleID}")]
        public async Task<ActionResult> Select(string VehicleID)
        {
            _vehicleRepository.SetRequest(Request);
            var response = await _vehicleRepository.Select(VehicleID);

            if (response.Success)
                return Ok(response);
            else
                return StatusCode(StatusCodes.Status500InternalServerError, response);
        }

        // POST api/<controller>
        [HttpPost("Insert")]
        public async Task<ActionResult> Insert(VehicleClass vehicle)
        {
            _vehicleRepository.SetRequest(Request);
            var response = await _vehicleRepository.Insert(vehicle);
            if (response.Success)
                return Ok(response);
            else
                return StatusCode(StatusCodes.Status500InternalServerError, response);

        }

        // PUT api/<controller>/5
        [HttpPost("Update")]
        public async Task<ActionResult> Update(VehicleClass vehicle)
        {
            _vehicleRepository.SetRequest(Request);
            var response = await _vehicleRepository.Update(vehicle);
            if (response.Success)
                return Ok(response);
            else
                return StatusCode(StatusCodes.Status500InternalServerError, response);

        }

        // DELETE api/<controller>/5
        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete(string VehicleID)
        {
            _vehicleRepository.SetRequest(Request);
            var response = await _vehicleRepository.Delete(VehicleID);
            if (response.Success)
                return Ok(response);
            else
                return StatusCode(StatusCodes.Status500InternalServerError, response);

        }
    }
}
