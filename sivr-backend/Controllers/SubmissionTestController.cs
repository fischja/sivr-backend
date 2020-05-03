using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace sivr_backend.Controllers
{
    [Route("vbs/submit/")]
    [ApiController]
    public class SubmissionTestController : Controller
    {
        [HttpPost]
        public ActionResult Post(
            [FromQuery] int team,
            [FromQuery] int member,
            [FromQuery] int video,
            [FromQuery] int frame)
        {
            return Ok();
        }
    }
}