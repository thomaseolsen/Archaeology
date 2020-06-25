using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionArchitectureMasonry
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionArchitectureId { get; set; }
        public byte ArchitecturalMasonryId { get; set; }
        public byte ArchitecturalMasonryStonesId { get; set; }
        public decimal BrickLengthMinimum { get; set; }
        public decimal BrickLengthMaximum { get; set; }
        public decimal BrickWidthMinimum { get; set; }
        public decimal BrickWidthMaximum { get; set; }
        public decimal BrickHeightMinimum { get; set; }
        public decimal BrickHeightMaximum { get; set; }
        public byte Percentage { get; set; }
        public string Remarks { get; set; }

        public virtual LstArchitecturalMasonry ArchitecturalMasonry { get; set; }
        public virtual LstArchitecturalMasonryStones ArchitecturalMasonryStones { get; set; }
        public virtual LocusDescriptionArchitecture LocusDescriptionArchitecture { get; set; }
    }
}
