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
        public IEnumerable<QueryResultDTO> Get(
            [FromQuery] int conceptId, 
            [FromQuery] int queryMode,
            [FromQuery] string colorId)
        {
            queryMode = Math.Max(0, queryMode);
            queryMode = Math.Min(2, queryMode);

            return _imageNetConceptRepo.GetConceptMatches(conceptId, colorId, queryMode);
        }
    }
}