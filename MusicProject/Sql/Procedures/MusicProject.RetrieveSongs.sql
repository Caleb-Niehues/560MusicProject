CREATE OR ALTER PROCEDURE MusicProject.RetrieveSongs
   @Name NVARCHAR(64)
AS

SELECT A.AlbumTitle, S.SongName, Ar.ArtistName, G.GenreName, S.[Length]
FROM MusicProject.Album A
INNER JOIN MusicProject.Artist Ar ON Ar.ArtistID = A.ArtistID
INNER JOIN MusicProject.Song S ON S.AlbumID = A.AlbumID
INNER JOIN MusicProject.Genre G ON G.GenreID = S.GenreID
WHERE A.AlbumTitle = @Name;

GO