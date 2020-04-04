using Microsoft.EntityFrameworkCore;
using sivr_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Repositories
{
    public class MetaDataRepository : IMetaDataRepository
    {
        private readonly SivrContext _context;

        public MetaDataRepository(SivrContext context)
        {
            _context = context;
        }

        public async Task<IList<MetaData>> Get(string text)
        {
            return await _context.MetaDatas.ToListAsync();
        }

    }
}
