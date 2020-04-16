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
    public class QueryController : Controller
    {
        private readonly IMetaDataRepository _metaDataRepository;
        private readonly IThumbnailRepository _thumbnailRepository;

        public QueryController(IMetaDataRepository metaDataRepository, IThumbnailRepository thumbnailRepository)
        {
            _metaDataRepository = metaDataRepository;
            _thumbnailRepository = thumbnailRepository;
        }

        // GET: api/query
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetaDataDTO>>> GetVideoResults([FromQuery] String text)
        {
            var results = await _metaDataRepository.Get(text);
            return results
                .Select(x => new MetaDataDTO() { V3CId = x.V3CId })
                .ToList();
        }
    }
}
