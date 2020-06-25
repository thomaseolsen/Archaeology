using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionEarthInclusionsEarth
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionEarthId { get; set; }
        public byte EarthInclusionsEarthId { get; set; }
        public string Remarks { get; set; }

        public virtual LstEarthInclusionsEarth EarthInclusionsEarth { get; set; }
        public virtual LocusDescriptionEarth LocusDescriptionEarth { get; set; }
    }
}
