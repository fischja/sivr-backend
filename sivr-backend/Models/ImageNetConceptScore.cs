﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Models
{
    public class ImageNetConceptScore
    {
        public short ImageNetConceptId { get; set; }
        public double Score { get; set; }
        public short V3CId { get; set; }
        public short KeyframeNumber { get; set; }
        public Keyframe Keyframe { get; set; }
        public ImageNetConcept ImageNetConcept { get; set; }
    }
}
