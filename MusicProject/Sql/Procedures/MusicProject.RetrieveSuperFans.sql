CREATE OR ALTER PROCEDURE MusicProject.RetrieveSuperFans
   @ArtistName NVARCHAR(64)
AS

SELECT U.UserID,
	   U.UserName,
	   (U.UserWeight*COUNT(R.AlbumComment)) AS UserScore, 
	   U.UserWeight, 
	   COUNT(R.AlbumComment) AS CommentCount
FROM MusicProject.Review R
INNER JOIN MusicProject.[User] U ON U.UserID = R.UserID
INNER JOIN MusicProject.Album A ON A.AlbumID = R.AlbumID
INNER JOIN MusicProject.Artist Ar ON Ar.ArtistID = A.ArtistID
WHERE Ar.ArtistID IN 
	(
		SELECT Ar.ArtistID
		FROM MusicProject.Artist Ar
		WHERE Ar.ArtistName = @ArtistName
	)
GROUP BY U.UserID, U.UserName, U.UserWeight
ORDER BY UserScore DESC
GO