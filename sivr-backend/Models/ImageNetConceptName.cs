using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Models
{
    public class ImageNetConceptName
    {
        public int ImageNetConceptNameId { get; set; }
        public short ImageNetConceptId { get; set; }
        public ImageNetConcept ImageNetConcept { get; set; }
        public string Name { get; set; }
    }
}
