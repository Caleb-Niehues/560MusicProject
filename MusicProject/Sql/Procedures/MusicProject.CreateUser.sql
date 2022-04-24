CREATE OR ALTER PROCEDURE MusicProject.CreateUser
   @Name NVARCHAR(32),
   @Password NVARCHAR(32),
   @Weight INT
AS

INSERT MusicProject.[User](UserName, [Password], UserWeight, DateAdded, DateDeleted)
VALUES(@Name,
	@Password,
	@Weight, 
	SYSDATETIMEOFFSET(),
	NULL
);

GO