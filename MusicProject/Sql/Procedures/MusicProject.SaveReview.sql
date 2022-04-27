CREATE OR ALTER PROCEDURE MusicProject.SaveReview
   @UserName NVARCHAR(32),
   @AlbumName NVARCHAR(32),
   @Comment NVARCHAR(128),
   @Rating DECIMAL
AS

WITH CTE (ReviewID, UserID, AlbumID) AS (
	SELECT R.ReviewID, U.UserID, A.AlbumID
	FROM MusicProject.Review R
		INNER JOIN MusicProject.[User] U ON U.UserID = R.UserID
		INNER JOIN MusicProject.Album A ON A.AlbumID = R.AlbumID
	WHERE U.UserName = @UserName AND A.AlbumTitle = @AlbumName
)

MERGE MusicProject.Review R
USING CTE ON CTE.AlbumID = R.AlbumID AND CTE.UserID = R.UserID
WHEN MATCHED THEN
	UPDATE SET
		R.AlbumComment = @Comment,
		R.AlbumRating = @Rating;

GO