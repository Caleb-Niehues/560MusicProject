--creates/adds an artist
CREATE OR ALTER PROCEDURE MusicProject.AddArtist
   @ArtistName NVARCHAR(128)
AS

INSERT MusicProject.Artist(ArtistName)
VALUES(@ArtistName);
GO

--creates an album
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

--creates a producer
CREATE OR ALTER PROCEDURE MusicProject.CreateProducer
   @Name NVARCHAR(128)
AS
MERGE MusicProject.Producer P
USING (VALUES (@Name)) NEW(ProducerName)
	ON New.ProducerName = P.ProducerName
WHEN NOT MATCHED THEN
	INSERT (ProducerName)
	VALUES (@Name);
GO

--creates a record label
CREATE OR ALTER PROCEDURE MusicProject.CreateRecordLabel
   @Name NVARCHAR(128),
   @DateFounded DATE,
   @DateClosed DATE,
   @Location NVARCHAR(64)
AS
INSERT MusicProject.RecordLabel(RecordLabelName, DateFounded, DateClosed, RecordLabelLocation)
SELECT R.RecordLabelName, R.DateFounded, R.DateClosed, R.RecordLabelLocation
FROM
	(
		VALUES
			(@Name, @DateFounded, @DateFounded, @Location))
			R(RecordLabelName, DateFounded, DateClosed, RecordLabelLocation)

GO

--creates a review
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

--creates a song
CREATE OR ALTER PROCEDURE MusicProject.CreateSong
   @SongName NVARCHAR(64),
   @AlbumName NVARCHAR(128),
   @GenreName NVARCHAR(64),
   @Length TIME, 
   @TrackNumber INT
AS

INSERT MusicProject.Song(SongName, AlbumID, GenreID, [Length], TrackNumber)
SELECT S.SongName, A.AlbumID, G.GenreID, S.[Length], S.TrackNumber
FROM
	(
		VALUES
			(@SongName, @AlbumName,	@GenreName, @Length, @TrackNumber))
			S(SongName, AlbumName, GenreName, [Length], TrackNumber)
INNER JOIN MusicProject.Album A ON A.AlbumTitle = S.AlbumName
INNER JOIN MusicProject.Genre G ON G.GenreName = S.GenreName; 

GO

--creates a user
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

--deletes a user
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

--fetches the album from the database
CREATE OR ALTER PROCEDURE MusicProject.FetchAlbum
   @Name NVARCHAR(128)
AS

SELECT A.AlbumTitle, A.ReleaseDate, Ar.ArtistName, S.SongName,
	S.[Length], P.ProducerName, R.RecordLabelName, C.CertificationName, 
	G.GenreName, R.DateFounded, R.DateClosed, R.RecordLabelLocation
FROM MusicProject.Album A
INNER JOIN MusicProject.Artist Ar ON Ar.ArtistID = A.ArtistID
INNER JOIN MusicProject.Song S ON S.AlbumID = A.AlbumID
INNER JOIN MusicProject.ProducerAlbum Pa ON Pa.AlbumID = A.AlbumID
INNER JOIN MusicProject.Producer P ON P.ProducerID = Pa.ProducerID
INNER JOIN MusicProject.RecordLabel R ON R.RecordLabelID = A.RecordLabelID
INNER JOIN MusicProject.Certification C ON C.CertificationID = A.CertificationID
INNER JOIN MusicProject.Genre G ON G.GenreID = S.GenreID
WHERE A.AlbumTitle = @Name;

GO

--fetches the artist from the database
CREATE OR ALTER PROCEDURE MusicProject.FetchArtist
   @Name NVARCHAR(128)
AS

SELECT Ar.ArtistName
FROM MusicProject.Artist Ar
WHERE Ar.ArtistName = @Name;

GO

--feteches the password from the database
CREATE OR ALTER PROCEDURE MusicProject.FetchPassword
	@Name NVARCHAR(32)
AS

SELECT U.[Password]
FROM MusicProject.[User] U
WHERE U.UserName = @Name
GO

--fetches the producer from the database
CREATE OR ALTER PROCEDURE MusicProject.FetchProducer
   @Name NVARCHAR(128)
AS

SELECT P.ProducerName
FROM MusicProject.Producer P
WHERE P.ProducerName = @Name;

GO

--fetches the record label from the database
CREATE OR ALTER PROCEDURE MusicProject.FetchRecordLabel
   @Name NVARCHAR(128)
AS

SELECT R.RecordLabelName, R.DateFounded AS DateFounded,
	R.DateClosed AS DateClosed, R.RecordLabelLocation
FROM MusicProject.RecordLabel R
WHERE R.RecordLabelName = @Name;

GO

--fetches the reviews from the database
CREATE OR ALTER PROCEDURE MusicProject.FetchReview
   @UserName NVARCHAR(32)
AS

SELECT U.UserName, A.AlbumTitle, R.AlbumComment, R.AlbumRating--, R.DateAdded
FROM MusicProject.Review R
	INNER JOIN MusicProject.Album A ON A.AlbumID = R.AlbumID
	INNER JOIN MusicProject.[User] U ON U.UserID = R.UserID
WHERE U.UserName = @UserName

GO

--fetches the song from the database
CREATE OR ALTER PROCEDURE MusicProject.FetchSong
   @Name NVARCHAR(32)
AS

SELECT S.SongName, A.AlbumTitle, Ar.ArtistName, G.GenreName, S.[Length]
FROM MusicProject.Song S
INNER JOIN MusicProject.Album A ON A.AlbumID = S.AlbumID
INNER JOIN MusicProject.Artist Ar ON Ar.ArtistID = A.ArtistID
INNER JOIN MusicProject.Genre G ON G.GenreID = S.GenreID
WHERE S.SongName = @Name;

GO

--fetches the user from the database
CREATE OR ALTER PROCEDURE MusicProject.FetchUser
	@Name NVARCHAR(32)
AS

SELECT U.UserWeight, U.DateAdded
FROM MusicProject.[User] U
WHERE U.UserName = @Name AND U.DateDeleted IS NULL
GO

--gets an album from the record label
CREATE OR ALTER PROCEDURE MusicProject.GetAlbumsWithRecordLabel
   @StartYear DATE,
   @EndYear DATE,
   @RecordLabelName NVARCHAR(128)
AS

SELECT R.RecordLabelName, 
	COUNT(DISTINCT A.AlbumID) AS AlbumCount, 
	SUM(IIF(C.CertificationName != 'None', 1, 0)) AS CertificationCount
FROM MusicProject.RecordLabel R
	INNER JOIN MusicProject.Album A ON A.RecordLabelID = R.RecordLabelID
	INNER JOIN MusicProject.Certification C ON C.CertificationID = A.CertificationID
WHERE R.RecordLabelName = @RecordLabelName AND A.ReleaseDate BETWEEN @StartYear AND @EndYear
GROUP BY R.RecordLabelName

GO
--EXEC MusicProject.GetRecordLabelsAlbums @StartYear = '1950', @EndYear = '1970', @RecordLabelName = 'Justo Institute'

--gets artists in the same window
CREATE OR ALTER PROCEDURE MusicProject.GetArtistsInWindow
   @LabelName NVARCHAR(128),
   @StartYear DATE,
   @EndYear DATE
AS

SELECT A.ArtistName
FROM MusicProject.Artist A
INNER JOIN MusicProject.Album Al ON Al.ArtistID = A.ArtistID
INNER JOIN MusicProject.RecordLabel R ON R.RecordLabelID = Al.RecordLabelID
WHERE R.RecordLabelName = @LabelName AND 
	Al.ReleaseDate >= @StartYear AND
	Al.ReleaseDate <= @EndYear;

GO

--retrieves an artist
CREATE OR ALTER PROCEDURE MusicProject.RetrieveArtists
AS

SELECT A.ArtistID, A.ArtistName
FROM MusicProject.Artist A;
GO

--retrives a review
CREATE OR ALTER PROCEDURE MusicProject.RetrieveReviewsByAlbum
	@AlbumTitle NVARCHAR(128)
AS

SELECT U.UserName, A.AlbumTitle, R.AlbumComment, R.AlbumRating--, R.DateAdded
FROM MusicProject.Review R
	INNER JOIN MusicProject.Album A ON A.AlbumID = R.AlbumID
	INNER JOIN MusicProject.[User] U ON U.UserID = R.UserID
WHERE A.AlbumTitle = @AlbumTitle
GO

--retrieves a song
CREATE OR ALTER PROCEDURE MusicProject.RetrieveSongs
   @Name NVARCHAR(64)
AS

SELECT A.AlbumTitle, S.SongName, Ar.ArtistName, G.GenreName, S.[Length]
FROM MusicProject.Album A
INNER JOIN MusicProject.Artist Ar ON Ar.ArtistID = A.ArtistID
INNER JOIN MusicProject.Song S ON S.AlbumID = A.AlbumID
INNER JOIN MusicProject.Genre G ON G.GenreID = S.GenreID
WHERE A.AlbumTitle = @Name;

GO

--Returns a list of Users for a given artist's super fans. 
--Calculated by multiplying the user's weight and number of 
--comments they left for that artist's albums.
CREATE OR ALTER PROCEDURE MusicProject.RetrieveSuperFans
   @ArtistName NVARCHAR(128)
AS

SELECT U.UserID,
	   U.UserName,
	   (U.UserWeight*COUNT(R.AlbumComment)) AS UserScore, 
	   U.UserWeight, 
	   COUNT(R.AlbumComment) AS CommentCount
FROM MusicProject.Review R
INNER JOIN MusicProject.[User] U ON U.UserID = R.UserID
INNER JOIN MusicProject.Album A ON A.AlbumID = R.AlbumID
INNER JOIN MusicProject.Artist Ar ON Ar.ArtistID = A.ArtistID
WHERE Ar.ArtistID IN 
	(
		SELECT Ar.ArtistID
		FROM MusicProject.Artist Ar
		WHERE Ar.ArtistName = @ArtistName
	)
GROUP BY U.UserID, U.UserName, U.UserWeight
ORDER BY UserScore DESC
GO

--saves the review
CREATE OR ALTER PROCEDURE MusicProject.SaveReview
   @UserName NVARCHAR(32),
   @AlbumName NVARCHAR(128),
   @Comment NVARCHAR(400),
   @Rating DECIMAL
AS

WITH CTE (ReviewID, UserID, AlbumID) AS (
	SELECT R.ReviewID, U.UserID, A.AlbumID
	FROM MusicProject.Review R
		INNER JOIN MusicProject.[User] U ON U.UserID = R.UserID
		INNER JOIN MusicProject.Album A ON A.AlbumID = R.AlbumID
	WHERE U.UserName = @UserName AND A.AlbumTitle = @AlbumName
)

MERGE MusicProject.Review R
USING CTE ON CTE.ReviewID = R.ReviewID AND CTE.AlbumID = R.AlbumID AND CTE.UserID = R.UserID
WHEN MATCHED THEN
	UPDATE SET
		R.AlbumComment = @Comment,
		R.AlbumRating = @Rating;

GO

--Gets the best performing album(s) of a given artist. That is,
--an album that has received at least a Platinum Certification
--and has an average rating from users of at least 3.0.
CREATE OR ALTER PROCEDURE MusicProject.TopPerformingAlbums
   @ArtistName NVARCHAR(128)
AS

SELECT Ar.ArtistName, A.AlbumTitle,
	SUM(R.AlbumRating)/COUNT(DISTINCT R.AlbumRating) AS AverageRating,
	C.CertificationName
FROM MusicProject.Album A
INNER JOIN MusicProject.Artist Ar ON Ar.ArtistID = A.ArtistID
INNER JOIN MusicProject.Review R ON R.AlbumID = A.AlbumID
INNER JOIN MusicProject.Certification C ON C.CertificationID = A.CertificationID
WHERE Ar.ArtistID IN 
	(
		SELECT Ar.ArtistID
		FROM MusicProject.Artist Ar
		WHERE Ar.ArtistName = @ArtistName
	)
		AND (C.CertificationName = 'Platinum' OR C.CertificationName = 'MultiPlatinum' OR
			C.CertificationName = 'Diamond')
GROUP BY Ar.ArtistName, A.AlbumTitle, C.CertificationName
HAVING SUM(R.AlbumRating)/COUNT(DISTINCT R.AlbumRating) >= 3.0
GO

 --Gets the given number of best performing genres of a given time frame 
 --based on the number of certifications the album earned.
CREATE OR ALTER PROCEDURE MusicProject.TopPerformingGenres
   @StartYear DATE,
   @EndYear DATE,
   @Filter INT
AS
DECLARE @TrackCount INT = (
	SELECT COUNT(S.SongID) AS TrackCount
	FROM MusicProject.Album A 
		INNER JOIN MusicProject.Song S ON S.AlbumID = A.AlbumID
);
WITH CTE(GenreID, GenrePercentage) AS (
	SELECT DISTINCT S.GenreID, ROUND(CAST(COUNT(S.SongID) AS FLOAT)/@TrackCount, 3) AS GenrePercentage
	From MusicProject.Album A 
		INNER JOIN MusicProject.Certification C ON C.CertificationID = A.CertificationID
		INNER JOIN MusicProject.Song S ON S.AlbumID = A.AlbumID
	GROUP BY S.GenreID
)
SELECT TOP(@Filter) WITH TIES CAST(SUM(Als.CertificationCount) AS FLOAT) AS GenreCertificationScore, G.GenreID, G.GenreName
FROM (
	SELECT A.AlbumID, A.AlbumTitle, 
		SUM(
			CASE
				WHEN C.CertificationName = 'Diamond' THEN 100 * CTE.GenrePercentage
				WHEN C.CertificationName = 'MultiPlatinum' THEN 10 * CTE.GenrePercentage
				WHEN C.CertificationName = 'Platinum' THEN 5 * CTE.GenrePercentage
				WHEN C.CertificationName = 'Gold' THEN 1 * CTE.GenrePercentage
				ELSE 0
			END
		) AS CertificationCount
	FROM MusicProject.Album A
		INNER JOIN MusicProject.Song S ON S.AlbumID = A.AlbumID
		INNER JOIN MusicProject.Genre G ON G.GenreID = S.GenreID
		INNER JOIN CTE ON CTE.GenreID = G.GenreID
		INNER JOIN MusicProject.Certification C ON C.CertificationID = A.CertificationID
	WHERE A.ReleaseDate BETWEEN @StartYear AND @EndYear
	GROUP BY A.AlbumID, A.AlbumTitle
) AS Als
INNER JOIN MusicProject.Song S ON S.AlbumID = Als.AlbumID
INNER JOIN MusicProject.Genre G ON G.GenreID = S.GenreID
GROUP BY G.GenreID, G.GenreName, Als.CertificationCount
ORDER BY CAST(SUM(Als.CertificationCount) AS FLOAT) DESC;

GO
--EXEC MusicProject.TopPerformingGenres @StartYear = '1990', @EndYear = '2020', @Filter = 3