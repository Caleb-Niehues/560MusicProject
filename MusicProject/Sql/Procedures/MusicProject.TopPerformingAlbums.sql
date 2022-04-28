CREATE OR ALTER PROCEDURE MusicProject.TopPerformingAlbums
   @ArtistName NVARCHAR(128)
AS

SELECT Ar.ArtistName, A.AlbumTitle,
	SUM(R.AlbumRating)/COUNT(DISTINCT R.AlbumRating) AS AverageRating,
	C.CertificationName
FROM MusicProject.Album A
INNER JOIN MusicProject.Artist Ar ON Ar.ArtistID = A.ArtistID
INNER JOIN MusicProject.Review R ON R.AlbumID = A.AlbumID
INNER JOIN MusicProject.Certification C ON C.CertificationID = A.CertificationID
WHERE Ar.ArtistID IN 
	(
		SELECT Ar.ArtistID
		FROM MusicProject.Artist Ar
		WHERE Ar.ArtistName = @ArtistName
	)
		AND (C.CertificationName = 'Platinum' OR C.CertificationName = 'MultiPlatinum' OR
			C.CertificationName = 'Diamond')
GROUP BY Ar.ArtistName, A.AlbumTitle, C.CertificationName
HAVING SUM(R.AlbumRating)/COUNT(DISTINCT R.AlbumRating) >= 3.0
GO