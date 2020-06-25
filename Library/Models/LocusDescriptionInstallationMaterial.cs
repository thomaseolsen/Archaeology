using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionInstallationMaterial
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionInstallationId { get; set; }
        public byte ArchitecturalMaterialId { get; set; }
        public byte ArchitecturalMaterialQualifierId { get; set; }
        public byte Percentage { get; set; }
        public string Remarks { get; set; }

        public virtual LstArchitecturalMaterial ArchitecturalMaterial { get; set; }
        public virtual LstArchitecturalMaterialQualifier ArchitecturalMaterialQualifier { get; set; }
        public virtual LocusDescriptionInstallation LocusDescriptionInstallation { get; set; }
    }
}
