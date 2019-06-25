using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LstArchitecturalMaterialQualifier
    {
        public LstArchitecturalMaterialQualifier()
        {
            LocusDescriptionArchitectureMaterial = new HashSet<LocusDescriptionArchitectureMaterial>();
            LocusDescriptionInstallationMaterial = new HashSet<LocusDescriptionInstallationMaterial>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionArchitectureMaterial> LocusDescriptionArchitectureMaterial { get; set; }
        public virtual ICollection<LocusDescriptionInstallationMaterial> LocusDescriptionInstallationMaterial { get; set; }
    }
}
