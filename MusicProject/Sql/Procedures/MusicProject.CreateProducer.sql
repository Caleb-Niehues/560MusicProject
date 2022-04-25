CREATE OR ALTER PROCEDURE MusicProject.CreateProducer
   @Name NVARCHAR(32)
AS

INSERT MusicProject.Producer(ProducerName)
VALUES (@Name)

GO
