CREATE OR ALTER PROCEDURE MusicProject.FetchRecordLabel
   @Name NVARCHAR(128)
AS

SELECT R.RecordLabelName, R.DateFounded AS DateFounded,
	R.DateClosed AS DateClosed, R.RecordLabelLocation
FROM MusicProject.RecordLabel R
WHERE R.RecordLabelName = @Name;

GO