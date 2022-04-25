CREATE OR ALTER PROCEDURE MusicProject.FetchAlbum
   @Name NVARCHAR(32)
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