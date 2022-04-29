CREATE OR ALTER PROCEDURE MusicProject.AddArtist
   @ArtistName NVARCHAR(128)
AS

INSERT MusicProject.Artist(ArtistName)
VALUES(@ArtistName);
GO