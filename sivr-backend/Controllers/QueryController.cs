using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;
using sivr_backend.Models;
using sivr_backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryController
    {
        private readonly IMetaDataRepository _metaDataRepository;

        public QueryController(IMetaDataRepository metaDataRepository)
        {
            _metaDataRepository = metaDataRepository;
        }

        // GET: api/query
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetaData>>> GetVideoResults([FromQuery] String text)
        {
            var results = await _metaDataRepository.Get(text);
            return results.ToList();
        }
    }
}
