using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Repositories
{
    public class ThumbnailRepository : IThumbnailRepository
    {
        public FileStream Get(int v3cId, int frame)
        {
            var folderId = v3cId.ToString("D" + 5);
            var filePath = @$"D:\Interactive Video Retrieval\thumbnails\thumbnails\{folderId}\shot{folderId}_{frame}.png";

            if (!File.Exists(filePath)) 
            {
                return null;
            }

            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None, 4096, FileOptions.Asynchronous);
            return fileStream;
        }
    }
}
