using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstEarthInclusionsEarth
    {
        public LstEarthInclusionsEarth()
        {
            LocusDescriptionEarthInclusionsEarth = new HashSet<LocusDescriptionEarthInclusionsEarth>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionEarthInclusionsEarth> LocusDescriptionEarthInclusionsEarth { get; set; }
    }
}
