USE Archaeology
GO

/*
* 
* Fill Integration Test expectations for each table
* 
*/

-- INSERT INTO [Site]
-- VALUES ('29b6d07b-6eb9-473f-b4b5-8447468f3737', 'Test', 'Tel Test', 'First Expedition to Tel Test')
SELECT * FROM [Site]

-- INSERT INTO [Area]
-- VALUES ('b902fcba-a701-425d-a694-ae9505d366eb', '29b6d07b-6eb9-473f-b4b5-8447468f3737', 'AA', 'Integration Test with Area AA in Site Tel Test')
SELECT * FROM [Area]

-- INSERT INTO [Team]
-- VALUES ('39742ce2-283a-47dd-920b-f32942102c94', 'Testing Team')
SELECT * FROM [Team]

-- INSERT INTO [AscAreaTeam]
-- VALUES ('45f62266-ad11-4d58-afc1-88403da0ac88', 'b902fcba-a701-425d-a694-ae9505d366eb', '39742ce2-283a-47dd-920b-f32942102c94')
SELECT * FROM [AscAreaTeam]

-- INSERT INTO [Supervisor]
-- VALUES ('537383c4-59e3-44af-a264-ed3d3b58f876', 'Cherie Lynn', '', 'Olsen', 'CLO', 'cherielynnolsen@southern.edu', '39742ce2-283a-47dd-920b-f32942102c94')
SELECT * FROM [Supervisor]

-- INSERT INTO [Square]
-- VALUES ('550f69a7-10c9-44f1-846d-e7484188cdca', 'b902fcba-a701-425d-a694-ae9505d366eb', 'Ab123', '537383c4-59e3-44af-a264-ed3d3b58f876', null)
SELECT * FROM [Square]

-- INSERT INTO [Locus]
-- VALUES ('21385a91-ef2e-494d-8c0b-50fddcf322c0', '550f69a7-10c9-44f1-846d-e7484188cdca', 77, '2011-06-08', null, 'Started something new', 'She was beautiful', 1, 'Still working out the funciton', 'The stratigraphy just continues to grow', 1, 'IA2', 'Phase?', 'Seven')
SELECT * FROM [Locus]

-- INSERT INTO [GeospatialData]
-- VALUES ('17cd91d4-d1fb-4ac9-96e3-83e661e4ff00', 7777, NULL, NULL, NULL)
SELECT * FROM [GeospatialData]

-- INSERT INTO [Object]
-- VALUES ('c4ceff30-11c0-450c-9eb5-333982648af4', '21385a91-ef2e-494d-8c0b-50fddcf322c0', 123, '2011-07-04', '17cd91d4-d1fb-4ac9-96e3-83e661e4ff00', 1, 0, 'Cultic Object')
SELECT * FROM [Object]

-- INSERT INTO [PotteryBucket]
-- VALUES ('46457623-dcb4-4e69-8c2a-a6d03430b62f', '21385a91-ef2e-494d-8c0b-50fddcf322c0', 122, '2011-07-04', '17cd91d4-d1fb-4ac9-96e3-83e661e4ff00', 55, 3, 4, 2, 1, 'IA2B, Restorable, AK')
SELECT * FROM [PotteryBucket]