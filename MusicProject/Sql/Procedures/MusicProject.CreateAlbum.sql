CREATE OR ALTER PROCEDURE MusicProject.CreateAlbum 
 @AlbumTitle NVARCHAR(128), @ReleaseDate DATE, @ArtistName NVARCHAR(128),
	@RecordLabelName NVARCHAR(128), @CertificationName NVARCHAR(64)
AS
DECLARE @ArtistID INT =
(
	SELECT A.ArtistID
	FROM MusicProject.Artist A
	WHERE A.ArtistName = @ArtistName
)
DECLARE @RecordLabelID INT =
(
	SELECT R.RecordLabelID
	FROM MusicProject.RecordLabel R
	WHERE R.RecordLabelName = @RecordLabelName
)
DECLARE @CertificationID INT =
(
	SELECT C.CertificationID
	FROM MusicProject.Certification C
	WHERE C.CertificationName = @CertificationName
)
INSERT MusicProject.Album(AlbumTitle, ReleaseDate, ArtistID, RecordLabelID, CertificationID)
VALUES (@AlbumTitle, @ReleaseDate, @ArtistID, @RecordLabelID, @CertificationID)
GO