CREATE OR ALTER PROCEDURE MusicProject.CreateReview
   @UserName NVARCHAR(32),
   @AlbumName NVARCHAR(32),
   @Comment NVARCHAR(128),
   @Rating DECIMAL
AS

INSERT MusicProject.Review(UserID, AlbumID, AlbumComment, AlbumRating, DateDeleted)

VALUES(
	(
		SELECT U.UserId
		FROM MusicProject.[User] U
		WHERE U.UserName = @UserName
	),
	(
		SELECT A.AlbumID
		FROM MusicProject.Album A
		WHERE A.AlbumTitle = @AlbumName
	),
	@Comment,
	@Rating, 
	--SYSDATETIMEOFFSET(),
	NULL
);

GO