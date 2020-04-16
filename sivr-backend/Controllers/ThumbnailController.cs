using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sivr_backend.Repositories;

namespace sivr_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThumbnailController : Controller
    {
        private readonly IThumbnailRepository _thumbnailRepository;

        public ThumbnailController(IThumbnailRepository thumbnailRepository)
        {
            _thumbnailRepository = thumbnailRepository;
        }

        // GET: api/query
        [HttpGet]
        public IActionResult GetThumbnail([FromQuery] int v3cId, int frame)
        {
            var fileStream = _thumbnailRepository.Get(v3cId, frame);
            if (fileStream == null)
            {
                return NotFound();
            }

            return File(fileStream, "image/png");
        }
    }
}