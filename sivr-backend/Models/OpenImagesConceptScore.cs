﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sivr_backend.Models
{
    public class OpenImagesConceptScore
    {
        public short OpenImagesConceptId { get; set; }
        public double Score { get; set; }
        public short V3CId { get; set; }
        public short KeyframeNumber { get; set; }
        public Keyframe Keyframe { get; set; }
        public OpenImagesConcept OpenImagesConcept { get; set; }
    }
}
