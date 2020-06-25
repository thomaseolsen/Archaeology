using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstEarthInclusionsOrganic
    {
        public LstEarthInclusionsOrganic()
        {
            LocusDescriptionEarthInclusionsOrganic = new HashSet<LocusDescriptionEarthInclusionsOrganic>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionEarthInclusionsOrganic> LocusDescriptionEarthInclusionsOrganic { get; set; }
    }
}
