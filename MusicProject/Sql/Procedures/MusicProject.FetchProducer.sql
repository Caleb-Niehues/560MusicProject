CREATE OR ALTER PROCEDURE MusicProject.FetchProducer
   @Name NVARCHAR(32)
AS

SELECT P.ProducerName
FROM MusicProject.Producer P
WHERE P.ProducerName = @Name;

GO