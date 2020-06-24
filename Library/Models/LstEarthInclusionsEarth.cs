using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
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
