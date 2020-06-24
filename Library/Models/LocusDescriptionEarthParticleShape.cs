using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LocusDescriptionEarthParticleShape
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionEarthId { get; set; }
        public byte EarthParticleShapeId { get; set; }
        public byte Percentage { get; set; }
        public string Remarks { get; set; }

        public virtual LstEarthParticleShape EarthParticleShape { get; set; }
        public virtual LocusDescriptionEarth LocusDescriptionEarth { get; set; }
    }
}
