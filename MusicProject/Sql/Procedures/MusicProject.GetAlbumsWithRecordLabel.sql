CREATE OR ALTER PROCEDURE MusicProject.GetAlbumsWithRecordLabel
   @StartYear DATE,
   @EndYear DATE,
   @RecordLabelName NVARCHAR(128)
AS

SELECT R.RecordLabelName, 
	COUNT(DISTINCT A.AlbumID) AS AlbumCount, 
	SUM(IIF(C.CertificationName != 'None', 1, 0)) AS CertificationCount
FROM MusicProject.RecordLabel R
	INNER JOIN MusicProject.Album A ON A.RecordLabelID = R.RecordLabelID
	INNER JOIN MusicProject.Certification C ON C.CertificationID = A.CertificationID
WHERE R.RecordLabelName = @RecordLabelName AND A.ReleaseDate BETWEEN @StartYear AND @EndYear
GROUP BY R.RecordLabelName

GO
EXEC MusicProject.GetRecordLabelsAlbums @StartYear = '1950', @EndYear = '1970', @RecordLabelName = 'Justo Institute'