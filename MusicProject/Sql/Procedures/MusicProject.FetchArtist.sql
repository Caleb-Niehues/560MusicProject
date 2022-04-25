CREATE OR ALTER PROCEDURE MusicProject.FetchArtist
   @Name NVARCHAR(32)
AS

SELECT Ar.ArtistName
FROM MusicProject.Artist Ar
WHERE Ar.ArtistName = @Name;

GO