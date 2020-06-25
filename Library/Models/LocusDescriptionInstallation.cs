using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionInstallation
    {
        public LocusDescriptionInstallation()
        {
            LocusDescriptionInstallationDressing = new HashSet<LocusDescriptionInstallationDressing>();
            LocusDescriptionInstallationFacing = new HashSet<LocusDescriptionInstallationFacing>();
            LocusDescriptionInstallationMasonry = new HashSet<LocusDescriptionInstallationMasonry>();
            LocusDescriptionInstallationMaterial = new HashSet<LocusDescriptionInstallationMaterial>();
            LocusDescriptionInstallationMortar = new HashSet<LocusDescriptionInstallationMortar>();
        }

        public Guid Id { get; set; }
        public Guid LocusId { get; set; }
        public byte InstallationTypeId { get; set; }
        public byte InstallationTypeCertaintyId { get; set; }
        public byte InstallationPlanId { get; set; }
        public byte InstallationPlanQualifierId { get; set; }
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
        public string Remarks { get; set; }

        public virtual LstArchitecturalConstructionStyle ArchitecturalConstructionStyle { get; set; }
        public virtual LstArchitecturalConstructionSupport ArchitecturalConstructionSupport { get; set; }
        public virtual LstInstallationPlan InstallationPlan { get; set; }
        public virtual LstInstallationPlanQualifier InstallationPlanQualifier { get; set; }
        public virtual LstInstallationType InstallationType { get; set; }
        public virtual LstInstallationTypeCertainty InstallationTypeCertainty { get; set; }
        public virtual Locus Locus { get; set; }
        public virtual ICollection<LocusDescriptionInstallationDressing> LocusDescriptionInstallationDressing { get; set; }
        public virtual ICollection<LocusDescriptionInstallationFacing> LocusDescriptionInstallationFacing { get; set; }
        public virtual ICollection<LocusDescriptionInstallationMasonry> LocusDescriptionInstallationMasonry { get; set; }
        public virtual ICollection<LocusDescriptionInstallationMaterial> LocusDescriptionInstallationMaterial { get; set; }
        public virtual ICollection<LocusDescriptionInstallationMortar> LocusDescriptionInstallationMortar { get; set; }
    }
}
