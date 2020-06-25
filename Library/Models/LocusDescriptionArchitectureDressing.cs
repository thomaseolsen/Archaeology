using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionArchitectureDressing
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionArchitectureId { get; set; }
        public byte ArchitecturalDressingId { get; set; }
        public byte Percentage { get; set; }
        public string Remarks { get; set; }

        public virtual LstArchitecturalDressing ArchitecturalDressing { get; set; }
        public virtual LocusDescriptionArchitecture LocusDescriptionArchitecture { get; set; }
    }
}
