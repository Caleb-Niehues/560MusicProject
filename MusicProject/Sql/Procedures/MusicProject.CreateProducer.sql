CREATE OR ALTER PROCEDURE MusicProject.CreateProducer
   @Name NVARCHAR(128)
AS
MERGE MusicProject.Producer P
USING (VALUES (@Name)) NEW(ProducerName)
	ON New.ProducerName = P.ProducerName
WHEN NOT MATCHED THEN
	INSERT (ProducerName)
	VALUES (@Name);


GO