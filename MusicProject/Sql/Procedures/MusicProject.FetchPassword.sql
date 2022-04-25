CREATE OR ALTER PROCEDURE MusicProject.FetchPassword
	@Name NVARCHAR(32)
AS

SELECT U.[Password]
FROM MusicProject.[User] U
WHERE U.UserName = @Name
GO