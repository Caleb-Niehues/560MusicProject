CREATE OR ALTER PROCEDURE MusicProject.FetchRecordLabel
   @Name NVARCHAR(32)
AS

SELECT R.RecordLabelName, YEAR(R.DateFounded) AS DateFounded,
	YEAR(R.DateClosed) AS DateClosed, R.RecordLabelLocation
FROM MusicProject.RecordLabel R
WHERE R.RecordLabelName = @Name;

GO