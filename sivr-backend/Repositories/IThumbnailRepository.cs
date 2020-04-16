using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Repositories
{
    public interface IThumbnailRepository
    {
        FileStream Get(int v3cId, int frame);
    }
}
