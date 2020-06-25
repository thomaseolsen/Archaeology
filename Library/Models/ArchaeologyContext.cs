using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Library.Models
{
    public partial class ArchaeologyContext : DbContext
    {
        public ArchaeologyContext()
        {
        }

        public ArchaeologyContext(DbContextOptions<ArchaeologyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AscAreaTeam> AscAreaTeam { get; set; }
        public virtual DbSet<AscLocusStratigraphy> AscLocusStratigraphy { get; set; }
        public virtual DbSet<GeospatialData> GeospatialData { get; set; }
        public virtual DbSet<Locus> Locus { get; set; }
        public virtual DbSet<LocusDescriptionArchitecture> LocusDescriptionArchitecture { get; set; }
        public virtual DbSet<LocusDescriptionArchitectureDressing> LocusDescriptionArchitectureDressing { get; set; }
        public virtual DbSet<LocusDescriptionArchitectureFacing> LocusDescriptionArchitectureFacing { get; set; }
        public virtual DbSet<LocusDescriptionArchitectureMasonry> LocusDescriptionArchitectureMasonry { get; set; }
        public virtual DbSet<LocusDescriptionArchitectureMaterial> LocusDescriptionArchitectureMaterial { get; set; }
        public virtual DbSet<LocusDescriptionArchitectureMortar> LocusDescriptionArchitectureMortar { get; set; }
        public virtual DbSet<LocusDescriptionEarth> LocusDescriptionEarth { get; set; }
        public virtual DbSet<LocusDescriptionEarthInclusionsArtifact> LocusDescriptionEarthInclusionsArtifact { get; set; }
        public virtual DbSet<LocusDescriptionEarthInclusionsEarth> LocusDescriptionEarthInclusionsEarth { get; set; }
        public virtual DbSet<LocusDescriptionEarthInclusionsOrganic> LocusDescriptionEarthInclusionsOrganic { get; set; }
        public virtual DbSet<LocusDescriptionEarthInclusionsStone> LocusDescriptionEarthInclusionsStone { get; set; }
        public virtual DbSet<LocusDescriptionEarthParticleShape> LocusDescriptionEarthParticleShape { get; set; }
        public virtual DbSet<LocusDescriptionInstallation> LocusDescriptionInstallation { get; set; }
        public virtual DbSet<LocusDescriptionInstallationDressing> LocusDescriptionInstallationDressing { get; set; }
        public virtual DbSet<LocusDescriptionInstallationFacing> LocusDescriptionInstallationFacing { get; set; }
        public virtual DbSet<LocusDescriptionInstallationMasonry> LocusDescriptionInstallationMasonry { get; set; }
        public virtual DbSet<LocusDescriptionInstallationMaterial> LocusDescriptionInstallationMaterial { get; set; }
        public virtual DbSet<LocusDescriptionInstallationMortar> LocusDescriptionInstallationMortar { get; set; }
        public virtual DbSet<LocusGeospatialDefinition> LocusGeospatialDefinition { get; set; }
        public virtual DbSet<LstArchitecturalConstructionStyle> LstArchitecturalConstructionStyle { get; set; }
        public virtual DbSet<LstArchitecturalConstructionSupport> LstArchitecturalConstructionSupport { get; set; }
        public virtual DbSet<LstArchitecturalDressing> LstArchitecturalDressing { get; set; }
        public virtual DbSet<LstArchitecturalFacing> LstArchitecturalFacing { get; set; }
        public virtual DbSet<LstArchitecturalMasonry> LstArchitecturalMasonry { get; set; }
        public virtual DbSet<LstArchitecturalMasonryStones> LstArchitecturalMasonryStones { get; set; }
        public virtual DbSet<LstArchitecturalMaterial> LstArchitecturalMaterial { get; set; }
        public virtual DbSet<LstArchitecturalMaterialQualifier> LstArchitecturalMaterialQualifier { get; set; }
        public virtual DbSet<LstArchitecturalMortar> LstArchitecturalMortar { get; set; }
        public virtual DbSet<LstArchitecturalPreservation> LstArchitecturalPreservation { get; set; }
        public virtual DbSet<LstEarthConsistenceCompactness> LstEarthConsistenceCompactness { get; set; }
        public virtual DbSet<LstEarthConsistenceHardness> LstEarthConsistenceHardness { get; set; }
        public virtual DbSet<LstEarthConsistenceStructure> LstEarthConsistenceStructure { get; set; }
        public virtual DbSet<LstEarthConsistenceWetness> LstEarthConsistenceWetness { get; set; }
        public virtual DbSet<LstEarthInclusionsArtifact> LstEarthInclusionsArtifact { get; set; }
        public virtual DbSet<LstEarthInclusionsEarth> LstEarthInclusionsEarth { get; set; }
        public virtual DbSet<LstEarthInclusionsOrganic> LstEarthInclusionsOrganic { get; set; }
        public virtual DbSet<LstEarthInclusionsStone> LstEarthInclusionsStone { get; set; }
        public virtual DbSet<LstEarthParticleShape> LstEarthParticleShape { get; set; }
        public virtual DbSet<LstEarthSurfaceMaterial> LstEarthSurfaceMaterial { get; set; }
        public virtual DbSet<LstEarthTexture> LstEarthTexture { get; set; }
        public virtual DbSet<LstInstallationMaterial> LstInstallationMaterial { get; set; }
        public virtual DbSet<LstInstallationMaterialQualifier> LstInstallationMaterialQualifier { get; set; }
        public virtual DbSet<LstInstallationPlan> LstInstallationPlan { get; set; }
        public virtual DbSet<LstInstallationPlanQualifier> LstInstallationPlanQualifier { get; set; }
        public virtual DbSet<LstInstallationType> LstInstallationType { get; set; }
        public virtual DbSet<LstInstallationTypeCertainty> LstInstallationTypeCertainty { get; set; }
        public virtual DbSet<LstLocusSeparationClarity> LstLocusSeparationClarity { get; set; }
        public virtual DbSet<LstMunsellNumber> LstMunsellNumber { get; set; }
        public virtual DbSet<LstStratigraphicRelationship> LstStratigraphicRelationship { get; set; }
        public virtual DbSet<Object> Object { get; set; }
        public virtual DbSet<PotteryBucket> PotteryBucket { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<Square> Square { get; set; }
        public virtual DbSet<Supervisor> Supervisor { get; set; }
        public virtual DbSet<Team> Team { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Archaeology;User=sa;Password=Admin.P@ssw0rd;", x => x.UseNetTopologySuite());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Area__SiteID__06CD04F7");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Objective)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AscAreaTeam>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AscAreaTeam)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AscAreaTe__AreaI__0F624AF8");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.AscAreaTeam)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AscAreaTe__TeamI__10566F31");
            });

            modelBuilder.Entity<AscLocusStratigraphy>(entity =>
            {
                entity.HasIndex(e => new { e.CurrentLocusId, e.RelatedLocusId })
                    .HasName("UQ_AscLocusStratigraphy_CurrentLocusID_RelatedLocusID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CurrentLocusId).HasColumnName("CurrentLocusID");

                entity.Property(e => e.RelatedLocusId).HasColumnName("RelatedLocusID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StratigraphicRelationshipId).HasColumnName("StratigraphicRelationshipID");

                entity.HasOne(d => d.CurrentLocus)
                    .WithMany(p => p.AscLocusStratigraphyCurrentLocus)
                    .HasForeignKey(d => d.CurrentLocusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AscLocusS__Curre__2D7CBDC4");

                entity.HasOne(d => d.RelatedLocus)
                    .WithMany(p => p.AscLocusStratigraphyRelatedLocus)
                    .HasForeignKey(d => d.RelatedLocusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AscLocusS__Relat__30592A6F");

                entity.HasOne(d => d.StratigraphicRelationship)
                    .WithMany(p => p.AscLocusStratigraphy)
                    .HasForeignKey(d => d.StratigraphicRelationshipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AscLocusS__Strat__2F650636");
            });

            modelBuilder.Entity<GeospatialData>(entity =>
            {
                entity.HasIndex(e => e.Number)
                    .HasName("UQ_GeospatialPoints_Number")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Easting).HasColumnType("decimal(20, 10)");

                entity.Property(e => e.Gps).HasColumnName("GPS");

                entity.Property(e => e.Northing).HasColumnType("decimal(20, 10)");
            });

            modelBuilder.Entity<Locus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateClosed).HasColumnType("date");

                entity.Property(e => e.DateOpened)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Function)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PeriodDate)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phase)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeparationClarityId).HasColumnName("SeparationClarityID");

                entity.Property(e => e.SquareId).HasColumnName("SquareID");

                entity.Property(e => e.Stratigraphy)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Stratum)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.SeparationClarity)
                    .WithMany(p => p.Locus)
                    .HasForeignKey(d => d.SeparationClarityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Locus__Separatio__2645B050");

                entity.HasOne(d => d.Square)
                    .WithMany(p => p.Locus)
                    .HasForeignKey(d => d.SquareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Locus__SquareID__2180FB33");
            });

            modelBuilder.Entity<LocusDescriptionArchitecture>(entity =>
            {
                entity.HasIndex(e => e.LocusId)
                    .HasName("UQ_LocusDescriptionArchitecture_LocusID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalConstructionStyleId).HasColumnName("ArchitecturalConstructionStyleID");

                entity.Property(e => e.ArchitecturalConstructionSupportId).HasColumnName("ArchitecturalConstructionSupportID");

                entity.Property(e => e.ArchitecturalPreservationId).HasColumnName("ArchitecturalPreservationID");

                entity.Property(e => e.ArchitecturalRemarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ArthitecturalTendencies)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HeightMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.HeightMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.LengthMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.LengthMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.LocusId).HasColumnName("LocusID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ToolingDepth)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.ToolingLength)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.ToolingWidth)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.WidthMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.WidthMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.HasOne(d => d.ArchitecturalConstructionStyle)
                    .WithMany(p => p.LocusDescriptionArchitecture)
                    .HasForeignKey(d => d.ArchitecturalConstructionStyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__367C1819");

                entity.HasOne(d => d.ArchitecturalConstructionSupport)
                    .WithMany(p => p.LocusDescriptionArchitecture)
                    .HasForeignKey(d => d.ArchitecturalConstructionSupportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__3864608B");

                entity.HasOne(d => d.ArchitecturalPreservation)
                    .WithMany(p => p.LocusDescriptionArchitecture)
                    .HasForeignKey(d => d.ArchitecturalPreservationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__489AC854");

                entity.HasOne(d => d.Locus)
                    .WithOne(p => p.LocusDescriptionArchitecture)
                    .HasForeignKey<LocusDescriptionArchitecture>(d => d.LocusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__30C33EC3");
            });

            modelBuilder.Entity<LocusDescriptionArchitectureDressing>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionArchitectureId, e.ArchitecturalDressingId })
                    .HasName("UQ_LocusDescriptionArchitectureMaterial_LocusDescriptionArchitectureID_ArchitecturalDressingID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalDressingId).HasColumnName("ArchitecturalDressingID");

                entity.Property(e => e.LocusDescriptionArchitectureId).HasColumnName("LocusDescriptionArchitectureID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ArchitecturalDressing)
                    .WithMany(p => p.LocusDescriptionArchitectureDressing)
                    .HasForeignKey(d => d.ArchitecturalDressingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__6CD828CA");

                entity.HasOne(d => d.LocusDescriptionArchitecture)
                    .WithMany(p => p.LocusDescriptionArchitectureDressing)
                    .HasForeignKey(d => d.LocusDescriptionArchitectureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__6AEFE058");
            });

            modelBuilder.Entity<LocusDescriptionArchitectureFacing>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionArchitectureId, e.ArchitecturalFacingId })
                    .HasName("UQ_LocusDescriptionArchitectureMaterial_LocusDescriptionArchitectureID_ArchitecturalFacingID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalFacingId).HasColumnName("ArchitecturalFacingID");

                entity.Property(e => e.LocusDescriptionArchitectureId).HasColumnName("LocusDescriptionArchitectureID");

                entity.Property(e => e.MunselNumberId).HasColumnName("MunselNumberID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ArchitecturalFacing)
                    .WithMany(p => p.LocusDescriptionArchitectureFacing)
                    .HasForeignKey(d => d.ArchitecturalFacingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__7EF6D905");

                entity.HasOne(d => d.LocusDescriptionArchitecture)
                    .WithMany(p => p.LocusDescriptionArchitectureFacing)
                    .HasForeignKey(d => d.LocusDescriptionArchitectureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__7D0E9093");

                entity.HasOne(d => d.MunselNumber)
                    .WithMany(p => p.LocusDescriptionArchitectureFacing)
                    .HasForeignKey(d => d.MunselNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Munse__01D345B0");
            });

            modelBuilder.Entity<LocusDescriptionArchitectureMasonry>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionArchitectureId, e.ArchitecturalMasonryId, e.ArchitecturalMasonryStonesId })
                    .HasName("UQ_LocusDescriptionArchitectureMasonry_LocusDescriptionArchitectureID_ArchitecturalMasonryID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalMasonryId).HasColumnName("ArchitecturalMasonryID");

                entity.Property(e => e.ArchitecturalMasonryStonesId).HasColumnName("ArchitecturalMasonryStonesID");

                entity.Property(e => e.BrickHeightMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.BrickHeightMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.BrickLengthMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.BrickLengthMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.BrickWidthMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.BrickWidthMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.LocusDescriptionArchitectureId).HasColumnName("LocusDescriptionArchitectureID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ArchitecturalMasonry)
                    .WithMany(p => p.LocusDescriptionArchitectureMasonry)
                    .HasForeignKey(d => d.ArchitecturalMasonryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__5CA1C101");

                entity.HasOne(d => d.ArchitecturalMasonryStones)
                    .WithMany(p => p.LocusDescriptionArchitectureMasonry)
                    .HasForeignKey(d => d.ArchitecturalMasonryStonesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__5E8A0973");

                entity.HasOne(d => d.LocusDescriptionArchitecture)
                    .WithMany(p => p.LocusDescriptionArchitectureMasonry)
                    .HasForeignKey(d => d.LocusDescriptionArchitectureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__5AB9788F");
            });

            modelBuilder.Entity<LocusDescriptionArchitectureMaterial>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionArchitectureId, e.ArchitecturalMaterialId })
                    .HasName("UQ_LocusDescriptionArchitectureMaterial_LocusDescriptionArchitectureID_ArchitecturalMaterialID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalMaterialId).HasColumnName("ArchitecturalMaterialID");

                entity.Property(e => e.ArchitecturalMaterialQualifierId).HasColumnName("ArchitecturalMaterialQualifierID");

                entity.Property(e => e.LocusDescriptionArchitectureId).HasColumnName("LocusDescriptionArchitectureID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ArchitecturalMaterial)
                    .WithMany(p => p.LocusDescriptionArchitectureMaterial)
                    .HasForeignKey(d => d.ArchitecturalMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__5224328E");

                entity.HasOne(d => d.ArchitecturalMaterialQualifier)
                    .WithMany(p => p.LocusDescriptionArchitectureMaterial)
                    .HasForeignKey(d => d.ArchitecturalMaterialQualifierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__540C7B00");

                entity.HasOne(d => d.LocusDescriptionArchitecture)
                    .WithMany(p => p.LocusDescriptionArchitectureMaterial)
                    .HasForeignKey(d => d.LocusDescriptionArchitectureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__503BEA1C");
            });

            modelBuilder.Entity<LocusDescriptionArchitectureMortar>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionArchitectureId, e.ArchitecturalMortarId })
                    .HasName("UQ_LocusDescriptionArchitectureMaterial_LocusDescriptionArchitectureID_ArchitecturalMortarID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalMortarId).HasColumnName("ArchitecturalMortarID");

                entity.Property(e => e.LocusDescriptionArchitectureId).HasColumnName("LocusDescriptionArchitectureID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ArchitecturalMortar)
                    .WithMany(p => p.LocusDescriptionArchitectureMortar)
                    .HasForeignKey(d => d.ArchitecturalMortarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__756D6ECB");

                entity.HasOne(d => d.LocusDescriptionArchitecture)
                    .WithMany(p => p.LocusDescriptionArchitectureMortar)
                    .HasForeignKey(d => d.LocusDescriptionArchitectureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__73852659");
            });

            modelBuilder.Entity<LocusDescriptionEarth>(entity =>
            {
                entity.HasIndex(e => e.LocusId)
                    .HasName("UQ_LocusDescriptionEarth_LocusID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AverageSiftRatio).HasDefaultValueSql("((1))");

                entity.Property(e => e.ConsistenceCompactnessId).HasColumnName("ConsistenceCompactnessID");

                entity.Property(e => e.ConsistenceHardnessId).HasColumnName("ConsistenceHardnessID");

                entity.Property(e => e.ConsistenceStructureId).HasColumnName("ConsistenceStructureID");

                entity.Property(e => e.ConsistenceWetnessId).HasColumnName("ConsistenceWetnessID");

                entity.Property(e => e.DepthMaximum)
                    .HasColumnType("decimal(5, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.DepthMinimum)
                    .HasColumnType("decimal(5, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.LengthMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.LengthMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.LocusId).HasColumnName("LocusID");

                entity.Property(e => e.MunselNumberId).HasColumnName("MunselNumberID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SurfaceMaterialId).HasColumnName("SurfaceMaterialID");

                entity.Property(e => e.TextureId).HasColumnName("TextureID");

                entity.Property(e => e.WidthMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.WidthMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.HasOne(d => d.ConsistenceCompactness)
                    .WithMany(p => p.LocusDescriptionEarth)
                    .HasForeignKey(d => d.ConsistenceCompactnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Consi__0F2D40CE");

                entity.HasOne(d => d.ConsistenceHardness)
                    .WithMany(p => p.LocusDescriptionEarth)
                    .HasForeignKey(d => d.ConsistenceHardnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Consi__0D44F85C");

                entity.HasOne(d => d.ConsistenceStructure)
                    .WithMany(p => p.LocusDescriptionEarth)
                    .HasForeignKey(d => d.ConsistenceStructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Consi__12FDD1B2");

                entity.HasOne(d => d.ConsistenceWetness)
                    .WithMany(p => p.LocusDescriptionEarth)
                    .HasForeignKey(d => d.ConsistenceWetnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Consi__11158940");

                entity.HasOne(d => d.Locus)
                    .WithOne(p => p.LocusDescriptionEarth)
                    .HasForeignKey<LocusDescriptionEarth>(d => d.LocusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__078C1F06");

                entity.HasOne(d => d.MunselNumber)
                    .WithMany(p => p.LocusDescriptionEarth)
                    .HasForeignKey(d => d.MunselNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Munse__09746778");

                entity.HasOne(d => d.SurfaceMaterial)
                    .WithMany(p => p.LocusDescriptionEarth)
                    .HasForeignKey(d => d.SurfaceMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Surfa__1C873BEC");

                entity.HasOne(d => d.Texture)
                    .WithMany(p => p.LocusDescriptionEarth)
                    .HasForeignKey(d => d.TextureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Textu__0B5CAFEA");
            });

            modelBuilder.Entity<LocusDescriptionEarthInclusionsArtifact>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionEarthId, e.EarthInclusionsArtifactId })
                    .HasName("UQ_LocusDescriptionEarthInclusionsArtifact_LocusDescriptionEarthID_EarthInclusionsArtifactID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EarthInclusionsArtifactId).HasColumnName("EarthInclusionsArtifactID");

                entity.Property(e => e.LocusDescriptionEarthId).HasColumnName("LocusDescriptionEarthID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EarthInclusionsArtifact)
                    .WithMany(p => p.LocusDescriptionEarthInclusionsArtifact)
                    .HasForeignKey(d => d.EarthInclusionsArtifactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Earth__3CF40B7E");

                entity.HasOne(d => d.LocusDescriptionEarth)
                    .WithMany(p => p.LocusDescriptionEarthInclusionsArtifact)
                    .HasForeignKey(d => d.LocusDescriptionEarthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__3B0BC30C");
            });

            modelBuilder.Entity<LocusDescriptionEarthInclusionsEarth>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionEarthId, e.EarthInclusionsEarthId })
                    .HasName("UQ_LocusDescriptionEarthInclusionsEarth_LocusDescriptionEarthID_EarthInclusionsEarthID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EarthInclusionsEarthId).HasColumnName("EarthInclusionsEarthID");

                entity.Property(e => e.LocusDescriptionEarthId).HasColumnName("LocusDescriptionEarthID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EarthInclusionsEarth)
                    .WithMany(p => p.LocusDescriptionEarthInclusionsEarth)
                    .HasForeignKey(d => d.EarthInclusionsEarthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Earth__3552E9B6");

                entity.HasOne(d => d.LocusDescriptionEarth)
                    .WithMany(p => p.LocusDescriptionEarthInclusionsEarth)
                    .HasForeignKey(d => d.LocusDescriptionEarthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__336AA144");
            });

            modelBuilder.Entity<LocusDescriptionEarthInclusionsOrganic>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionEarthId, e.EarthInclusionsOrganicId })
                    .HasName("UQ_LocusDescriptionEarthInclusionsOrganic_LocusDescriptionEarthID_EarthInclusionsOrganicID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EarthInclusionsOrganicId).HasColumnName("EarthInclusionsOrganicID");

                entity.Property(e => e.LocusDescriptionEarthId).HasColumnName("LocusDescriptionEarthID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EarthInclusionsOrganic)
                    .WithMany(p => p.LocusDescriptionEarthInclusionsOrganic)
                    .HasForeignKey(d => d.EarthInclusionsOrganicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Earth__44952D46");

                entity.HasOne(d => d.LocusDescriptionEarth)
                    .WithMany(p => p.LocusDescriptionEarthInclusionsOrganic)
                    .HasForeignKey(d => d.LocusDescriptionEarthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__42ACE4D4");
            });

            modelBuilder.Entity<LocusDescriptionEarthInclusionsStone>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionEarthId, e.EarthInclusionsStoneId })
                    .HasName("UQ_LocusDescriptionEarthInclusionsStone_LocusDescriptionEarthID_EarthInclusionsStoneID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EarthInclusionsStoneId).HasColumnName("EarthInclusionsStoneID");

                entity.Property(e => e.LocusDescriptionEarthId).HasColumnName("LocusDescriptionEarthID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EarthInclusionsStone)
                    .WithMany(p => p.LocusDescriptionEarthInclusionsStone)
                    .HasForeignKey(d => d.EarthInclusionsStoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Earth__2DB1C7EE");

                entity.HasOne(d => d.LocusDescriptionEarth)
                    .WithMany(p => p.LocusDescriptionEarthInclusionsStone)
                    .HasForeignKey(d => d.LocusDescriptionEarthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__2BC97F7C");
            });

            modelBuilder.Entity<LocusDescriptionEarthParticleShape>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionEarthId, e.EarthParticleShapeId })
                    .HasName("UQ_LocusDescriptionEarthParticleShape_LocusDescriptionEarthID_EarthParticleShapeID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EarthParticleShapeId).HasColumnName("EarthParticleShapeID");

                entity.Property(e => e.LocusDescriptionEarthId).HasColumnName("LocusDescriptionEarthID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EarthParticleShape)
                    .WithMany(p => p.LocusDescriptionEarthParticleShape)
                    .HasForeignKey(d => d.EarthParticleShapeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Earth__251C81ED");

                entity.HasOne(d => d.LocusDescriptionEarth)
                    .WithMany(p => p.LocusDescriptionEarthParticleShape)
                    .HasForeignKey(d => d.LocusDescriptionEarthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__2334397B");
            });

            modelBuilder.Entity<LocusDescriptionInstallation>(entity =>
            {
                entity.HasIndex(e => e.LocusId)
                    .HasName("UQ_LocusDescriptionInstallation_LocusID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalConstructionStyleId).HasColumnName("ArchitecturalConstructionStyleID");

                entity.Property(e => e.ArchitecturalConstructionSupportId).HasColumnName("ArchitecturalConstructionSupportID");

                entity.Property(e => e.ArchitecturalRemarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ArthitecturalTendencies)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HeightMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.HeightMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.InstallationPlanId).HasColumnName("InstallationPlanID");

                entity.Property(e => e.InstallationPlanQualifierId).HasColumnName("InstallationPlanQualifierID");

                entity.Property(e => e.InstallationTypeCertaintyId).HasColumnName("InstallationTypeCertaintyID");

                entity.Property(e => e.InstallationTypeId).HasColumnName("InstallationTypeID");

                entity.Property(e => e.LengthMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.LengthMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.LocusId).HasColumnName("LocusID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ToolingDepth)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.ToolingLength)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.ToolingWidth)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.WidthMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.WidthMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.HasOne(d => d.ArchitecturalConstructionStyle)
                    .WithMany(p => p.LocusDescriptionInstallation)
                    .HasForeignKey(d => d.ArchitecturalConstructionStyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__57A801BA");

                entity.HasOne(d => d.ArchitecturalConstructionSupport)
                    .WithMany(p => p.LocusDescriptionInstallation)
                    .HasForeignKey(d => d.ArchitecturalConstructionSupportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__59904A2C");

                entity.HasOne(d => d.InstallationPlan)
                    .WithMany(p => p.LocusDescriptionInstallation)
                    .HasForeignKey(d => d.InstallationPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Insta__5006DFF2");

                entity.HasOne(d => d.InstallationPlanQualifier)
                    .WithMany(p => p.LocusDescriptionInstallation)
                    .HasForeignKey(d => d.InstallationPlanQualifierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Insta__51EF2864");

                entity.HasOne(d => d.InstallationTypeCertainty)
                    .WithMany(p => p.LocusDescriptionInstallation)
                    .HasForeignKey(d => d.InstallationTypeCertaintyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Insta__4E1E9780");

                entity.HasOne(d => d.InstallationType)
                    .WithMany(p => p.LocusDescriptionInstallation)
                    .HasForeignKey(d => d.InstallationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Insta__4C364F0E");

                entity.HasOne(d => d.Locus)
                    .WithOne(p => p.LocusDescriptionInstallation)
                    .HasForeignKey<LocusDescriptionInstallation>(d => d.LocusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__4A4E069C");
            });

            modelBuilder.Entity<LocusDescriptionInstallationDressing>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionInstallationId, e.ArchitecturalDressingId })
                    .HasName("UQ_LocusDescriptionInstallationMaterial_LocusDescriptionInstallationID_ArchitecturalDressingID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalDressingId).HasColumnName("ArchitecturalDressingID");

                entity.Property(e => e.LocusDescriptionInstallationId).HasColumnName("LocusDescriptionInstallationID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ArchitecturalDressing)
                    .WithMany(p => p.LocusDescriptionInstallationDressing)
                    .HasForeignKey(d => d.ArchitecturalDressingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__0A338187");

                entity.HasOne(d => d.LocusDescriptionInstallation)
                    .WithMany(p => p.LocusDescriptionInstallationDressing)
                    .HasForeignKey(d => d.LocusDescriptionInstallationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__084B3915");
            });

            modelBuilder.Entity<LocusDescriptionInstallationFacing>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionInstallationId, e.ArchitecturalFacingId })
                    .HasName("UQ_LocusDescriptionInstallationMaterial_LocusDescriptionInstallationID_ArchitecturalFacingID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalFacingId).HasColumnName("ArchitecturalFacingID");

                entity.Property(e => e.LocusDescriptionInstallationId).HasColumnName("LocusDescriptionInstallationID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ArchitecturalFacing)
                    .WithMany(p => p.LocusDescriptionInstallationFacing)
                    .HasForeignKey(d => d.ArchitecturalFacingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__1B5E0D89");

                entity.HasOne(d => d.LocusDescriptionInstallation)
                    .WithMany(p => p.LocusDescriptionInstallationFacing)
                    .HasForeignKey(d => d.LocusDescriptionInstallationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__1975C517");
            });

            modelBuilder.Entity<LocusDescriptionInstallationMasonry>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionInstallationId, e.ArchitecturalMasonryId, e.ArchitecturalMasonryStonesId })
                    .HasName("UQ_LocusDescriptionInstallationMasonry_LocusDescriptionInstallationID_ArchitecturalMasonryID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalMasonryId).HasColumnName("ArchitecturalMasonryID");

                entity.Property(e => e.ArchitecturalMasonryStonesId).HasColumnName("ArchitecturalMasonryStonesID");

                entity.Property(e => e.BrickHeightMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.BrickHeightMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.BrickLengthMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.BrickLengthMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.BrickWidthMaximum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.BrickWidthMinimum)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.LocusDescriptionInstallationId).HasColumnName("LocusDescriptionInstallationID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ArchitecturalMasonry)
                    .WithMany(p => p.LocusDescriptionInstallationMasonry)
                    .HasForeignKey(d => d.ArchitecturalMasonryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__79FD19BE");

                entity.HasOne(d => d.ArchitecturalMasonryStones)
                    .WithMany(p => p.LocusDescriptionInstallationMasonry)
                    .HasForeignKey(d => d.ArchitecturalMasonryStonesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__7BE56230");

                entity.HasOne(d => d.LocusDescriptionInstallation)
                    .WithMany(p => p.LocusDescriptionInstallationMasonry)
                    .HasForeignKey(d => d.LocusDescriptionInstallationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__7814D14C");
            });

            modelBuilder.Entity<LocusDescriptionInstallationMaterial>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionInstallationId, e.ArchitecturalMaterialId })
                    .HasName("UQ_LocusDescriptionInstallationMaterial_LocusDescriptionInstallationID_ArchitecturalMaterialID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalMaterialId).HasColumnName("ArchitecturalMaterialID");

                entity.Property(e => e.ArchitecturalMaterialQualifierId).HasColumnName("ArchitecturalMaterialQualifierID");

                entity.Property(e => e.LocusDescriptionInstallationId).HasColumnName("LocusDescriptionInstallationID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ArchitecturalMaterial)
                    .WithMany(p => p.LocusDescriptionInstallationMaterial)
                    .HasForeignKey(d => d.ArchitecturalMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__6F7F8B4B");

                entity.HasOne(d => d.ArchitecturalMaterialQualifier)
                    .WithMany(p => p.LocusDescriptionInstallationMaterial)
                    .HasForeignKey(d => d.ArchitecturalMaterialQualifierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__7167D3BD");

                entity.HasOne(d => d.LocusDescriptionInstallation)
                    .WithMany(p => p.LocusDescriptionInstallationMaterial)
                    .HasForeignKey(d => d.LocusDescriptionInstallationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__6D9742D9");
            });

            modelBuilder.Entity<LocusDescriptionInstallationMortar>(entity =>
            {
                entity.HasIndex(e => new { e.LocusDescriptionInstallationId, e.ArchitecturalMortarId })
                    .HasName("UQ_LocusDescriptionInstallationMaterial_LocusDescriptionInstallationID_ArchitecturalMortarID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ArchitecturalMortarId).HasColumnName("ArchitecturalMortarID");

                entity.Property(e => e.LocusDescriptionInstallationId).HasColumnName("LocusDescriptionInstallationID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ArchitecturalMortar)
                    .WithMany(p => p.LocusDescriptionInstallationMortar)
                    .HasForeignKey(d => d.ArchitecturalMortarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Archi__12C8C788");

                entity.HasOne(d => d.LocusDescriptionInstallation)
                    .WithMany(p => p.LocusDescriptionInstallationMortar)
                    .HasForeignKey(d => d.LocusDescriptionInstallationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusDesc__Locus__10E07F16");
            });

            modelBuilder.Entity<LocusGeospatialDefinition>(entity =>
            {
                entity.HasKey(e => e.GeospatialDataId)
                    .HasName("PK__LocusGeo__9840A1243156FBB2");

                entity.Property(e => e.GeospatialDataId)
                    .HasColumnName("GeospatialDataID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.GeospatialData)
                    .WithOne(p => p.LocusGeospatialDefinition)
                    .HasForeignKey<LocusGeospatialDefinition>(d => d.GeospatialDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocusGeos__Geosp__24E777C3");
            });

            modelBuilder.Entity<LstArchitecturalConstructionStyle>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstArchitecturalConstructionSupport>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstArchitecturalDressing>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstArchitecturalFacing>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstArchitecturalMasonry>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstArchitecturalMasonryStones>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstArchitecturalMaterial>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstArchitecturalMaterialQualifier>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstArchitecturalMortar>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstArchitecturalPreservation>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthConsistenceCompactness>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthConsistenceHardness>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthConsistenceStructure>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthConsistenceWetness>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthInclusionsArtifact>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthInclusionsEarth>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthInclusionsOrganic>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthInclusionsStone>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthParticleShape>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthSurfaceMaterial>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstEarthTexture>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstInstallationMaterial>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstInstallationMaterialQualifier>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstInstallationPlan>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstInstallationPlanQualifier>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstInstallationType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstInstallationTypeCertainty>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstLocusSeparationClarity>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstMunsellNumber>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Chroma)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hue)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LstStratigraphicRelationship>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Object>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CountTotal).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateCollected)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GeospatialDataId).HasColumnName("GeospatialDataID");

                entity.Property(e => e.LocusId).HasColumnName("LocusID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.GeospatialData)
                    .WithMany(p => p.Object)
                    .HasForeignKey(d => d.GeospatialDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Object__Geospati__4460231C");

                entity.HasOne(d => d.Locus)
                    .WithMany(p => p.Object)
                    .HasForeignKey(d => d.LocusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Object__LocusID__4183B671");
            });

            modelBuilder.Entity<PotteryBucket>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateFilled)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GeospatialDataId).HasColumnName("GeospatialDataID");

                entity.Property(e => e.LocusId).HasColumnName("LocusID");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.GeospatialData)
                    .WithMany(p => p.PotteryBucket)
                    .HasForeignKey(d => d.GeospatialDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PotteryBu__Geosp__37FA4C37");

                entity.HasOne(d => d.Locus)
                    .WithMany(p => p.PotteryBucket)
                    .HasForeignKey(d => d.LocusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PotteryBu__Locus__351DDF8C");
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PublicationName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Square>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Square)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Square__AreaID__1DB06A4F");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.HasOne(d => d.Supervisor)
                    .WithMany(p => p.Square)
                    .HasForeignKey(d => d.SupervisorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Square__Supervis__1DB06A4F");
            });

            modelBuilder.Entity<Supervisor>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Initials)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Supervisor)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Superviso__TeamI__18EBB532");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });
        }
    }
}
