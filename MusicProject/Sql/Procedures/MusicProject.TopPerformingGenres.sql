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


