CREATE OR ALTER PROCEDURE MusicProject.CreateSong
   @Name NVARCHAR(32),
   @Album NVARCHAR(32),
   @Genre NVARCHAR(32),
   @Length TIME, 
   @TrackNumber INT
AS

MERGE MusicProject.Song 

INSERT MusicProject.Song([Name], Album, Genre, [Length], TrackNumber)
VALUES(@Name,
	@Album,
	@Genre, 
	@Length,
	@TrackNumber
);
--NOT CORRECT!!!!