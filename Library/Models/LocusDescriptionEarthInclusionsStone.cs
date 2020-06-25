using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionEarthInclusionsStone
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionEarthId { get; set; }
        public byte EarthInclusionsStoneId { get; set; }
        public string Remarks { get; set; }

        public virtual LstEarthInclusionsStone EarthInclusionsStone { get; set; }
        public virtual LocusDescriptionEarth LocusDescriptionEarth { get; set; }
    }
}
