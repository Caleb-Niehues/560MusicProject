﻿CREATE OR ALTER PROCEDURE MusicProject.FetchReview
   @UserName NVARCHAR(32),
   @AlbumTitle NVARCHAR(32)
AS

SELECT TOP(1) U.UserName, A.AlbumTitle, R.AlbumComment, R.AlbumRating--, R.DateAdded
FROM MusicProject.Review R
	INNER JOIN MusicProject.Album A ON A.AlbumID = R.AlbumID
	INNER JOIN MusicProject.[User] U ON U.UserID = R.UserID
WHERE U.UserName = @UserName AND A.AlbumTitle = @AlbumTitle

GO