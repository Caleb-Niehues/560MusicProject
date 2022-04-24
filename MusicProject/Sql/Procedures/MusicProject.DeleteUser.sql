CREATE OR ALTER PROCEDURE MusicProject.DeleteUser
   @Name NVARCHAR(32),
   @Password NVARCHAR(32)
AS

MERGE MusicProject.[User] U
USING
	(
		VALUES(@Name, @Password)
	) S(UserName, [Password])
	ON S.UserName = U.UserName AND S.[Password] = U.[Password]
WHEN MATCHED THEN
	UPDATE SET
		DateDeleted = SYSDATETIMEOFFSET();
--WHEN NOT MATCHED THEN 
GO