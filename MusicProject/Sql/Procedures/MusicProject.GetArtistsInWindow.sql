CREATE OR ALTER PROCEDURE MusicProject.GetArtistsInWindow
   @LabelName NVARCHAR(128),
   @StartYear DATE,
   @EndYear DATE
AS

SELECT A.ArtistName
FROM MusicProject.Artist A
INNER JOIN MusicProject.Album Al ON Al.ArtistID = A.ArtistID
INNER JOIN MusicProject.RecordLabel R ON R.RecordLabelID = Al.RecordLabelID
WHERE R.RecordLabelName = @LabelName AND 
	Al.ReleaseDate >= @StartYear AND
	Al.ReleaseDate <= @EndYear;

GO