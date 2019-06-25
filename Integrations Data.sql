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