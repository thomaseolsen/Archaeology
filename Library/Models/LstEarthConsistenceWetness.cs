using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstEarthConsistenceWetness
    {
        public LstEarthConsistenceWetness()
        {
            LocusDescriptionEarth = new HashSet<LocusDescriptionEarth>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionEarth> LocusDescriptionEarth { get; set; }
    }
}
