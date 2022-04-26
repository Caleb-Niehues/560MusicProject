CREATE OR ALTER PROCEDURE MusicProject.FetchUser
	@Name NVARCHAR(32)
AS

SELECT U.UserWeight, U.DateAdded
FROM MusicProject.[User] U
WHERE U.UserName = @Name AND U.DateDeleted IS NULL
GO