CREATE OR ALTER PROCEDURE MusicProject.CreateUser
   @Name NVARCHAR(32),
   @Password NVARCHAR(32),
   @Weight INT
AS

MERGE MusicProject.[User] U
USING (VALUES(@Name)) NEW (UserName)
	ON NEW.UserName = U.UserName
WHEN NOT MATCHED THEN
	INSERT (UserName, [Password], UserWeight, DateAdded, DateDeleted)
	VALUES (@Name, @Password, @Weight, SYSDATETIMEOFFSET(), NULL)
WHEN MATCHED THEN UPDATE SET
	U.DateDeleted = NULL,
	U.UserWeight = @Weight;
GO