using Microsoft.EntityFrameworkCore;
using sivr_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Repositories
{
    public class ImageNetConceptRepository : IImageNetConceptRepository
    {
        private SivrContext _context;

        public ImageNetConceptRepository(SivrContext context)
        {
            _context = context;
        }

        public IEnumerable<QueryResultDTO> GetConceptMatches(int conceptId)
        {
            return _context.ImageNetConceptScores
                .Where(x => x.ImageNetConceptId == conceptId)
                .OrderByDescending(x => x.Score)
                .Take(200)
                .Select(x => new QueryResultDTO() { V3CId = x.V3CId, KeyframeNumber = x.KeyframeNumber });
        }

        public async Task<Dictionary<string, short>> GetNameToIdMap()
        {
            return await _context.ImageNetConceptNames.ToDictionaryAsync(x => x.Name, x => x.ImageNetConceptId);
        }
    }
}
