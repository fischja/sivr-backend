using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sivr_backend.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sivr_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConceptController : Controller
    {
        private IImageNetConceptRepository _imageNetConceptRepo;
        public ConceptController(IImageNetConceptRepository imageNetConceptRepository)
        {
            _imageNetConceptRepo = imageNetConceptRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult<Dictionary<string, short>> Get()
        {
            return _imageNetConceptRepo.GetNameToIdMap();
        }
    }
}
