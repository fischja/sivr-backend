using sivr_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Repositories
{
    public interface IMetaDataRepository
    {
        Task<IList<MetaData>> Get(string text);
    }
}
