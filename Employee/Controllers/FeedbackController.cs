using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Employee.Models;
using Employee.Repository.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.API.Controllers
{
    [Route("api/Employee/[controller]")]
    [ApiController]
    public class FeedbackController : Controller
    {
        private readonly IFeedbakRepository _feedbackRepository;

        public FeedbackController(IFeedbakRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;

        }

        // GET: api/<controller>
        [HttpGet("select/{Name}")]
        public async Task<ActionResult> Select(string Name)
        {
            _feedbackRepository.SetRequest(Request);
            var response = await _feedbackRepository.Select(Name);

            if (response.Success)
                return Ok(response);
            else
                return StatusCode(StatusCodes.Status500InternalServerError, response);
        }

        // POST api/<controller>
        [HttpPost("Insert")]
        public async Task<ActionResult> Insert(FeedbackModel feedback)
        {
            _feedbackRepository.SetRequest(Request);
            var response = await _feedbackRepository.Insert(feedback);
            if (response.Success)
                return Ok(response);
            else
                return StatusCode(StatusCodes.Status500InternalServerError, response);

        }

        // PUT api/<controller>/5
        [HttpPost("Update")]
        public async Task<ActionResult> Update(FeedbackModel feedback)
        {
            _feedbackRepository.SetRequest(Request);
            var response = await _feedbackRepository.Update(feedback);
            if (response.Success)
                return Ok(response);
            else
                return StatusCode(StatusCodes.Status500InternalServerError, response);

        }

        // DELETE api/<controller>/5
        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete(string Name)
        {
            _feedbackRepository.SetRequest(Request);
            var response = await _feedbackRepository.Delete(Name);
            if (response.Success)
                return Ok(response);
            else
                return StatusCode(StatusCodes.Status500InternalServerError, response);

        }
    }
}
