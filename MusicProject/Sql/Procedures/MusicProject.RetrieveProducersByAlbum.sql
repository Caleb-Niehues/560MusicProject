CREATE OR ALTER PROCEDURE MusicProject.RetrieveProducersByAlbum
	@AlbumTitle NVARCHAR(32)
AS
SELECT P.ProducerName
FROM MusicProject.Producer P
	INNER JOIN MusicProject.ProducerAlbum PA ON PA.ProducerID = P.ProducerID
	INNER JOIN MusicProject.Album A ON A.AlbumID = PA.AlbumID
WHERE A.AlbumTitle = @AlbumTitle

GO