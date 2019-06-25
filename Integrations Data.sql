USE Archaeology
GO

/*
* 
* Fill Integration Test expectations for each table
* 
*/

INSERT INTO [Site]
VALUES ('29b6d07b-6eb9-473f-b4b5-8447468f3737', 'Test', 'Tel Test', 'First Expedition to Tel Test')
SELECT * FROM [Site]