using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstEarthParticleShape
    {
        public LstEarthParticleShape()
        {
            LocusDescriptionEarthParticleShape = new HashSet<LocusDescriptionEarthParticleShape>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionEarthParticleShape> LocusDescriptionEarthParticleShape { get; set; }
    }
}
