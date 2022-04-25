CREATE OR ALTER PROCEDURE MusicProject.CreateSong
   @Name NVARCHAR(32),
   @Album NVARCHAR(32),
   @Genre NVARCHAR(32),
   @Length TIME, 
   @TrackNumber INT
AS

INSERT MusicProject.Song(SongName, AlbumID, GenreID, [Length], TrackNumber)
SELECT S.SongName, A.AlbumID, G.GenreID, S.[Length], S.TrackNumber
FROM
	(
		VALUES
			(@Name, @Album,	@Genre, @Length, @TrackNumber))
			S(SongName, AlbumName, GenreName, [Length], TrackNumber)
INNER JOIN MusicProject.Album A ON A.AlbumTitle = S.AlbumName
INNER JOIN MusicProject.Genre G ON G.GenreName = S.GenreName; 

GO
