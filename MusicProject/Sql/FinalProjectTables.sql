USE [CalebNiehues]; -- Your database here.

IF SCHEMA_ID(N'MusicProject') IS NULL
  EXEC(N'CREATE SCHEMA [MusicProject];');

DROP TABLE IF EXISTS MusicProject.Review;
DROP TABLE IF EXISTS MusicProject.[User];
DROP TABLE IF EXISTS MusicProject.ProducerAlbum;
DROP TABLE IF EXISTS MusicProject.Song;
DROP TABLE IF EXISTS MusicProject.Album;
DROP TABLE IF EXISTS MusicProject.Certification;
DROP TABLE IF EXISTS MusicProject.Genre;
DROP TABLE IF EXISTS MusicProject.RecordLabel;
DROP TABLE IF EXISTS MusicProject.Producer;
DROP TABLE IF EXISTS MusicProject.ArtistPerson;
DROP TABLE IF EXISTS MusicProject.Artist;
DROP TABLE IF EXISTS MusicProject.Person;


CREATE TABLE MusicProject.Person
(
   PersonID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   PersonName NVARCHAR(64) NOT NULL,
   BirthDate DATE NOT NULL,
   DeathDate DATE,
   HomeRegion NVARCHAR(64) NOT NULL
);

CREATE TABLE MusicProject.Artist
(
   ArtistID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   ArtistName NVARCHAR(128) NOT NULL
);

CREATE TABLE MusicProject.ArtistPerson
(
   ArtistID INT NOT NULL FOREIGN KEY
		REFERENCES MusicProject.Artist(ArtistID),
   PersonID INT NOT NULL FOREIGN KEY
		REFERENCES MusicProject.Person(PersonID),

	PRIMARY KEY(ArtistID, PersonID)
);

CREATE TABLE MusicProject.Producer
(
   ProducerID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   ProducerName NVARCHAR(128) NOT NULL,
   --PersonID INT NOT NULL FOREIGN KEY
		--REFERENCES MusicProject.Person(PersonID)
);

CREATE TABLE MusicProject.RecordLabel
(
   RecordLabelID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   RecordLabelName NVARCHAR(128) NOT NULL,
   DateFounded DATE NOT NULL,
   DateClosed DATE,
   RecordLabelLocation NVARCHAR(64) NOT NULL

   UNIQUE (RecordLabelName)
);

CREATE TABLE MusicProject.Genre
(
   GenreID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   GenreName NVARCHAR(64) NOT NULL

   UNIQUE (GenreName)
);

CREATE TABLE MusicProject.Certification
(
   CertificationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   CertificationName NVARCHAR(64) NOT NULL

   UNIQUE (CertificationName)
);

CREATE TABLE MusicProject.Album
(
   AlbumID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   AlbumTitle NVARCHAR(128) NOT NULL,
   ReleaseDate DATE NOT NULL,
   ArtistID INT NOT NULL FOREIGN KEY
		REFERENCES MusicProject.Artist(ArtistID),
   RecordLabelID INT FOREIGN KEY
		REFERENCES MusicProject.RecordLabel(RecordLabelID),
   --ProducerID INT NOT NULL FOREIGN KEY
		--REFERENCES MusicProject.Producer(ProducerID),
   CertificationID INT FOREIGN KEY
		REFERENCES MusicProject.Certification(CertificationID)

   UNIQUE (AlbumTitle, ArtistID)
);

CREATE TABLE MusicProject.Song
(
   SongID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   SongName NVARCHAR(64) NOT NULL,
   AlbumID INT NOT NULL FOREIGN KEY 
		REFERENCES MusicProject.Album(AlbumID),
   GenreID INT NOT NULL FOREIGN KEY 
		REFERENCES MusicProject.Genre(GenreID),
   [Length] TIME NOT NULL,
   TrackNumber INT NOT NULL

   UNIQUE (SongName, AlbumID)
);

CREATE TABLE MusicProject.ProducerAlbum
(
   ProducerID INT NOT NULL FOREIGN KEY
		REFERENCES MusicProject.Producer(ProducerID),
   AlbumID INT NOT NULL FOREIGN KEY
		REFERENCES MusicProject.Album(AlbumID)

	PRIMARY KEY (ProducerID, AlbumID)
);

CREATE TABLE MusicProject.[User]
(
   UserID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   UserName NVARCHAR(32) NOT NULL,
   UserWeight INT NOT NULL,
   [Password] NVARCHAR(32) NOT NULL,
   DateAdded DATE NOT NULL,
   DateDeleted DATE

   UNIQUE (UserName)
);

CREATE TABLE MusicProject.Review
(
   ReviewID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
   UserID INT NOT NULL FOREIGN KEY 
		REFERENCES MusicProject.[User](UserID),
   AlbumID INT NOT NULL FOREIGN KEY 
		REFERENCES MusicProject.Album(AlbumID),
   AlbumComment NVARCHAR(400),
   AlbumRating DECIMAL(2,1) NOT NULL,
   DateAdded DATE NOT NULL,
   DateDeleted DATE
);