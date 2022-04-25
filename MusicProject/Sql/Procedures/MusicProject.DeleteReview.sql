CREATE OR ALTER PROCEDURE MusicProject.DeleteReview
   @UserName NVARCHAR(32)
AS

WITH CTE (ReviewID) AS(
	SELECT R.ReviewID
	FROM MusicProject.Review R
	INNER JOIN MusicProject.[User] U ON U.UserID = R.UserID
	WHERE U.UserName = @UserName
)

MERGE MusicProject.Review R
USING CTE ON CTE.ReviewID = R.ReviewID
WHEN MATCHED THEN
	UPDATE SET
		DateDeleted = SYSDATETIMEOFFSET();
--WHEN NOT MATCHED THEN 
GO