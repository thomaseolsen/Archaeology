using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionArchitectureMortar
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionArchitectureId { get; set; }
        public byte ArchitecturalMortarId { get; set; }
        public byte Percentage { get; set; }
        public byte AverageThickness { get; set; }
        public string Remarks { get; set; }

        public virtual LstArchitecturalMortar ArchitecturalMortar { get; set; }
        public virtual LocusDescriptionArchitecture LocusDescriptionArchitecture { get; set; }
    }
}
