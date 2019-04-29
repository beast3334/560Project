CREATE PROCEDURE MovieInfo.GET_HIGHEST_MOVIE_KEY
AS
Select MAX(MovieId)

FROM MovieInfo.Movie
GO


CREATE PROCEDURE MovieInfo.GET_ACTORS
AS
Select *

FROM MovieInfo.Actor
GO;

CREATE PROCEDURE MovieInfo.CHECK_IF_ACTOR_EXIST
@FIRSTNAME NVARCHAR(32),
@LASTNAME NVARCHAR(64)
AS
SELECT CASE WHEN EXISTS (
	SELECT * 
	FROM MovieInfo.Actor
	WHERE FirstName = @FIRSTNAME AND LastName = @LASTNAME
)
THEN CAST(1 as BIT)
ELSE CAST(0 AS BIT) END
GO;

CREATE PROCEDURE MovieInfo.GET_HIGHEST_ACTOR_KEY
AS
Select MAX(ActorId)
FROM MovieInfo.Actor
GO;

CREATE PROCEDURE MovieInfo.GET_ACTOR_ID
@FIRSTNAME NVARCHAR(32),
@LASTNAME NVARCHAR(64)
AS
Select ActorId
From MovieInfo.Actor
WHERE FirstName = @FIRSTNAME and LastName = @LASTNAME
GO;

CREATE PROCEDURE MovieInfo.CHECK_IF_DIRECTOR_EXISTS
@FIRSTNAME NVARCHAR(32),
@LASTNAME NVARCHAR (64)
AS
SELECT CASE WHEN EXISTS (
	SELECT * 
	FROM MovieInfo.Director
	WHERE FirstName = @FIRSTNAME AND LastName = @LASTNAME
)
THEN CAST(1 as BIT)
ELSE CAST(0 AS BIT) END
GO;

CREATE PROCEDURE MovieInfo.GET_HIGHEST_DIRECTOR_KEY
AS
Select MAX(DirectorId)
FROM MovieInfo.Director
GO;

CREATE PROCEDURE MovieInfo.GET_DIRECTOR_ID
@FIRSTNAME NVARCHAR(32),
@LASTNAME NVARCHAR(64)
AS
Select DirectorId
From MovieInfo.Director
WHERE FirstName = @FIRSTNAME and LastName = @LASTNAME
GO;

CREATE PROCEDURE MovieInfo.CHECK_IF_REVIEWER_EXISTS
@NAME NVARCHAR(128)
AS
SELECT CASE WHEN EXISTS (
	SELECT * 
	FROM MovieInfo.Reviewer
	WHERE ReviewerName = @NAME
)
THEN CAST(1 as BIT)
ELSE CAST(0 AS BIT) END
GO;

ALTER PROCEDURE MovieInfo.GET_REVIEWER_ID
@NAME NVARCHAR(128)
AS
SELECT ReviewerId
From MovieInfo.Reviewer
WHERE ReviewerName = @NAME
GO;

CREATE PROCEDURE MovieInfo.GET_REVIEW_COUNT
@MOVIEID int
AS
Select COUNT(*)
FROM MovieInfo.Rating
WHERE MovieId = @MOVIEID
GO

CREATE PROCEDURE MovieInfo.GET_GENRE_ID
@NAME NVARCHAR(32)
AS
Select GenreId
FROM MovieInfo.Genre
WHERE GenreTitle = @NAME;

CREATE PROCEDURE MovieInfo.GET_HIGHEST_REVIEWER_ID
AS
Select MAX(ReviewerId)
FROM MovieInfo.Reviewer
GO