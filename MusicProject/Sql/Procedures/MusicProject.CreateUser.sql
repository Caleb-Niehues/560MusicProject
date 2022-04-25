CREATE OR ALTER PROCEDURE MusicProject.CreateUser
   @Name NVARCHAR(32),
   @Password NVARCHAR(32),
   @Weight INT
AS

MERGE MusicProject.[User] U
USING (VALUES(@Name)) NEW (UserName)
	ON NEW.UserName = U.UserName AND U.DateDeleted <> NULL
--WHEN MATCHED THEN
	--IF(U.DateDeleted <> NULL) 
WHEN NOT MATCHED THEN
	INSERT (UserName, [Password], UserWeight, DateAdded, DateDeleted)
	VALUES (@Name, @Password, @Weight, SYSDATETIMEOFFSET(), NULL);

GO