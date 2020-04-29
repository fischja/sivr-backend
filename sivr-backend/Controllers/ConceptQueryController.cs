using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sivr_backend.Models;
using sivr_backend.Repositories;

namespace sivr_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConceptQueryController : Controller
    {
        private IImageNetConceptRepository _imageNetConceptRepo;

        public ConceptQueryController(IImageNetConceptRepository imageNetConceptRepo)
        {
            _imageNetConceptRepo = imageNetConceptRepo;
        }

        [HttpGet]
        public IEnumerable<QueryResultDTO> Get([FromQuery] int id)
        {
            return _imageNetConceptRepo.GetConceptMatches(id);
        }
    }
}