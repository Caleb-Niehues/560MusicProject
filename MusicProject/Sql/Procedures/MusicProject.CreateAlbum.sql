CREATE OR ALTER PROCEDURE MusicProject.CreateAlbum 
 @AlbumTitle NVARCHAR(32), @ReleaseDate DATE, @ArtistName NVARCHAR(32),
	@RecordLabelName NVARCHAR(32), @CertificationName NVARCHAR(32)
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