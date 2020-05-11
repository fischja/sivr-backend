using sivr_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Repositories
{
    public interface IImageNetConceptRepository
    {
        Dictionary<string, short> GetNameToIdMap();

        IEnumerable<QueryResultDTO> GetConceptMatches(int conceptId, string colorId, int queryMode);
    }
}
