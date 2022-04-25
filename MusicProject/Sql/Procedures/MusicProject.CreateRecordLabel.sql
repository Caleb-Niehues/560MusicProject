CREATE OR ALTER PROCEDURE MusicProject.CreateRecordLabel
   @Name NVARCHAR(32),
   @DateFounded DATE,
   @DateClosed DATE,
   @Location NVARCHAR(32)
AS
INSERT MusicProject.RecordLabel(RecordLabelName, DateFounded, DateClosed, RecordLabelLocation)
SELECT R.RecordLabelName, R.DateFounded, R.DateClosed, R.RecordLabelLocation
FROM
	(
		VALUES
			(@Name, @DateFounded, @DateFounded, @Location))
			R(RecordLabelName, DateFounded, DateClosed, RecordLabelLocation)

GO