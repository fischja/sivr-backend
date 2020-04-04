using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Models
{
    public class MetaData
    {
        public short V3CId { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public short Duration { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Description { get; set; }
        public string Licence { get; set; }
        public string Extractor { get; set; }
        public string ExtractorKey { get; set; }

        public int SourceOrigId { get; set; }
        public string SourceOrigFilename { get; set; }
        public string DisplayId { get; set; }
        public string WebpageUrl { get; set; }
        public string WebpageUrlBasename { get; set; }
        public string Thumbnail { get; set; }
        public string Format { get; set; }
        public string FormatId { get; set; }
        public DateTime SourceTimestamp { get; set; }
        public string Resolution { get; set; }
        public string StretchedRatio { get; set; }
        public string Fps { get; set; }
        public string Abr { get; set; }
        public string Vbr { get; set; }
        public string Ext { get; set; }
        public string ACodec { get; set; }
        public string VCodec { get; set; }
        public string Channel { get; set; }
        public string Uploader { get; set; }
        public string UploaderId { get; set; }
        public string UploaderUrl { get; set; }
        public DateTime UploadDate { get; set; }
        public int ViewCount { get; set; }
        public int LikeCount { get; set; }
        public int CommentCount { get; set; }
        public string Playlist { get; set; }
        public short PlaylistIndex { get; set; }
    }
}
