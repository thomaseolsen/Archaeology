using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstEarthInclusionsArtifact
    {
        public LstEarthInclusionsArtifact()
        {
            LocusDescriptionEarthInclusionsArtifact = new HashSet<LocusDescriptionEarthInclusionsArtifact>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionEarthInclusionsArtifact> LocusDescriptionEarthInclusionsArtifact { get; set; }
    }
}
