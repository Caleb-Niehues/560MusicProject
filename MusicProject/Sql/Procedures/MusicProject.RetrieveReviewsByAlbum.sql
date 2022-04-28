﻿CREATE OR ALTER PROCEDURE MusicProject.RetrieveReviewsByAlbum
	@AlbumTitle NVARCHAR(128)
AS

SELECT U.UserName, A.AlbumTitle, R.AlbumComment, R.AlbumRating--, R.DateAdded
FROM MusicProject.Review R
	INNER JOIN MusicProject.Album A ON A.AlbumID = R.AlbumID
	INNER JOIN MusicProject.[User] U ON U.UserID = R.UserID
WHERE A.AlbumTitle = @AlbumTitle
GO