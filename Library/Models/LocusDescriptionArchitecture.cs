using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LocusDescriptionArchitecture
    {
        public LocusDescriptionArchitecture()
        {
            LocusDescriptionArchitectureDressing = new HashSet<LocusDescriptionArchitectureDressing>();
            LocusDescriptionArchitectureFacing = new HashSet<LocusDescriptionArchitectureFacing>();
            LocusDescriptionArchitectureMasonry = new HashSet<LocusDescriptionArchitectureMasonry>();
            LocusDescriptionArchitectureMaterial = new HashSet<LocusDescriptionArchitectureMaterial>();
            LocusDescriptionArchitectureMortar = new HashSet<LocusDescriptionArchitectureMortar>();
        }

        public Guid Id { get; set; }
        public Guid LocusId { get; set; }
        public decimal ToolingWidth { get; set; }
        public decimal ToolingLength { get; set; }
        public decimal ToolingDepth { get; set; }
        public bool ToolingPhoto { get; set; }
        public byte ArchitecturalConstructionStyleId { get; set; }
        public byte ArchitecturalConstructionSupportId { get; set; }
        public string ArchitecturalRemarks { get; set; }
        public string ArthitecturalTendencies { get; set; }
        public byte CoursesMinimum { get; set; }
        public byte CoursesMaximum { get; set; }
        public bool CoursesRandom { get; set; }
        public byte RowsMinimum { get; set; }
        public byte RowsMaximum { get; set; }
        public decimal LengthMinimum { get; set; }
        public decimal LengthMaximum { get; set; }
        public decimal WidthMinimum { get; set; }
        public decimal WidthMaximum { get; set; }
        public decimal HeightMinimum { get; set; }
        public decimal HeightMaximum { get; set; }
        public short Orientation { get; set; }
        public short Dip { get; set; }
        public byte ArchitecturalPreservationId { get; set; }
        public short LeanDirection { get; set; }
        public short LeanDegree { get; set; }
        public string Remarks { get; set; }

        public virtual LstArchitecturalConstructionStyle ArchitecturalConstructionStyle { get; set; }
        public virtual LstArchitecturalConstructionSupport ArchitecturalConstructionSupport { get; set; }
        public virtual LstArchitecturalPreservation ArchitecturalPreservation { get; set; }
        public virtual Locus Locus { get; set; }
        public virtual ICollection<LocusDescriptionArchitectureDressing> LocusDescriptionArchitectureDressing { get; set; }
        public virtual ICollection<LocusDescriptionArchitectureFacing> LocusDescriptionArchitectureFacing { get; set; }
        public virtual ICollection<LocusDescriptionArchitectureMasonry> LocusDescriptionArchitectureMasonry { get; set; }
        public virtual ICollection<LocusDescriptionArchitectureMaterial> LocusDescriptionArchitectureMaterial { get; set; }
        public virtual ICollection<LocusDescriptionArchitectureMortar> LocusDescriptionArchitectureMortar { get; set; }
    }
}
