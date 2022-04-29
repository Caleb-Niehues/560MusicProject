CREATE OR ALTER PROCEDURE MusicProject.CreateSong
   @SongName NVARCHAR(64),
   @AlbumName NVARCHAR(128),
   @GenreName NVARCHAR(64),
   @Length TIME, 
   @TrackNumber INT
AS

INSERT MusicProject.Song(SongName, AlbumID, GenreID, [Length], TrackNumber)
SELECT S.SongName, A.AlbumID, G.GenreID, S.[Length], S.TrackNumber
FROM
	(
		VALUES
			(@SongName, @AlbumName,	@GenreName, @Length, @TrackNumber))
			S(SongName, AlbumName, GenreName, [Length], TrackNumber)
INNER JOIN MusicProject.Album A ON A.AlbumTitle = S.AlbumName
INNER JOIN MusicProject.Genre G ON G.GenreName = S.GenreName; 

GO
