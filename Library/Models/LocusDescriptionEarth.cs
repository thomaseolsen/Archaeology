using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionEarth
    {
        public LocusDescriptionEarth()
        {
            LocusDescriptionEarthInclusionsArtifact = new HashSet<LocusDescriptionEarthInclusionsArtifact>();
            LocusDescriptionEarthInclusionsEarth = new HashSet<LocusDescriptionEarthInclusionsEarth>();
            LocusDescriptionEarthInclusionsOrganic = new HashSet<LocusDescriptionEarthInclusionsOrganic>();
            LocusDescriptionEarthInclusionsStone = new HashSet<LocusDescriptionEarthInclusionsStone>();
            LocusDescriptionEarthParticleShape = new HashSet<LocusDescriptionEarthParticleShape>();
        }

        public Guid Id { get; set; }
        public Guid LocusId { get; set; }
        public short MunselNumberId { get; set; }
        public byte TextureId { get; set; }
        public byte ConsistenceHardnessId { get; set; }
        public byte ConsistenceCompactnessId { get; set; }
        public byte ConsistenceWetnessId { get; set; }
        public byte ConsistenceStructureId { get; set; }
        public decimal LengthMinimum { get; set; }
        public decimal LengthMaximum { get; set; }
        public decimal WidthMinimum { get; set; }
        public decimal WidthMaximum { get; set; }
        public decimal DepthMinimum { get; set; }
        public decimal DepthMaximum { get; set; }
        public short DownslopeDirection { get; set; }
        public short DegreeOfSlope { get; set; }
        public byte SurfaceMaterialId { get; set; }
        public byte AverageSiftRatio { get; set; }
        public string Remarks { get; set; }

        public virtual LstEarthConsistenceCompactness ConsistenceCompactness { get; set; }
        public virtual LstEarthConsistenceHardness ConsistenceHardness { get; set; }
        public virtual LstEarthConsistenceStructure ConsistenceStructure { get; set; }
        public virtual LstEarthConsistenceWetness ConsistenceWetness { get; set; }
        public virtual Locus Locus { get; set; }
        public virtual LstMunsellNumber MunselNumber { get; set; }
        public virtual LstEarthSurfaceMaterial SurfaceMaterial { get; set; }
        public virtual LstEarthTexture Texture { get; set; }
        public virtual ICollection<LocusDescriptionEarthInclusionsArtifact> LocusDescriptionEarthInclusionsArtifact { get; set; }
        public virtual ICollection<LocusDescriptionEarthInclusionsEarth> LocusDescriptionEarthInclusionsEarth { get; set; }
        public virtual ICollection<LocusDescriptionEarthInclusionsOrganic> LocusDescriptionEarthInclusionsOrganic { get; set; }
        public virtual ICollection<LocusDescriptionEarthInclusionsStone> LocusDescriptionEarthInclusionsStone { get; set; }
        public virtual ICollection<LocusDescriptionEarthParticleShape> LocusDescriptionEarthParticleShape { get; set; }
    }
}
