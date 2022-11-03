using ASS_API.Reppository_Di;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASS_API.Models;

namespace ASS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointment _appointment;

        public AppointmentController(IAppointment appointment)
        {
            _appointment = appointment;
        }

        [HttpPost("")]
        public async Task<IActionResult> BookAppointment([FromBody]AppointmentSchedulingModel appointment)
        {
            return Ok();
        }


    }
}
