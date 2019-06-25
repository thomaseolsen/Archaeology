using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LocusDescriptionArchitectureMaterial
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionArchitectureId { get; set; }
        public byte ArchitecturalMaterialId { get; set; }
        public byte ArchitecturalMaterialQualifierId { get; set; }
        public byte Percentage { get; set; }
        public string Remarks { get; set; }

        public virtual LstArchitecturalMaterial ArchitecturalMaterial { get; set; }
        public virtual LstArchitecturalMaterialQualifier ArchitecturalMaterialQualifier { get; set; }
        public virtual LocusDescriptionArchitecture LocusDescriptionArchitecture { get; set; }
    }
}
