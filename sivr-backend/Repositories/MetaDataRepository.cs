using Microsoft.EntityFrameworkCore;
using sivr_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
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
            return _context.MetaDatas
                .AsEnumerable()
                .Select(x => new
                {
                    NumOccurences = x.Title.CountSubstring(text)
                                    + x.FullTitle.CountSubstring(text)
                                    + x.Description.CountSubstring(text)
                                    + x.Licence.CountSubstring(text)
                                    + x.Extractor.CountSubstring(text)
                                    + x.ExtractorKey.CountSubstring(text)
                                    + x.SourceOrigFilename.CountSubstring(text)
                                    + x.DisplayId.CountSubstring(text)
                                    + x.WebpageUrl.CountSubstring(text)
                                    + x.WebpageUrlBasename.CountSubstring(text)
                                    + x.Thumbnail.CountSubstring(text)
                                    + x.Format.CountSubstring(text)
                                    + x.FormatId.CountSubstring(text)
                                    + x.Resolution.CountSubstring(text)
                                    + x.StretchedRatio.CountSubstring(text)
                                    + x.Fps.CountSubstring(text)
                                    + x.Abr.CountSubstring(text)
                                    + x.Ext.CountSubstring(text)
                                    + x.Vbr.CountSubstring(text)
                                    + x.ACodec.CountSubstring(text)
                                    + x.VCodec.CountSubstring(text)
                                    + x.Channel.CountSubstring(text)
                                    + x.Uploader.CountSubstring(text)
                                    + x.UploaderId.CountSubstring(text)
                                    + x.UploaderUrl.CountSubstring(text)
                                    + x.Playlist.CountSubstring(text),
                    Obj = x
                })
                .OrderByDescending(x => x.NumOccurences)
                // .Take(10)
                .Where(x => x.NumOccurences > 0)
                .Select(x => x.Obj)
                .ToList();
        }
    }
}
