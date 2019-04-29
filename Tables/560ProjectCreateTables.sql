DROP TABLE IF EXISTS MovieInfo.Movie
DROP TABLE IF EXISTS MovieInfo.MovieDirector
DROP TABLE IF EXISTS MovieInfo.Director
DROP TABLE IF EXISTS MovieInfo.[Cast]
DROP TABLE IF EXISTS MovieInfo.Actor
DROP TABLE IF EXISTS MovieInfo.Genre
DROP TABLE IF EXISTS MovieInfo.MovieGenre
DROP TABLE IF EXISTS MovieInfo.Rating
DROP TABLE IF EXISTS MovieInfo.Reviewer


CREATE TABLE MovieInfo.Movie (
	MovieId int NOT NULL  PRIMARY KEY,
	MovieTitle NVARCHAR(64) NOT NULL ,
	ReleaseDate Date NOT NULL,
	[Language] NVARCHAR(3) NOT NULL,
	AllTimeBoxOffice bigint NOT NULL,
	Unique(MovieTitle, ReleaseDate)
)

CREATE TABLE MovieInfo.MovieDirector (
	DirectorId int NOT NULL,
	MovieId int NOT NULL
	PRIMARY KEY (DirectorId, MovieId)
)

CREATE TABLE MovieInfo.Director(
	DirectorId int NOT NULL PRIMARY KEY,
	FirstName NVARCHAR(32) NOT NULL,
	LastName NVARCHAR(64) NOT NULL
)

CREATE TABLE MovieInfo.[Cast] (
	ActorId int NOT NULL,
	MovieId int NOT NULL,
	[Role] NVARCHAR(64) NOT NULL
	PRIMARY KEY (ActorId, [Role], MovieId)
)

CREATE TABLE MovieInfo.Actor (
	ActorId int NOT NULL PRIMARY KEY,
	FirstName NVARCHAR(32) NOT NULL,
	LastName NVARCHAR (64) NOT NULL,
	Gender NVARCHAR(3) NOT NULL
)

CREATE TABLE MovieInfo.Genre (
	GenreId int NOT NULL PRIMARY KEY,
	GenreTitle NVARCHAR(32) NOT NULL
)

CREATE TABLE MovieInfo.MovieGenre (
	MovieId int NOT NULL,
	GenreId int NOT NULL
	PRIMARY KEY (MovieId, GenreId)
)

CREATE TABLE MovieInfo.Rating (
	MovieId int NOT NULL,
	ReviewerId int Identity(1,1) NOT NULL,
	ReviewerRating int NOT NULL,
	numberofRatings int NOT NULL,
	PRIMARY KEY (MovieId, ReviewerId)
)

CREATE TABLE MovieInfo.Reviewer (
	ReviewerId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ReviewerName NVARCHAR(128) NOT NULL
)
