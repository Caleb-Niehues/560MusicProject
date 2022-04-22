CREATE OR ALTER PROCEDURE MusicProject.RetrieveArtists
AS

SELECT A.ArtistID, A.ArtistName
FROM MusicProject.Artist A;
GO