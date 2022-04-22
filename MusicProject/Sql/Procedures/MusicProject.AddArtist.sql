CREATE OR ALTER PROCEDURE MusicProject.AddArtist
   @ArtistName NVARCHAR(32)
AS

INSERT MusicProject.Artist(ArtistName)
VALUES(@ArtistName);
GO