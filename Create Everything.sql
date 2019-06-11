USE master
GO

DROP DATABASE IF EXISTS [Archaeology];
CREATE DATABASE [Archaeology];

USE [Archaeology]
GO

/*
* 
* Create all of the pick list tables first.
* These tables are used as FK constraints throughout the database.
* 
*/

CREATE TABLE dbo.[LstArchitecturalConstructionStyle] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstArchitecturalConstructionSupport] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstArchitecturalDressing] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstArchitecturalFacing] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstArchitecturalMasonry] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstArchitecturalMaterial] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstArchitecturalMortar] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstArchitecturalPreservation] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstDressingType] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthConsistenceCompactness] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthConsistenceHardness] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthConsistenceStructure] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthConsistenceWetness] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthInclusions] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthInclusionsArtifact] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthInclusionsEarth] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthInclusionsOrganic] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthInclusionsStone] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthParticleShape] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthSurfaceMaterial] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstEarthTexture] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstFrequency] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstInstallationMaterial] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstInstallationPlan] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstInstallationPlanQualifier] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstInstallationType] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstLocusSeparationClarity] (
  [ID]          TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstMunsellNumber] (
  [ID]          SMALLINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Hue]         NVARCHAR(10)  NOT NULL  DEFAULT (''),
  [Value]       NVARCHAR(10)  NOT NULL  DEFAULT (''),
  [Chroma]      NVARCHAR(10)  NOT NULL  DEFAULT (''),
  [Description] NVARCHAR(50)  NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LstStratigraphicRelationship] (
  [ID]            TINYINT       NOT NULL  IDENTITY(1,1) PRIMARY KEY CLUSTERED,
  [Description]   NVARCHAR(25)  NOT NULL  DEFAULT (''),
  [Architectural] BIT           NOT NULL  DEFAULT ((0)),
  [Earth]         BIT           NOT NULL  DEFAULT ((0)),
  [Installation]  BIT           NOT NULL  DEFAULT ((0))
)

/*
* 
* Create the rest of the database.
* These tables are created in order of their FK contraint requirements.
* 
*/

CREATE TABLE dbo.[Site] (
  [ID]              UNIQUEIDENTIFIER  NOT NULL  DEFAULT (NEWID()) PRIMARY KEY CLUSTERED,
  [ShortName]       NVARCHAR(50)      NOT NULL  DEFAULT (''),
  [FullName]        NVARCHAR(250)     NOT NULL  DEFAULT (''),
  [PublicationName] NVARCHAR(500)     NOT NULL  DEFAULT ('')
);

CREATE TABLE dbo.[Area] (
  [ID]        UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [Name]      NVARCHAR(50)      NOT NULL  DEFAULT (''),
  [Objective] NVARCHAR(1000)    NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[Team] (
  [ID]    UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [Name]  NVARCHAR(100)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[AscAreaTeam] (
  [AreaID]  UNIQUEIDENTIFIER  NOT NULL  FOREIGN KEY ([AreaID]) REFERENCES [Area]([ID]),
  [TeamID]  UNIQUEIDENTIFIER  NOT NULL  FOREIGN KEY ([TeamID]) REFERENCES [Team]([ID])
)

CREATE TABLE dbo.[Supervisor] (
  [ID]          UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [FirstName]   NVARCHAR(50)      NOT NULL  DEFAULT (''),
  [MiddleName]  NVARCHAR(50)      NOT NULL  DEFAULT (''),
  [LastName]    NVARCHAR(50)      NOT NULL  DEFAULT (''),
  [Initials]    NVARCHAR(3)       NOT NULL  DEFAULT (''),
  [Email]       NVARCHAR(100)     NOT NULL  DEFAULT (''),
  [TeamID]      UNIQUEIDENTIFIER  NOT NULL                  FOREIGN KEY ([TeamID]) REFERENCES [Team]([ID])
)

CREATE TABLE dbo.[Square] (
  [ID]            UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [Name]          NVARCHAR(10)      NOT NULL  DEFAULT (''),
  [SupervisorID]  UNIQUEIDENTIFIER  NOT NULL                  FOREIGN KEY ([SupervisorID]) REFERENCES [Supervisor]([ID]),
  [Coordinates]   GEOGRAPHY         NULL
)

CREATE TABLE dbo.[Locus] (
  [ID]                  UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [SquareID]            UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([SquareID]) REFERENCES [Square]([ID]),
  [Number]              INTEGER           NOT NULL,
  [DateOpened]          DATE              NULL      DEFAULT GETDATE(),
  [DateClosed]          DATE              NULL,
  [Designation]         NVARCHAR(250)     NOT NULL  DEFAULT (''),
  [Reason]              NVARCHAR(250)     NOT NULL  DEFAULT (''),
  [SeparationClarityID] TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([SeparationClarityID]) REFERENCES [LstLocusSeparationClarity]([ID]),
  [Function]            NVARCHAR(1000)    NOT NULL  DEFAULT (''),
  [Stratigraphy]        NVARCHAR(1000)    NOT NULL  DEFAULT (''),
  [CleanLocus]          BIT               NOT NULL  DEFAULT ((0)),
  [PeriodDate]          NVARCHAR(250)     NOT NULL  DEFAULT (''),
  [Phase]               NVARCHAR(250)     NOT NULL  DEFAULT (''),
  [Stratum]             NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionArchitecture] (
  [ID]      UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusID] UNIQUEIDENTIFIER  NOT NULL
    CONSTRAINT [UQ_LocusDescriptionArchitecture_LocusID] UNIQUE([LocusID])
    FOREIGN KEY ([LocusID]) REFERENCES [Locus]([ID])
)

CREATE TABLE dbo.[LocusDescriptionEarth] (
  [ID]                        UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusID]                   UNIQUEIDENTIFIER  NOT NULL
    CONSTRAINT [UQ_LocusDescriptionEarth_LocusID] UNIQUE([LocusID])
    FOREIGN KEY ([LocusID]) REFERENCES [Locus]([ID]),
  [MunselNumberID]            SMALLINT          NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([MunselNumberID]) REFERENCES [LstMunsellNumber]([ID]),
  [TextureID]                 TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([TextureID]) REFERENCES [LstEarthTexture]([ID]),
  [ConsistenceHardnessID]     TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ConsistenceHardnessID]) REFERENCES [LstEarthConsistenceHardness]([ID]),
  [ConsistenceCompactnessID]  TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ConsistenceCompactnessID]) REFERENCES [LstEarthConsistenceCompactness]([ID]),
  [ConsistenceWetnessID]      TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ConsistenceWetnessID]) REFERENCES [LstEarthConsistenceWetness]([ID]),
  [ConsistenceStructureID]    TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ConsistenceStructureID]) REFERENCES [LstEarthConsistenceStructure]([ID]),
  [LengthMinimum]             DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [LengthMaximum]             DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [WidthMinimum]              DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [WidthMaximum]              DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [DepthMinimum]              DECIMAL(5,3)      NOT NULL  DEFAULT ((0.000)),
  [DepthMaximum]              DECIMAL(5,3)      NOT NULL  DEFAULT ((0.000)),
  [DownslopeDirection]        SMALLINT          NOT NULL  DEFAULT ((0)),
  [DegreeOfSlope]             SMALLINT          NOT NULL  DEFAULT ((0)),
  [SurfaceMaterialID]         TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([SurfaceMaterialID]) REFERENCES [LstEarthSurfaceMaterial]([ID]),
  [AverageSiftRatio]          TINYINT           NOT NULL  DEFAULT ((1)),
  [Remarks]                   NVARCHAR(1000)    NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionEarthParticleShape] (
  [ID]                      UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionEarthID] UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionEarthID]) REFERENCES [LocusDescriptionEarth]([ID]),
  [EarthParticleShapeID]    TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionEarthParticleShape_LocusDescriptionEarthID_EarthParticleShapeID]
      UNIQUE([LocusDescriptionEarthID], [EarthParticleShapeID])
    FOREIGN KEY ([EarthParticleShapeID]) REFERENCES [LstEarthParticleShape]([ID]),
  [Percentage]              TINYINT           NOT NULL  DEFAULT ((0)),
  [Remarks]                 NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionEarthInclusionsStone] (
  [ID]                      UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionEarthID] UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionEarthID]) REFERENCES [LocusDescriptionEarth]([ID]),
  [EarthInclusionsStoneID]  TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionEarthInclusionsStone_LocusDescriptionEarthID_EarthInclusionsStoneID]
      UNIQUE([LocusDescriptionEarthID], [EarthInclusionsStoneID])
    FOREIGN KEY ([EarthInclusionsStoneID]) REFERENCES [LstEarthInclusionsStone]([ID]),
  [FrequencyID]             TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([FrequencyID]) REFERENCES [LstFrequency]([ID]),
  [Remarks]                 NVARCHAR(250)     NOT NULL DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionEarthInclusionsEarth] (
  [ID]                      UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionEarthID] UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionEarthID]) REFERENCES [LocusDescriptionEarth]([ID]),
  [EarthInclusionsEarthID]  TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionEarthInclusionsEarth_LocusDescriptionEarthID_EarthInclusionsEarthID]
      UNIQUE([LocusDescriptionEarthID], [EarthInclusionsEarthID])
    FOREIGN KEY ([EarthInclusionsEarthID]) REFERENCES [LstEarthInclusionsEarth]([ID]),
  [FrequencyID]             TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([FrequencyID]) REFERENCES [LstFrequency]([ID]),
  [Remarks]                 NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionEarthInclusionsArtifact] (
  [ID]                        UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionEarthID]   UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionEarthID]) REFERENCES [LocusDescriptionEarth]([ID]),
  [EarthInclusionsArtifactID] TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionEarthInclusionsArtifact_LocusDescriptionEarthID_EarthInclusionsArtifactID]
      UNIQUE([LocusDescriptionEarthID], [EarthInclusionsArtifactID])
    FOREIGN KEY ([EarthInclusionsArtifactID]) REFERENCES [LstEarthInclusionsArtifact]([ID]),
  [FrequencyID]               TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([FrequencyID]) REFERENCES [LstFrequency]([ID]),
  [Remarks]                   NVARCHAR(250)     NOT NULL DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionEarthInclusionsOrganic] (
  [ID]                        UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionEarthID]   UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionEarthID]) REFERENCES [LocusDescriptionEarth]([ID]),
  [EarthInclusionsOrganicID]  TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionEarthInclusionsOrganic_LocusDescriptionEarthID_EarthInclusionsOrganicID]
      UNIQUE([LocusDescriptionEarthID], [EarthInclusionsOrganicID])
    FOREIGN KEY ([EarthInclusionsOrganicID]) REFERENCES [LstEarthInclusionsOrganic]([ID]),
  [FrequencyID]               TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([FrequencyID]) REFERENCES [LstFrequency]([ID]),
  [Remarks]                   NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionInstallation] (
  [ID]      UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusID] UNIQUEIDENTIFIER  NOT NULL
    CONSTRAINT [UQ_LocusDescriptionInstallation_LocusID] UNIQUE([LocusID])
    FOREIGN KEY ([LocusID]) REFERENCES [Locus]([ID])
)

CREATE TABLE dbo.[GeospatialData] (
  [ID]        UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [Number]    INTEGER           NOT NULL
    CONSTRAINT [UQ_GeospatialPoints_Number] UNIQUE([Number]),
  [GPS]       GEOGRAPHY         NULL,
  [Easting]   DECIMAL(20,10)    NULL,
  [Northing]  DECIMAL(20,10)    NULL
)

CREATE TABLE dbo.[LocusGeospatialDefinition] (
  [GeospatialDataID]  UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED
    FOREIGN KEY ([GeospatialDataID]) REFERENCES [GeospatialData]([ID]),
  [Top]               BIT               NOT NULL  DEFAULT ((0)),
  [Bottom]            BIT               NOT NULL  DEFAULT ((0)),
  [Edge]              BIT               NOT NULL  DEFAULT ((0)),
  [Reference]         BIT               NOT NULL  DEFAULT ((0))
)

CREATE TABLE dbo.[AscLocusStratigraphy] (
  [ID]                          UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [CurrentLocusID]              UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([CurrentLocusID]) REFERENCES [Locus]([ID]),
  [StratigraphicRelationshipID] TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([StratigraphicRelationshipID]) REFERENCES [LstStratigraphicRelationship]([ID]),
  [RelatedLocusID]              UNIQUEIDENTIFIER  NOT NULL
    CONSTRAINT [UQ_AscLocusStratigraphy_CurrentLocusID_RelatedLocusID]
      UNIQUE ([CurrentLocusID], [RelatedLocusID])
    FOREIGN KEY ([RelatedLocusID]) REFERENCES [Locus]([ID]),
  [Remarks]                     NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[PotteryBucket] (
  [ID]                UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusID]           UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusID]) REFERENCES [Locus]([ID]),
  [Number]            INTEGER           NOT NULL  DEFAULT ((0)),
  [DateFilled]        DATE              NOT NULL  DEFAULT GETDATE(),
  [GeospatialDataID]  UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([GeospatialDataID]) REFERENCES [GeospatialData]([ID]),
  [CountTotal]        INTEGER           NOT NULL  DEFAULT ((0)),
  [CountRims]         INTEGER           NOT NULL  DEFAULT ((0)),
  [CountHandles]      INTEGER           NOT NULL  DEFAULT ((0)),
  [CountBases]        INTEGER           NOT NULL  DEFAULT ((0)),
  [BoneBag]           BIT               NOT NULL  DEFAULT ((0)),
  [Remarks]           NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[Object] (
  [ID]                UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusID]           UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusID]) REFERENCES [Locus]([ID]),
  [Number]            INTEGER           NOT NULL  DEFAULT ((0)),
  [DateCollected]     DATE              NOT NULL  DEFAULT GETDATE(),
  [GeospatialDataID]  UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([GeospatialDataID]) REFERENCES [GeospatialData]([ID]),
  [CountTotal]        INTEGER           NOT NULL  DEFAULT ((1)),
  [LeftInField]       BIT               NOT NULL  DEFAULT ((0)),
  [Remarks]           NVARCHAR(250)     NOT NULL  DEFAULT ('')
)