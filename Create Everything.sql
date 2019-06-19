USE master
GO

PRINT('Dropping the database if it exists.')
DROP DATABASE IF EXISTS [Archaeology];
PRINT('Creating the database.')
CREATE DATABASE [Archaeology];

USE [Archaeology]
GO

/*
* 
* Create & fill all of the pick list tables first.
* These tables are used as FK constraints throughout the database.
* 
*/

PRINT('Creating LstArchitecturalConstructionStyle')
CREATE TABLE dbo.[LstArchitecturalConstructionStyle] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('INSERTING 10 values into LstArchitecturalConstructionStyle')
INSERT INTO dbo.[LstArchitecturalConstructionStyle]([Description])
VALUES (''),
       ('Boulder & Chink'),
       ('Ashlar Fit'),
       ('Header-stretcher'),
       ('Rubble-filled'),
       ('Rubble'),
       ('Stacked Bricks'),
       ('Tied-in Bricks'),
       ('Quoin & Pier'),
       ('Orthostat')

PRINT('Creating LstArchitecturalConstructionSupport')
CREATE TABLE dbo.[LstArchitecturalConstructionSupport] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 5 values into LstArchitecturalConstructionSupport')
INSERT INTO dbo.[LstArchitecturalConstructionSupport]([Description])
VALUES (''),
       ('Free-standing'),
       ('Buttressed'),
       ('Battered'),
       ('Foundation')

PRINT('Creating LstArchitecturalDressing')
CREATE TABLE dbo.[LstArchitecturalDressing] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 6 values into LstArchitecturalDressing')
INSERT INTO dbo.[LstArchitecturalDressing]([Description])
VALUES (''),
       ('Unhewn'),
       ('Semi-hewn'),
       ('Dressed'),
       ('Ashlar'),
       ('Bossed')

PRINT('Creating LstArchitecturalFacing')
CREATE TABLE dbo.[LstArchitecturalFacing] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 5 values into LstArchitecturalFacing')
INSERT INTO dbo.[LstArchitecturalFacing]([Description])
VALUES (''),
       ('Unfaced'),
       ('Plaster'),
       ('Mud'),
       ('Paint')

PRINT('Creating LstArchitecturalMasonry')
CREATE TABLE dbo.[LstArchitecturalMasonry] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 4 values into LstArchitecturalMasonry')
INSERT INTO dbo.[LstArchitecturalMasonry]([Description])
VALUES (''),
       ('Wall Stones'),
       ('Chinkstones'),
       ('Fillstones'),
       ('Brick')

PRINT('Creating LstArchitecturalMasonryStones')
CREATE TABLE dbo.[LstArchitecturalMasonryStones] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 6 values into LstArchitecturalMasonryStones')
INSERT INTO dbo.[LstArchitecturalMasonryStones]([Description])
VALUES (''),
       ('Cobble (6 - 25cm'),
       ('Small Boulder (25 - 50cm'),
       ('Medium Boulder (50 - 75cm'),
       ('Large Boulder (75 - 100cm'),
       ('Very Large Boulder (>1m)')

PRINT('Creating LstArchitecturalMaterial')
CREATE TABLE dbo.[LstArchitecturalMaterial] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 6 values into LstArchitecturalMaterial')
INSERT INTO dbo.[LstArchitecturalMaterial]([Description])
VALUES (''),
       ('Limestone'),
       ('Chert'),
       ('Basalt'),
       ('Nari'),
       ('Mudbrick')

PRINT('Creating LstArchitecturalMaterialQualifier')
CREATE TABLE dbo.[LstArchitecturalMaterialQualifier] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 12 values into LstArchitecturalMaterialQualifier')
INSERT INTO dbo.[LstArchitecturalMaterialQualifier]([Description])
VALUES ('None'),
       ('Hard'),
       ('Soft'),
       ('Cherty'),
       ('Fossiliferous'),
       ('Decayed'),
       ('Freshly-quarried'),
       ('Reused'),
       ('Oven-baked'),
       ('Sun-baked'),
       ('Unbaked'),
       ('Burned')

PRINT('Creating LstArchitecturalMortar')
CREATE TABLE dbo.[LstArchitecturalMortar] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 7 values into LstArchitecturalMortar')
INSERT INTO dbo.[LstArchitecturalMortar]([Description])
VALUES (''),
       ('Dry-laid'),
       ('Clay'),
       ('Mud'),
       ('Cement'),
       ('Plaster'),
       ('Lime')

PRINT('Creating LstArchitecturalPreservation')
CREATE TABLE dbo.[LstArchitecturalPreservation] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(50)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 8 values into LstArchitecturalPreservation')
INSERT INTO dbo.[LstArchitecturalPreservation]([Description])
VALUES (''),
       ('Complete'),
       ('Partial Superstructure: Most'),
       ('Partial Superstructure: Half'),
       ('Partial Superstructure: Little'),
       ('Foundation Only: Complete'),
       ('Foundation Only: Partial'),
       ('Robbed')

PRINT('Creating LstEarthConsistenceCompactness')
CREATE TABLE dbo.[LstEarthConsistenceCompactness] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 19 values into LstEarthConsistenceCompactness')
INSERT INTO dbo.[LstEarthConsistenceCompactness]([Description])
VALUES (''),
       ('Loose (Very)'),
       ('Loose (Moderately)'),
       ('Loose (Slightly)'),
       ('Crumbly (Very)'),
       ('Crumbly (Moderately)'),
       ('Crumbly (Slightly)'),
       ('Friable (Very)'),
       ('Friable (Moderately)'),
       ('Friable (Slightly)'),
       ('Firm (Very)'),
       ('Firm (Moderately)'),
       ('Firm (Slightly)'),
       ('Gravelly (Very)'),
       ('Gravelly (Moderately)'),
       ('Gravelly (Slightly)'),
       ('Rubbly (Very)'),
       ('Rubbly (Moderately)'),
       ('Rubbly (Slightly)')

PRINT('Creating LstEarthConsistenceHardness')
CREATE TABLE dbo.[LstEarthConsistenceHardness] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 7 values into LstEarthConsistenceHardness')
INSERT INTO dbo.[LstEarthConsistenceHardness]([Description])
VALUES (''),
       ('Very Loose'),
       ('Loose'),
       ('Somewhat Loose'),
       ('Somewhat Hard'),
       ('Hard'),
       ('Very Hard')

PRINT('Creating LstEarthConsistenceStructure')
CREATE TABLE dbo.[LstEarthConsistenceStructure] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 7 values into LstEarthConsistenceStructure')
INSERT INTO [LstEarthConsistenceStructure]([Description])
VALUES (''),
       ('Puddling'),
       ('Channeling'),
       ('Sheet Wash'),
       ('Wind'),
       ('Talus'),
       ('Random')

PRINT('Creating LstEarthConsistenceWetness')
CREATE TABLE dbo.[LstEarthConsistenceWetness] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 10 values into LstEarthConsistenceWetness')
INSERT INTO dbo.[LstEarthConsistenceWetness]([Description])
VALUES (''),
       ('Dry (Very)'),
       ('Dry (Moderately)'),
       ('Dry (Slightly)'),
       ('Moist (Very)'),
       ('Moist (Moderately)'),
       ('Moist (Slightly)'),
       ('Wet (Very)'),
       ('Wet (Moderately)'),
       ('Wet (Slightly)')

PRINT('Creating LstEarthInclusionsArtifact')
CREATE TABLE dbo.[LstEarthInclusionsArtifact] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 12 values into LstEarthInclusionsArtifact')
INSERT INTO dbo.[LstEarthInclusionsArtifact]([Description])
VALUES (''),
       ('Pottery'),
       ('Flint'),
       ('Glass'),
       ('Tesserae'),
       ('Tabun Fragments'),
       ('Brick Fragments'),
       ('Roof Tiles'),
       ('Worked Stones'),
       ('Burned Stones'),
       ('Unfired Clay'),
       ('Architectural Fragments')

PRINT('Creating LstEarthInclusionsEarth')
CREATE TABLE dbo.[LstEarthInclusionsEarth] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 5 values into LstEarthInclusionsEarth')
INSERT INTO dbo.[LstEarthInclusionsEarth]([Description])
VALUES (''),
       ('Nari Pockets'),
       ('Brick Material'),
       ('Pebble Pockets'),
       ('Ash Pockets')

PRINT('Creating LstEarthInclusionsOrganic')
CREATE TABLE dbo.[LstEarthInclusionsOrganic] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 5 values into LstEarthInclusionsOrganic')
INSERT INTO dbo.[LstEarthInclusionsOrganic]([Description])
VALUES (''),
       ('Bones'),
       ('Shells'),
       ('Carbonized Bits'),
       ('Organic Pockets')

PRINT('Creating LstEarthInclusionsStone')
CREATE TABLE dbo.[LstEarthInclusionsStone] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 4 values into LstEarthInclusionsStone')
INSERT INTO dbo.[LstEarthInclusionsStone]([Description])
VALUES (''),
       ('Pebbles (2mm - 6cm)'),
       ('Cobbles (6 - 25cm)'),
       ('Boulders (>25cm)')

PRINT('Creating LstEarthParticleShape')
CREATE TABLE dbo.[LstEarthParticleShape] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 5 rows into LstEarthParticleShape')
INSERT INTO dbo.[LstEarthParticleShape]([Description])
VALUES (''),
       ('Angular'),
       ('Sub-Angular'),
       ('Sub-Round'),
       ('Round')

PRINT('Creating LstEarthSurfaceMaterial')
CREATE TABLE dbo.[LstEarthSurfaceMaterial] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 8 values into LstEarthSurfaceMaterial')
INSERT INTO dbo.[LstEarthSurfaceMaterial]([Description])
VALUES (''),
       ('Beaten Earth'),
       ('Lime'),
       ('Plaster'),
       ('Crushed Nari'),
       ('Bricks'),
       ('Cobbles'),
       ('Flagstone')

PRINT('Creating LstEarthTexture')
CREATE TABLE dbo.[LstEarthTexture] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(50)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 5 rows into LstEarthTexture')
INSERT INTO dbo.[LstEarthTexture]([Description])
VALUES (''),
       ('Sand - Sandy Loam'),
       ('Loam - Silt Loam'),
       ('Sandy Clay Loam - Silty Clay Loam'),
       ('Clay')

PRINT('Creating LstInstallationMaterial')
CREATE TABLE dbo.[LstInstallationMaterial] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 10 values into LstInstallationMaterial')
INSERT INTO dbo.[LstInstallationMaterial]([Description])
VALUES (''),
       ('Limestone'),
       ('Chert'),
       ('Ceramic'),
       ('Mud'),
       ('Mudbrick'),
       ('Basalt'),
       ('Plaster'),
       ('Earth'),
       ('Stone'),
       ('Nari')

PRINT('Creating LstInstallationMaterialQualifier')
CREATE TABLE dbo.[LstInstallationMaterialQualifier] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 12 values into LstInstallationMaterialQualifier')
INSERT INTO dbo.[LstInstallationMaterialQualifier]([Description])
VALUES ('None'),
       ('Hard'),
       ('Soft'),
       ('Cherty'),
       ('Fossiliferous'),
       ('Decayed'),
       ('Freshly-quarried'),
       ('Reused'),
       ('Oven-baked'),
       ('Sun-baked'),
       ('Unbaked'),
       ('Burned')

PRINT('Creating LstInstallationPlan')
CREATE TABLE dbo.[LstInstallationPlan] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 9 values into LstInstallationPlan')
INSERT INTO dbo.[LstInstallationPlan]([Description])
VALUES (''),
       ('Linear'),
       ('Curvilinear'),
       ('Rectangular'),
       ('Triangular'),
       ('Circular'),
       ('Semi-circular'),
       ('Oval'),
       ('Irregular')

PRINT('Creating LstInstallationPlanQualifier')
CREATE TABLE dbo.[LstInstallationPlanQualifier] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 5 values into LstInstallationPlanQualifier')
INSERT INTO dbo.[LstInstallationPlanQualifier]([Description])
VALUES ('None'),
       ('Rounded'),
       ('Squared'),
       ('Nearly'),
       ('Slightly')

PRINT('Creating LstInstallationType')
CREATE TABLE dbo.[LstInstallationType] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 13 values into LstInstallationType')
INSERT INTO dbo.[LstInstallationType]([Description])
VALUES (''),
       ('Pit'),
       ('Silo'),
       ('Bin'),
       ('Kiln'),
       ('Tabun'),
       ('Cistern'),
       ('Reservoir'),
       ('Burial'),
       ('Pavement'),
       ('Foundation Trench'),
       ('Robber Trench'),
       ('Unknown')

PRINT('Creating LstInstallationTypeCertainty')
CREATE TABLE dbo.[LstInstallationTypeCertainty] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 4 values into LstInstallationTypeCertainty')
INSERT INTO dbo.[LstInstallationTypeCertainty]([Description])
VALUES (''),
       ('Certain'),
       ('Probable'),
       ('Possible')

PRINT('Creating LstLocusSeparationClarity')
CREATE TABLE dbo.[LstLocusSeparationClarity] (
  [ID]          TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description] NVARCHAR(25)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 7 rows into LstLocusSeparationClarity')
INSERT INTO dbo.[LstLocusSeparationClarity]([Description])
VALUES (''),
       ('Very Clear'),
       ('Clear'),
       ('Average'),
       ('Unclear'),
       ('Very Unclear'),
       ('Arbitrary')

PRINT('Creating LstMunselNumber')
CREATE TABLE dbo.[LstMunsellNumber] (
  [ID]          SMALLINT      NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Hue]         NVARCHAR(10)  NOT NULL  DEFAULT (''),
  [Value]       NVARCHAR(10)  NOT NULL  DEFAULT (''),
  [Chroma]      NVARCHAR(10)  NOT NULL  DEFAULT (''),
  [Description] NVARCHAR(50)  NOT NULL  DEFAULT ('')
)

PRINT('Inserting 323 rows into LstMunsellNumber')
INSERT INTO dbo.[LstMunsellNumber]([Hue], [Value], [Chroma], [Description])
VALUES (     '',    '',     '', ''),
       ('GLEY1',   '8',    'N', 'White'),
       ('GLEY1',   '8',  '10Y', 'Light Greenish Gray'),
       ('GLEY1',   '8',  '5GY', 'Light Greenish Gray'),
       ('GLEY1',   '8', '10GY', 'Light Greenish Gray'),
       ('GLEY1',   '8',  '5G1', 'Light Greenish Gray'),
       ('GLEY1',   '8',  '5G2', 'Pale Green'),
       ('GLEY1',   '7',    'N', 'Light Gray'),
       ('GLEY1',   '7',  '10Y', 'Light Greenish Gray'),
       ('GLEY1',   '7',  '5GY', 'Light Greenish Gray'),
       ('GLEY1',   '7', '10GY', 'Light Greenish Gray'),
       ('GLEY1',   '7',  '5G1', 'Light Greenish Gray'),
       ('GLEY1',   '7',  '5G2', 'Pale Green'),
       ('GLEY1',   '6',    'N', 'Gray'),
       ('GLEY1',   '6',  '10Y', 'Greenish Gray'),
       ('GLEY1',   '6',  '5GY', 'Greenish Gray'),
       ('GLEY1',   '6', '10GY', 'Greenish Gray'),
       ('GLEY1',   '6',  '5G1', 'Greenish Gray'),
       ('GLEY1',   '6',  '5G2', 'Pale Green'),
       ('GLEY1',   '5',    'N', 'Gray'),
       ('GLEY1',   '5',  '10Y', 'Greenish Gray'),
       ('GLEY1',   '5',  '5GY', 'Greenish Gray'),
       ('GLEY1',   '5', '10GY', 'Greenish Gray'),
       ('GLEY1',   '5',  '5G1', 'Greenish Gray'),
       ('GLEY1',   '5',  '5G2', 'Grayish Green'),
       ('GLEY1',   '4',    'N', 'Dark Gray'),
       ('GLEY1',   '4',  '10Y', 'Dark Greenish Gray'),
       ('GLEY1',   '4',  '5GY', 'Dark Greenish Gray'),
       ('GLEY1',   '4', '10GY', 'Dark Greenish Gray'),
       ('GLEY1',   '4',  '5G1', 'Dark Greenish Gray'),
       ('GLEY1',   '4',  '5G2', 'Grayish Green'),
       ('GLEY1',   '3',    'N', 'Very Dark Gray'),
       ('GLEY1',   '3',  '10Y', 'Dark Greenish Gray'),
       ('GLEY1',   '3',  '5GY', 'Dark Greenish Gray'),
       ('GLEY1',   '3', '10GY', 'Dark Greenish Gray'),
       ('GLEY1',   '3',  '5G1', 'Dark Greenish Gray'),
       ('GLEY1',   '3',  '5G2', 'Dark Grayish Green'),
       ('GLEY1', '2.5',    'N', 'Black'),
       ('GLEY1', '2.5',  '10Y', 'Greenish Black'),
       ('GLEY1', '2.5',  '5GY', 'Greenish Black'),
       ('GLEY1', '2.5', '10GY', 'Greenish Black'),
       ('GLEY1', '2.5',  '5G1', 'Greenish Black'),
       ('GLEY1', '2.5',  '5G2', 'Dark Grayish Green'),
       ('GLEY2',   '8',  '10G', 'Light Greenish Gray'),
       ('GLEY2',   '8',  '5BG', 'Light Greenish Gray'),
       ('GLEY2',   '8', '10BG', 'Light Greenish Gray'),
       ('GLEY2',   '8',   '5B', 'Light Bluish Gray'),
       ('GLEY2',   '8',  '10B', 'Light Bluish Gray'),
       ('GLEY2',   '8',  '5PB', 'Light Bluish Gray'),
       ('GLEY2',   '7',  '10G', 'Light Greenish Gray'),
       ('GLEY2',   '7',  '5BG', 'Light Greenish Gray'),
       ('GLEY2',   '7', '10BG', 'Light Greenish Gray'),
       ('GLEY2',   '7',   '5B', 'Light Bluish Gray'),
       ('GLEY2',   '7',  '10B', 'Light Bluish Gray'),
       ('GLEY2',   '7',  '5PB', 'Light Bluish Gray'),
       ('GLEY2',   '6',  '10G', 'Greenish Gray'),
       ('GLEY2',   '6',  '5BG', 'Greenish Gray'),
       ('GLEY2',   '6', '10BG', 'Greenish Gray'),
       ('GLEY2',   '6',   '5B', 'Bluish Gray'),
       ('GLEY2',   '6',  '10B', 'Bluish Gray'),
       ('GLEY2',   '6',  '5PB', 'Bluish Gray'),
       ('GLEY2',   '5',  '10G', 'Greenish Gray'),
       ('GLEY2',   '5',  '5BG', 'Greenish Gray'),
       ('GLEY2',   '5', '10BG', 'Greenish Gray'),
       ('GLEY2',   '5',   '5B', 'Bluish Gray'),
       ('GLEY2',   '5',  '10B', 'Bluish Gray'),
       ('GLEY2',   '5',  '5PB', 'Bluish Gray'),
       ('GLEY2',   '4',  '10G', 'Dark Greenish Gray'),
       ('GLEY2',   '4',  '5BG', 'Dark Greenish Gray'),
       ('GLEY2',   '4', '10BG', 'Dark Greenish Gray'),
       ('GLEY2',   '4',   '5B', 'Dark Bluish Gray'),
       ('GLEY2',   '4',  '10B', 'Dark Bluish Gray'),
       ('GLEY2',   '4',  '5PB', 'Dark Bluish Gray'),
       ('GLEY2',   '3',  '10G', 'Dark Greenish Gray'),
       ('GLEY2',   '3',  '5BG', 'Dark Greenish Gray'),
       ('GLEY2',   '3', '10BG', 'Dark Greenish Gray'),
       ('GLEY2',   '3',   '5B', 'Dark Bluish Gray'),
       ('GLEY2',   '3',  '10B', 'Dark Bluish Gray'),
       ('GLEY2',   '3',  '5PB', 'Dark Bluish Gray'),
       ('GLEY2', '2.5',  '10G', 'Greenish Black'),
       ('GLEY2', '2.5',  '5BG', 'Greenish Black'),
       ('GLEY2', '2.5', '10BG', 'Greenish Black'),
       ('GLEY2', '2.5',   '5B', 'Bluish Black'),
       ('GLEY2', '2.5',  '10B', 'Bluish Black'),
       ('GLEY2', '2.5',  '5PB', 'Bluish Black'),
       (  '10R',   '8',    '1', 'White'),
       (  '10R',   '8',    '2', 'Pinkish White'),
       (  '10R',   '8',    '3', 'Pink'),
       (  '10R',   '8',    '4', 'Pink'),
       (  '10R',   '7',    '1', 'Light Gray'),
       (  '10R',   '7',    '2', 'Pale Red'),
       (  '10R',   '7',    '3', 'Pale Red'),
       (  '10R',   '7',    '4', 'Pale Red'),
       (  '10R',   '7',    '6', 'Light Red'),
       (  '10R',   '7',    '8', 'Light Red'),
       (  '10R',   '6',    '1', 'Reddish Gray'),
       (  '10R',   '6',    '2', 'Pale Red'),
       (  '10R',   '6',    '3', 'Pale Red'),
       (  '10R',   '6',    '4', 'Pale Red'),
       (  '10R',   '6',    '6', 'Light Red'),
       (  '10R',   '6',    '8', 'Light Red'),
       (  '10R',   '5',    '1', 'Reddish Gray'),
       (  '10R',   '5',    '2', 'Weak Red'),
       (  '10R',   '5',    '3', 'Weak Red'),
       (  '10R',   '5',    '4', 'Weak Red'),
       (  '10R',   '5',    '6', 'Red'),
       (  '10R',   '5',    '8', 'Red'),
       (  '10R',   '4',    '1', 'Dark Reddish Gray'),
       (  '10R',   '4',    '2', 'Weak Red'),
       (  '10R',   '4',    '3', 'Weak Red'),
       (  '10R',   '4',    '4', 'Weak Red'),
       (  '10R',   '4',    '6', 'Red'),
       (  '10R',   '4',    '8', 'Red'),
       (  '10R',   '3',    '1', 'Dark Reddish Gray'),
       (  '10R',   '3',    '2', 'Dusky Red'),
       (  '10R',   '3',    '3', 'Dusky Red'),
       (  '10R',   '3',    '4', 'Dusky Red'),
       (  '10R',   '3',    '6', 'Dark Red'),
       (  '10R', '2.5',    '1', 'Reddish Black'),
       (  '10R', '2.5',    '2', 'Very Dusky Red'),
       ('2.5YR',   '8',    '1', 'White'),
       ('2.5YR',   '8',    '2', 'Pinkish White'),
       ('2.5YR',   '8',    '3', 'Pink'),
       ('2.5YR',   '8',    '4', 'Pink'),
       ('2.5YR',   '7',    '1', 'Light Reddish Gray'),
       ('2.5YR',   '7',    '2', 'Pale Red'),
       ('2.5YR',   '7',    '3', 'Light Reddish Brown'),
       ('2.5YR',   '7',    '4', 'Light Reddish Brown'),
       ('2.5YR',   '7',    '6', 'Light Red'),
       ('2.5YR',   '7',    '8', 'Light Red'),
       ('2.5YR',   '6',    '1', 'Reddish Gray'),
       ('2.5YR',   '6',    '2', 'Pale Red'),
       ('2.5YR',   '6',    '3', 'Light Reddish Brown'),
       ('2.5YR',   '6',    '4', 'Light Reddish Brown'),
       ('2.5YR',   '6',    '6', 'Light Red'),
       ('2.5YR',   '6',    '8', 'Light Red'),
       ('2.5YR',   '5',    '1', 'Reddish Gray'),
       ('2.5YR',   '5',    '2', 'Weak Red'),
       ('2.5YR',   '5',    '3', 'Reddish Brown'),
       ('2.5YR',   '5',    '4', 'Reddish Brown'),
       ('2.5YR',   '5',    '6', 'Red'),
       ('2.5YR',   '5',    '8', 'Red'),
       ('2.5YR',   '4',    '1', 'Dark Reddish Brown'),
       ('2.5YR',   '4',    '2', 'Weak Red'),
       ('2.5YR',   '4',    '3', 'Reddish Brown'),
       ('2.5YR',   '4',    '4', 'Reddish Brown'),
       ('2.5YR',   '4',    '6', 'Red'),
       ('2.5YR',   '4',    '8', 'Red'),
       ('2.5YR',   '3',    '1', 'Dark Reddish Brown'),
       ('2.5YR',   '3',    '2', 'Dusky Red'),
       ('2.5YR',   '3',    '3', 'Dark Reddish Brown'),
       ('2.5YR',   '3',    '4', 'Dark Reddish Brown'),
       ('2.5YR',   '3',    '6', 'Dark Red'),
       ('2.5YR', '2.5',    '1', 'Reddish Black'),
       ('2.5YR', '2.5',    '2', 'Very Dusky Red'),
       ('2.5YR', '2.5',    '3', 'Dark Reddish Brown'),
       ('2.5YR', '2.5',    '4', 'Dark Reddish Brown'),
       (  '5YR',   '8',    '1', 'White'),
       (  '5YR',   '8',    '2', 'Pinkish White'),
       (  '5YR',   '8',    '3', 'Pink'),
       (  '5YR',   '8',    '4', 'Pink'),
       (  '5YR',   '7',    '1', 'Light Gray'),
       (  '5YR',   '7',    '2', 'Pinkish Gray'),
       (  '5YR',   '7',    '3', 'Pink'),
       (  '5YR',   '7',    '4', 'Pink'),
       (  '5YR',   '7',    '6', 'Reddish Yellow'),
       (  '5YR',   '7',    '8', 'Reddish Yellow'),
       (  '5YR',   '6',    '1', 'Gray'),
       (  '5YR',   '6',    '2', 'Pinkish Gray'),
       (  '5YR',   '6',    '3', 'Light Reddish Brown'),
       (  '5YR',   '6',    '4', 'Light Reddish Brown'),
       (  '5YR',   '6',    '6', 'Reddish Yellow'),
       (  '5YR',   '6',    '8', 'Reddish Yellow'),
       (  '5YR',   '5',    '1', 'Gray'),
       (  '5YR',   '5',    '2', 'Reddish Gray'),
       (  '5YR',   '5',    '3', 'Reddish Brown'),
       (  '5YR',   '5',    '4', 'Reddish Brown'),
       (  '5YR',   '5',    '6', 'Yellowish Red'),
       (  '5YR',   '5',    '8', 'Yellowish Red'),
       (  '5YR',   '4',    '1', 'Dark Gray'),
       (  '5YR',   '4',    '2', 'Dark Reddish Gray'),
       (  '5YR',   '4',    '3', 'Reddish Brown'),
       (  '5YR',   '4',    '4', 'Reddish Brown'),
       (  '5YR',   '4',    '6', 'Yellowish Red'),
       (  '5YR',   '3',    '1', 'Very Dark Gray'),
       (  '5YR',   '3',    '2', 'Dark Reddish Brown'),
       (  '5YR',   '3',    '3', 'Dark Reddish Brown'),
       (  '5YR',   '3',    '4', 'Dark Reddish Brown'),
       (  '5YR', '2.5',    '1', 'Black'),
       (  '5YR', '2.5',    '2', 'Dark Reddish Brown'),
       ('7.5YR',   '8',    '1', 'White'),
       ('7.5YR',   '8',    '2', 'Pinkish White'),
       ('7.5YR',   '8',    '3', 'Pink'),
       ('7.5YR',   '8',    '4', 'Pink'),
       ('7.5YR',   '8',    '6', 'Reddish Yellow'),
       ('7.5YR',   '7',    '1', 'Light Gray'),
       ('7.5YR',   '7',    '2', 'Pinkish Gray'),
       ('7.5YR',   '7',    '3', 'Pink'),
       ('7.5YR',   '7',    '4', 'Pink'),
       ('7.5YR',   '7',    '6', 'Reddish Yellow'),
       ('7.5YR',   '7',    '8', 'Reddish Yellow'),
       ('7.5YR',   '6',    '1', 'Gray'),
       ('7.5YR',   '6',    '2', 'Pinkish Gray'),
       ('7.5YR',   '6',    '3', 'Light Brown'),
       ('7.5YR',   '6',    '4', 'Light Brown'),
       ('7.5YR',   '6',    '6', 'Reddish Yellow'),
       ('7.5YR',   '6',    '8', 'Reddish Yellow'),
       ('7.5YR',   '5',    '1', 'Gray'),
       ('7.5YR',   '5',    '2', 'Brown'),
       ('7.5YR',   '5',    '3', 'Brown'),
       ('7.5YR',   '5',    '4', 'Brown'),
       ('7.5YR',   '5',    '6', 'Strong Brown'),
       ('7.5YR',   '5',    '8', 'Strong Brown'),
       ('7.5YR',   '4',    '1', 'Dark Gray'),
       ('7.5YR',   '4',    '2', 'Brown'),
       ('7.5YR',   '4',    '3', 'Brown'),
       ('7.5YR',   '4',    '4', 'Brown'),
       ('7.5YR',   '4',    '6', 'Strong Brown'),
       ('7.5YR',   '3',    '1', 'Very Dark Gray'),
       ('7.5YR',   '3',    '2', 'Dark brown'),
       ('7.5YR',   '3',    '3', 'Dark Brown'),
       ('7.5YR',   '3',    '4', 'Dark Brown'),
       ('7.5YR', '2.5',    '1', 'Black'),
       ('7.5YR', '2.5',    '2', 'Very Dark Brown'),
       ('7.5YR', '2.5',    '3', 'Very Dark Brown'),
       (' 10YR',   '8',    '1', 'White'),
       (' 10YR',   '8',    '2', 'Very Pale Brown'),
       (' 10YR',   '8',    '3', 'Very Pale Brown'),
       (' 10YR',   '8',    '4', 'Very Pale Brown'),
       (' 10YR',   '8',    '6', 'Yellow'),
       (' 10YR',   '8',    '8', 'Yellow'),
       (' 10YR',   '7',    '1', 'Light Gray'),
       (' 10YR',   '7',    '2', 'Light Gray'),
       (' 10YR',   '7',    '3', 'Very Pale Brown'),
       (' 10YR',   '7',    '4', 'Very Pale Brown'),
       (' 10YR',   '7',    '6', 'Yellow'),
       (' 10YR',   '7',    '8', 'Yellow'),
       (' 10YR',   '6',    '1', 'Gray'),
       (' 10YR',   '6',    '2', 'Light Brownish Gray'),
       (' 10YR',   '6',    '3', 'Pale Brown'),
       (' 10YR',   '6',    '4', 'Light Yellowish Brown'),
       (' 10YR',   '6',    '6', 'Brownish Yellow'),
       (' 10YR',   '6',    '8', 'Brownish Yellow'),
       (' 10YR',   '5',    '1', 'Gray'),
       (' 10YR',   '5',    '2', 'Grayish Brown'),
       (' 10YR',   '5',    '3', 'Brown'),
       (' 10YR',   '5',    '4', 'Yellowish Brown'),
       (' 10YR',   '5',    '6', 'Yellowish Brown'),
       (' 10YR',   '5',    '8', 'Yellowish Brown'),
       (' 10YR',   '4',    '1', 'Dark Gray'),
       (' 10YR',   '4',    '2', 'Dark Grayish Brown'),
       (' 10YR',   '4',    '3', 'Brown'),
       (' 10YR',   '4',    '4', 'Dark Yellowish Brown'),
       (' 10YR',   '4',    '6', 'Dark Yellowish Brown'),
       (' 10YR',   '3',    '1', 'Very Dark Gray'),
       (' 10YR',   '3',    '2', 'Very Dark Grayish Brown'),
       (' 10YR',   '3',    '3', 'Dark Brown'),
       (' 10YR',   '3',    '4', 'Dark Yellowish Brown'),
       (' 10YR',   '3',    '6', 'Dark Yellowish Brown'),
       (' 10YR',   '2',    '1', 'Black'),
       (' 10YR',   '2',    '2', 'Very Dark Brown'),
       (' 2.5Y',   '8',    '1', 'White'),
       (' 2.5Y',   '8',    '2', 'Pale Yellow'),
       (' 2.5Y',   '8',    '3', 'Pale Yellow'),
       (' 2.5Y',   '8',    '4', 'Pale Yellow'),
       (' 2.5Y',   '8',    '6', 'Yellow'),
       (' 2.5Y',   '8',    '8', 'Yellow'),
       (' 2.5Y',   '7',    '1', 'Light Gray'),
       (' 2.5Y',   '7',    '2', 'Light Gray'),
       (' 2.5Y',   '7',    '3', 'Pale Yellow'),
       (' 2.5Y',   '7',    '4', 'Pale Yellow'),
       (' 2.5Y',   '7',    '6', 'Yellow'),
       (' 2.5Y',   '7',    '8', 'Yellow'),
       (' 2.5Y',   '6',    '1', 'Gray'),
       (' 2.5Y',   '6',    '2', 'Light Brownish Gray'),
       (' 2.5Y',   '6',    '3', 'Light Yellowish Brown'),
       (' 2.5Y',   '6',    '4', 'Light Yellowish Brown'),
       (' 2.5Y',   '6',    '6', 'Olive Yellow'),
       (' 2.5Y',   '6',    '8', 'Olive Yellow'),
       (' 2.5Y',   '5',    '1', 'Gray'),
       (' 2.5Y',   '5',    '2', 'Grayish Brown'),
       (' 2.5Y',   '5',    '3', 'Light Olive Brown'),
       (' 2.5Y',   '5',    '4', 'Light Olive Brown'),
       (' 2.5Y',   '5',    '6', 'Light Olive Brown'),
       (' 2.5Y',   '4',    '1', 'Dark Gray'),
       (' 2.5Y',   '4',    '2', 'Dark Grayish Brown'),
       (' 2.5Y',   '4',    '3', 'Olive Brown'),
       (' 2.5Y',   '4',    '4', 'Olive Brown'),
       (' 2.5Y',   '3',    '1', 'Very Dark Gray'),
       (' 2.5Y',   '3',    '2', 'Very Dark Grayish Brown'),
       (' 2.5Y',   '3',    '3', 'Dark Olive Brown'),
       (' 2.5Y', '2.5',    '1', 'Black'),
       ('   5Y',   '8',    '1', 'White'),
       ('   5Y',   '8',    '2', 'Pale Yellow'),
       ('   5Y',   '8',    '3', 'Pale Yellow'),
       ('   5Y',   '8',    '4', 'Pale Yellow'),
       ('   5Y',   '8',    '6', 'Yellow'),
       ('   5Y',   '8',    '8', 'Yellow'),
       ('   5Y',   '7',    '1', 'Light Gray'),
       ('   5Y',   '7',    '2', 'Light Gray'),
       ('   5Y',   '7',    '3', 'Pale Yellow'),
       ('   5Y',   '7',    '4', 'Pale Yellow'),
       ('   5Y',   '7',    '6', 'Yellow'),
       ('   5Y',   '7',    '8', 'Yellow'),
       ('   5Y',   '6',    '1', 'Gray'),
       ('   5Y',   '6',    '2', 'Light Olive Gray'),
       ('   5Y',   '6',    '3', 'Pale Olive'),
       ('   5Y',   '6',    '4', 'Pale Olive'),
       ('   5Y',   '6',    '6', 'Olive Yellow'),
       ('   5Y',   '6',    '8', 'Olive Yellow'),
       ('   5Y',   '5',    '1', 'Gray'),
       ('   5Y',   '5',    '2', 'Olive Gray'),
       ('   5Y',   '5',    '3', 'Olive'),
       ('   5Y',   '5',    '4', 'Olive'),
       ('   5Y',   '5',    '6', 'Olive'),
       ('   5Y',   '4',    '1', 'Dark Gray'),
       ('   5Y',   '4',    '2', 'Olive Gray'),
       ('   5Y',   '4',    '3', 'Olive'),
       ('   5Y',   '4',    '4', 'Olive'),
       ('   5Y',   '3',    '1', 'Very Dark Gray'),
       ('   5Y',   '3',    '2', 'Dark Olive Gray'),
       ('   5Y', '2.5',    '1', 'Black'),
       ('   5Y', '2.5',    '2', 'Black')

PRINT('Creating LstStratigraphicRelationship')
CREATE TABLE dbo.[LstStratigraphicRelationship] (
  [ID]            TINYINT       NOT NULL  IDENTITY(0,1) PRIMARY KEY CLUSTERED,
  [Description]   NVARCHAR(50)  NOT NULL  DEFAULT (''),
  [Architectural] BIT           NOT NULL  DEFAULT ((0)),
  [Earth]         BIT           NOT NULL  DEFAULT ((0)),
  [Installation]  BIT           NOT NULL  DEFAULT ((0))
)

PRINT('Inserting 14 values into LstStratigraphicRelationship')
INSERT INTO dbo.[LstStratigraphicRelationship]([Description], [Architectural], [Earth], [Installation])
VALUES ('',                             1, 1, 1),
       ('Under',                        1, 1, 1),
       ('Over',                         1, 1, 1),
       ('Equals',                       1, 1, 1),
       ('Contiguous To',                1, 0, 1),
       ('Seals Against',                1, 0, 1),
       ('Cut By',                       1, 1, 1),
       ('Associated Foundation Trench', 0, 1, 0),
       ('Cuts',                         0, 1, 1),
       ('Abuts',                        0, 1, 0),
       ('Abutted By',                   0, 1, 0),
       ('Sealed Against By',            0, 1, 0),
       ('Bonded To',                    0, 1, 0),
       ('Fill Loci',                    0, 0, 1)

/*
* 
* Create the rest of the tables.
* These tables are created in order of their FK contraint requirements.
* 
*/

PRINT('Creating the rest of the tables')
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
  [ID]                                  UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusID]                             UNIQUEIDENTIFIER  NOT NULL
    CONSTRAINT [UQ_LocusDescriptionArchitecture_LocusID] UNIQUE([LocusID])
    FOREIGN KEY ([LocusID]) REFERENCES [Locus]([ID]),
  [ToolingWidth]                        DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [ToolingLength]                       DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [ToolingDepth]                        DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [ToolingPhoto]                        BIT               NOT NULL  DEFAULT ((0)),
  [ArchitecturalConstructionStyleID]    TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ArchitecturalConstructionStyleID]) REFERENCES [LstArchitecturalConstructionStyle]([ID]),
  [ArchitecturalConstructionSupportID]  TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ArchitecturalConstructionSupportID]) REFERENCES [LstArchitecturalConstructionSupport]([ID]),
  [ArchitecturalRemarks]                NVARCHAR(250)     NOT NULL  DEFAULT (''),
  [ArthitecturalTendencies]             NVARCHAR(250)     NOT NULL  DEFAULT (''),
  [CoursesMinimum]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [CoursesMaximum]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [CoursesRandom]                       BIT               NOT NULL  DEFAULT ((0)),
  [RowsMinimum]                         TINYINT           NOT NULL  DEFAULT ((0)),
  [RowsMaximum]                         TINYINT           NOT NULL  DEFAULT ((0)),
  [LengthMinimum]                       DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [LengthMaximum]                       DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [WidthMinimum]                        DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [WidthMaximum]                        DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [HeightMinimum]                       DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [HeightMaximum]                       DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [Orientation]                         SMALLINT          NOT NULL  DEFAULT ((0)),
  [Dip]                                 SMALLINT          NOT NULL  DEFAULT ((0)),
  [ArchitecturalPreservationID]         TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ArchitecturalPreservationID]) REFERENCES [LstArchitecturalPreservation]([ID]),
  [LeanDirection]                       SMALLINT          NOT NULL  DEFAULT ((0)),
  [LeanDegree]                          SMALLINT          NOT NULL  DEFAULT ((0)),
  [Remarks]                             NVARCHAR(1000)    NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionArchitectureMaterial] (
  [ID]                                UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionArchitectureID]    UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionArchitectureID]) REFERENCES [LocusDescriptionArchitecture]([ID]),
  [ArchitecturalMaterialID]           TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionArchitectureMaterial_LocusDescriptionArchitectureID_ArchitecturalMaterialID]
      UNIQUE([LocusDescriptionArchitectureID], [ArchitecturalMaterialID])
    FOREIGN KEY ([ArchitecturalMaterialID]) REFERENCES [LstArchitecturalMaterial]([ID]),
  [ArchitecturalMaterialQualifierID]  TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ArchitecturalMaterialQualifierID]) REFERENCES [LstArchitecturalMaterialQualifier]([ID]),
  [Percentage]                        TINYINT           NOT NULL  DEFAULT ((0)),
  [Remarks]                           NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionArchitectureMasonry] (
  [ID]                              UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionArchitectureID]  UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionArchitectureID]) REFERENCES [LocusDescriptionArchitecture]([ID]),
  [ArchitecturalMasonryID]          TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ArchitecturalMasonryID]) REFERENCES [LstArchitecturalMasonry]([ID]),
  [ArchitecturalMasonryStonesID]    TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionArchitectureMasonry_LocusDescriptionArchitectureID_ArchitecturalMasonryID]
      UNIQUE([LocusDescriptionArchitectureID], [ArchitecturalMasonryID], [ArchitecturalMasonryStonesID])
    FOREIGN KEY ([ArchitecturalMasonryStonesID]) REFERENCES [LstArchitecturalMasonryStones]([ID]),
  [BrickLengthMinimum]              DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [BrickLengthMaximum]              DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [BrickWidthMinimum]               DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [BrickWidthMaximum]               DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [BrickHeightMinimum]              DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [BrickHeightMaximum]              DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [Percentage]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [Remarks]                         NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionArchitectureDressing] (
  [ID]                              UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionArchitectureID]  UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionArchitectureID]) REFERENCES [LocusDescriptionArchitecture]([ID]),
  [ArchitecturalDressingID]         TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionArchitectureMaterial_LocusDescriptionArchitectureID_ArchitecturalDressingID]
      UNIQUE([LocusDescriptionArchitectureID], [ArchitecturalDressingID])
    FOREIGN KEY ([ArchitecturalDressingID]) REFERENCES [LstArchitecturalDressing]([ID]),
  [Percentage]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [Remarks]                         NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionArchitectureMortar] (
  [ID]                              UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionArchitectureID]  UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionArchitectureID]) REFERENCES [LocusDescriptionArchitecture]([ID]),
  [ArchitecturalMortarID]           TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionArchitectureMaterial_LocusDescriptionArchitectureID_ArchitecturalMortarID]
      UNIQUE([LocusDescriptionArchitectureID], [ArchitecturalMortarID])
    FOREIGN KEY ([ArchitecturalMortarID]) REFERENCES [LstArchitecturalMortar]([ID]),
  [Percentage]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [AverageThickness]                TINYINT           NOT NULL  DEFAULT ((0)),
  [Remarks]                         NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionArchitectureFacing] (
  [ID]                              UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionArchitectureID]  UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionArchitectureID]) REFERENCES [LocusDescriptionArchitecture]([ID]),
  [ArchitecturalFacingID]           TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionArchitectureMaterial_LocusDescriptionArchitectureID_ArchitecturalFacingID]
      UNIQUE([LocusDescriptionArchitectureID], [ArchitecturalFacingID])
    FOREIGN KEY ([ArchitecturalFacingID]) REFERENCES [LstArchitecturalFacing]([ID]),
  [Percentage]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [MunselNumberID]                  SMALLINT          NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([MunselNumberID]) REFERENCES [LstMunsellNumber]([ID]),
  [Remarks]                         NVARCHAR(250)     NOT NULL  DEFAULT ('')
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
  [Remarks]                   NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionInstallation] (
  [ID]      UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusID] UNIQUEIDENTIFIER  NOT NULL
    CONSTRAINT [UQ_LocusDescriptionInstallation_LocusID] UNIQUE([LocusID])
    FOREIGN KEY ([LocusID]) REFERENCES [Locus]([ID]),
  [InstallationTypeID] TINYINT NOT NULL DEFAULT ((0))
    FOREIGN KEY ([InstallationTypeID]) REFERENCES [LstInstallationType]([ID]),
  [InstallationTypeCertaintyID] TINYINT NOT NULL DEFAULT ((0))
    FOREIGN KEY ([InstallationTypeCertaintyID]) REFERENCES [LstInstallationTypeCertainty]([ID]),
  [InstallationPlanID] TINYINT NOT NULL DEFAULT ((0))
    FOREIGN KEY ([InstallationPlanID]) REFERENCES [LstInstallationPlan]([ID]),
  [InstallationPlanQualifierID] TINYINT NOT NULL DEFAULT ((0))
    FOREIGN KEY ([InstallationPlanQualifierID]) REFERENCES [LstInstallationPlanQualifier]([ID]),
  [ToolingWidth]                        DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [ToolingLength]                       DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [ToolingDepth]                        DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [ToolingPhoto]                        BIT               NOT NULL  DEFAULT ((0)),
  [ArchitecturalConstructionStyleID]    TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ArchitecturalConstructionStyleID]) REFERENCES [LstArchitecturalConstructionStyle]([ID]),
  [ArchitecturalConstructionSupportID]  TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ArchitecturalConstructionSupportID]) REFERENCES [LstArchitecturalConstructionSupport]([ID]),
  [ArchitecturalRemarks]                NVARCHAR(250)     NOT NULL  DEFAULT (''),
  [ArthitecturalTendencies]             NVARCHAR(250)     NOT NULL  DEFAULT (''),
  [CoursesMinimum]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [CoursesMaximum]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [CoursesRandom]                       BIT               NOT NULL  DEFAULT ((0)),
  [RowsMinimum]                         TINYINT           NOT NULL  DEFAULT ((0)),
  [RowsMaximum]                         TINYINT           NOT NULL  DEFAULT ((0)),
  [LengthMinimum]                       DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [LengthMaximum]                       DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [WidthMinimum]                        DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [WidthMaximum]                        DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [HeightMinimum]                       DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [HeightMaximum]                       DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [Orientation]                         SMALLINT          NOT NULL  DEFAULT ((0)),
  [Dip]                                 SMALLINT          NOT NULL  DEFAULT ((0)),
  [Remarks]                             NVARCHAR(1000)    NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionInstallationMaterial] (
  [ID]                                UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionInstallationID]    UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionInstallationID]) REFERENCES [LocusDescriptionInstallation]([ID]),
  [ArchitecturalMaterialID]           TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionInstallationMaterial_LocusDescriptionInstallationID_ArchitecturalMaterialID]
      UNIQUE([LocusDescriptionInstallationID], [ArchitecturalMaterialID])
    FOREIGN KEY ([ArchitecturalMaterialID]) REFERENCES [LstArchitecturalMaterial]([ID]),
  [ArchitecturalMaterialQualifierID]  TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ArchitecturalMaterialQualifierID]) REFERENCES [LstArchitecturalMaterialQualifier]([ID]),
  [Percentage]                        TINYINT           NOT NULL  DEFAULT ((0)),
  [Remarks]                           NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionInstallationMasonry] (
  [ID]                              UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionInstallationID]  UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionInstallationID]) REFERENCES [LocusDescriptionInstallation]([ID]),
  [ArchitecturalMasonryID]          TINYINT           NOT NULL  DEFAULT ((0))
    FOREIGN KEY ([ArchitecturalMasonryID]) REFERENCES [LstArchitecturalMasonry]([ID]),
  [ArchitecturalMasonryStonesID]    TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionInstallationMasonry_LocusDescriptionInstallationID_ArchitecturalMasonryID]
      UNIQUE([LocusDescriptionInstallationID], [ArchitecturalMasonryID], [ArchitecturalMasonryStonesID])
    FOREIGN KEY ([ArchitecturalMasonryStonesID]) REFERENCES [LstArchitecturalMasonryStones]([ID]),
  [BrickLengthMinimum]              DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [BrickLengthMaximum]              DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [BrickWidthMinimum]               DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [BrickWidthMaximum]               DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [BrickHeightMinimum]              DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [BrickHeightMaximum]              DECIMAL(4,3)      NOT NULL  DEFAULT ((0.000)),
  [Percentage]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [Remarks]                         NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionInstallationDressing] (
  [ID]                              UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionInstallationID]  UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionInstallationID]) REFERENCES [LocusDescriptionInstallation]([ID]),
  [ArchitecturalDressingID]         TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionInstallationMaterial_LocusDescriptionInstallationID_ArchitecturalDressingID]
      UNIQUE([LocusDescriptionInstallationID], [ArchitecturalDressingID])
    FOREIGN KEY ([ArchitecturalDressingID]) REFERENCES [LstArchitecturalDressing]([ID]),
  [Percentage]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [Remarks]                         NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionInstallationMortar] (
  [ID]                              UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionInstallationID]  UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionInstallationID]) REFERENCES [LocusDescriptionInstallation]([ID]),
  [ArchitecturalMortarID]           TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionInstallationMaterial_LocusDescriptionInstallationID_ArchitecturalMortarID]
      UNIQUE([LocusDescriptionInstallationID], [ArchitecturalMortarID])
    FOREIGN KEY ([ArchitecturalMortarID]) REFERENCES [LstArchitecturalMortar]([ID]),
  [Percentage]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [Remarks]                         NVARCHAR(250)     NOT NULL  DEFAULT ('')
)

CREATE TABLE dbo.[LocusDescriptionInstallationFacing] (
  [ID]                              UNIQUEIDENTIFIER  NOT NULL  DEFAULT NEWID() PRIMARY KEY CLUSTERED,
  [LocusDescriptionInstallationID]  UNIQUEIDENTIFIER  NOT NULL
    FOREIGN KEY ([LocusDescriptionInstallationID]) REFERENCES [LocusDescriptionInstallation]([ID]),
  [ArchitecturalFacingID]           TINYINT           NOT NULL  DEFAULT ((0))
    CONSTRAINT [UQ_LocusDescriptionInstallationMaterial_LocusDescriptionInstallationID_ArchitecturalFacingID]
      UNIQUE([LocusDescriptionInstallationID], [ArchitecturalFacingID])
    FOREIGN KEY ([ArchitecturalFacingID]) REFERENCES [LstArchitecturalFacing]([ID]),
  [Percentage]                      TINYINT           NOT NULL  DEFAULT ((0)),
  [Remarks]                         NVARCHAR(250)     NOT NULL  DEFAULT ('')
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