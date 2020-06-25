using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionInstallationFacing
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionInstallationId { get; set; }
        public byte ArchitecturalFacingId { get; set; }
        public byte Percentage { get; set; }
        public string Remarks { get; set; }

        public virtual LstArchitecturalFacing ArchitecturalFacing { get; set; }
        public virtual LocusDescriptionInstallation LocusDescriptionInstallation { get; set; }
    }
}
