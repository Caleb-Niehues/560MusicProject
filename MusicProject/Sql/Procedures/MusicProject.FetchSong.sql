CREATE OR ALTER PROCEDURE MusicProject.FetchSong
   @Name NVARCHAR(32)
AS

SELECT S.SongName, A.AlbumTitle, Ar.ArtistName, G.GenreName, S.[Length]
FROM MusicProject.Song S
INNER JOIN MusicProject.Album A ON A.AlbumID = S.AlbumID
INNER JOIN MusicProject.Artist Ar ON Ar.ArtistID = A.ArtistID
INNER JOIN MusicProject.Genre G ON G.GenreID = S.GenreID
WHERE S.SongName = @Name;

GO