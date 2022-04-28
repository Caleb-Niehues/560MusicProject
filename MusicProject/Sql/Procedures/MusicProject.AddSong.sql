CREATE OR ALTER PROCEDURE MusicProject.CreateSong
   @Name NVARCHAR(64),
   @Album NVARCHAR(128),
   @Genre NVARCHAR(64),
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