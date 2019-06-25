using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LocusDescriptionEarthInclusionsArtifact
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionEarthId { get; set; }
        public byte EarthInclusionsArtifactId { get; set; }
        public string Remarks { get; set; }

        public virtual LstEarthInclusionsArtifact EarthInclusionsArtifact { get; set; }
        public virtual LocusDescriptionEarth LocusDescriptionEarth { get; set; }
    }
}
