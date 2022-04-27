CREATE OR ALTER PROCEDURE MusicProject.CreateArtist
   @ArtistName NVARCHAR(32)
AS

MERGE MusicProject.Artist A
USING (VALUES (@ArtistName)) NEW(ArtistName)
	ON NEW.ArtistName = A.ArtistName
WHEN NOT MATCHED THEN
	INSERT (ArtistName)
	VALUES(@ArtistName);

GO