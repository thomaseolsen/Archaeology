using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LstEarthConsistenceCompactness
    {
        public LstEarthConsistenceCompactness()
        {
            LocusDescriptionEarth = new HashSet<LocusDescriptionEarth>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionEarth> LocusDescriptionEarth { get; set; }
    }
}
