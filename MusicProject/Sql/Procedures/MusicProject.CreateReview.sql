CREATE OR ALTER PROCEDURE MusicProject.CreateReview
	@UserName NVARCHAR(32),
	@AlbumName NVARCHAR(128),
	@Comment NVARCHAR(400),
	@Rating DECIMAL
AS
INSERT MusicProject.Review (UserID, AlbumID, AlbumComment, AlbumRating, DateDeleted)
	VALUES (
	(
		SELECT U.UserID
		FROM MusicProject.[User] U
		WHERE U.UserName = @UserName
	),
	(
		SELECT A.AlbumId
		FROM MusicProject.Album A
		WHERE A.AlbumTitle = @AlbumName
	),
	@Comment, @Rating, 
	--SYSDATETIMEOFFSET(),
	NULL
);

GO