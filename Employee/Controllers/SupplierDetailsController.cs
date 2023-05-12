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
    [Route("api/SupplierDetails/[controller]")]
    [ApiController]
    public class SupplierDetailsController : Controller
    {
        private readonly ISupplierDetailsRepository _supplierDetailsRepository;

        public SupplierDetailsController(ISupplierDetailsRepository supplierDetailsRepository)
        {
            _supplierDetailsRepository = supplierDetailsRepository;

        }

        // GET: api/<controller>
        [HttpGet("select/{ID}")]
        public async Task<ActionResult> Select(string ID)
        {
            _supplierDetailsRepository.SetRequest(Request);
            var response = await _supplierDetailsRepository.Select(ID);

            if (response.Success)
                return Ok(response);
            else
                return StatusCode(StatusCodes.Status500InternalServerError, response);
        }
    }
}
