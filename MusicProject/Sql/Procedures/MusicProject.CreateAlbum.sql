--Does not work

CREATE OR ALTER PROCEDURE MusicProject.CreateAlbum
	@AlbumTitle NVARCHAR(32),
	@ReleaseDate DATE,
	@ArtistName NVARCHAR(32),
	@RecordLabelName NVARCHAR(32),
	@CertificationName NVARCHAR(32)
    --@ProducerName NVARCHAR(32)
AS

WITH CTE(AlbumTitle, ReleaseDate, ArtistID, RecordLabelID, CertificationID) AS
	(
		SELECT C.AlbumTitle, C.ReleaseDate, Ar.ArtistID, R.RecordLabelID, Ce.CertificationID
		FROM
			(
				VALUES 
					(@AlbumTitle, @ReleaseDate, @ArtistName, @RecordLabelName, @CertificationName)
			) C(AlbumTitle, ReleaseDate, ArtistName, RecordLabelName, CertificationName)
			INNER JOIN MusicProject.Artist Ar ON Ar.ArtistName = C.ArtistName
			INNER JOIN MusicProject.RecordLabel R ON R.RecordLabelName = C.RecordLabelName
			INNER JOIN MusicProject.Certification Ce ON Ce.CertificationName = C.CertificationName
	)
MERGE MusicProject.Album A
USING CTE ON CTE.AlbumTitle = A.AlbumTitle
	AND CTE.ArtistID = A.ArtistID
WHEN NOT MATCHED THEN
	INSERT(AlbumTitle, ReleaseDate, ArtistID, RecordLabelID, CertificationID)
	VALUES(CTE.AlbumTitle, CTE.ReleaseDate, CTE.ArtistID, CTE.RecordLabelID, CTE.CertificationID);
GO
--handle produceralbum relation

EXEC MusicProject.CreateAlbum @AlbumTitle = 'The Melodic Blue', @ReleaseDate = '2021-10-08',
	@ArtistName = 'Kanye West', @RecordLabelName = 'Eu Limited', @CertificationName = NULL

SELECT *
FROM MusicProject.Album A
WHERE A.AlbumTitle = 'The Melodic Blue';