using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionEarthInclusionsOrganic
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionEarthId { get; set; }
        public byte EarthInclusionsOrganicId { get; set; }
        public string Remarks { get; set; }

        public virtual LstEarthInclusionsOrganic EarthInclusionsOrganic { get; set; }
        public virtual LocusDescriptionEarth LocusDescriptionEarth { get; set; }
    }
}
