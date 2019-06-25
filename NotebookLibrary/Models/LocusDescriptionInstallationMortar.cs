using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LocusDescriptionInstallationMortar
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionInstallationId { get; set; }
        public byte ArchitecturalMortarId { get; set; }
        public byte Percentage { get; set; }
        public string Remarks { get; set; }

        public virtual LstArchitecturalMortar ArchitecturalMortar { get; set; }
        public virtual LocusDescriptionInstallation LocusDescriptionInstallation { get; set; }
    }
}
