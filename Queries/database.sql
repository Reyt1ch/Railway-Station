USE MASTER;
GO
DROP DATABASE IF EXISTS RailwayStationDB;
GO
CREATE DATABASE RailwayStationDB;
GO
USE RailwayStationDB;
GO

--TABLES

CREATE TABLE Destination (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	"name" VARCHAR(255) UNIQUE NOT NULL
);

GO

CREATE TABLE Race (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	destination INT FOREIGN KEY REFERENCES Destination(id) NOT NULL,
	numberOfSeatsClass1 INT NOT NULL,
	numberOfSeatsClass2 INT NOT NULL,
	numberOfSeatsClass3 INT NOT NULL,
	priceClass1 FLOAT NOT NULL,
	priceClass2 FLOAT NOT NULL,
	priceClass3 FLOAT NOT NULL
);

GO

CREATE TABLE "Day" (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	code CHAR UNIQUE NOT NULL
);

GO

INSERT INTO "Day" VALUES
	('M'),
	('T'),
	('W'),
	('R'),
	('F'),
	('S'),
	('U');

GO

CREATE TABLE Timetable (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	race INT FOREIGN KEY REFERENCES Race(id) NOT NULL,
	departingDay INT FOREIGN KEY REFERENCES "Day"(id) NOT NULL,
	departingTime TIME NOT NULL,
	arrivalDay INT FOREIGN KEY REFERENCES "Day"(id) NOT NULL,
	arrivalTime TIME NOT NULL
);

GO

CREATE TABLE Class (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	className VARCHAR(7) UNIQUE NOT NULL
);

GO

INSERT INTO Class VALUES
	('1 Class'),
	('2 Class'),
	('3 Class');

GO

CREATE TABLE Reservation (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	timetable INT FOREIGN KEY REFERENCES Timetable(id) NOT NULL,
	class INT FOREIGN KEY REFERENCES Class(id) NOT NULL,
	numberOfSeats INT
);

GO

CREATE TABLE CancelledRace (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	timetable INT FOREIGN KEY REFERENCES Timetable(id) NOT NULL
);

GO

DROP VIEW IF EXISTS task5view;

GO

CREATE VIEW task5view AS
SELECT d."name" AS Destination, dy.code AS DepartingDay, t.departingTime AS DepartingTime FROM Destination d
INNER JOIN Race r ON d.id = r.destination
INNER JOIN Timetable t ON r.id = t.race
INNER JOIN "Day" dy ON t.departingDay = dy.id
INNER JOIN "Day" da ON t.arrivalDay = da.id

GO

CREATE FUNCTION dbo.GetMaxTravelTime() 
RETURNS INT
AS
BEGIN
    DECLARE @maxTravelTime INT;
    
    SELECT @maxTravelTime = MAX(DATEDIFF(MINUTE, 
                                         DATEADD(DAY, CASE WHEN d1.code = 'M' THEN 0 WHEN d1.code = 'T' THEN 1 WHEN d1.code = 'W' THEN 2 WHEN d1.code = 'R' THEN 3 WHEN d1.code = 'F' THEN 4 WHEN d1.code = 'S' THEN 5 ELSE 6 END, '1900-01-01') + CAST(t1.departingTime AS DATETIME),
                                         DATEADD(DAY, CASE WHEN d2.code = 'M' THEN 0 WHEN d2.code = 'T' THEN 1 WHEN d2.code = 'W' THEN 2 WHEN d2.code = 'R' THEN 3 WHEN d2.code = 'F' THEN 4 WHEN d2.code = 'S' THEN 5 ELSE 6 END, '1900-01-01') + CAST(t2.arrivalTime AS DATETIME)
                                        ))
    FROM Timetable t1
    JOIN "Day" d1 ON d1.id = t1.departingDay
    JOIN Timetable t2 ON t2.id = t1.id
    JOIN "Day" d2 ON d2.id = t2.arrivalDay;

    RETURN @maxTravelTime;
END;


GO

DROP VIEW IF EXISTS task7view;

GO

CREATE VIEW task7view AS
SELECT d."name" as Destination, ((r.priceClass1 + r.priceClass2 + r.priceClass3) / 3) as AvgPrice FROM Race r
INNER JOIN Destination d ON d.id = r.destination

GO

CREATE VIEW task6view AS
SELECT TOP 1 d3.name as Destination, d1.code as DepartingDay, t1.departingTime as DepartingTime, (DATEDIFF(HOUR, 
                   DATEADD(DAY, CASE WHEN d1.code = 'M' THEN 0 WHEN d1.code = 'T' THEN 1 WHEN d1.code = 'W' THEN 2 WHEN d1.code = 'R' THEN 3 WHEN d1.code = 'F' THEN 4 WHEN d1.code = 'S' THEN 5 ELSE 6 END, '1900-01-01') + CAST(t1.departingTime AS DATETIME),
                   DATEADD(DAY, CASE WHEN d2.code = 'M' THEN 0 WHEN d2.code = 'T' THEN 1 WHEN d2.code = 'W' THEN 2 WHEN d2.code = 'R' THEN 3 WHEN d2.code = 'F' THEN 4 WHEN d2.code = 'S' THEN 5 ELSE 6 END, '1900-01-01') + CAST(t2.arrivalTime AS DATETIME)
                  )) AS travel_time
FROM Timetable t1
JOIN "Day" d1 ON d1.id = t1.departingDay
JOIN Timetable t2 ON t2.id = t1.id
JOIN "Day" d2 ON d2.id = t2.arrivalDay
JOIN Race r ON r.id = t1.race
JOIN Destination d3 ON d3.id = r.destination
ORDER BY (DATEDIFF(HOUR, 
                   DATEADD(DAY, CASE WHEN d1.code = 'M' THEN 0 WHEN d1.code = 'T' THEN 1 WHEN d1.code = 'W' THEN 2 WHEN d1.code = 'R' THEN 3 WHEN d1.code = 'F' THEN 4 WHEN d1.code = 'S' THEN 5 ELSE 6 END, '1900-01-01') + CAST(t1.departingTime AS DATETIME),
                   DATEADD(DAY, CASE WHEN d2.code = 'M' THEN 0 WHEN d2.code = 'T' THEN 1 WHEN d2.code = 'W' THEN 2 WHEN d2.code = 'R' THEN 3 WHEN d2.code = 'F' THEN 4 WHEN d2.code = 'S' THEN 5 ELSE 6 END, '1900-01-01') + CAST(t2.arrivalTime AS DATETIME)
                  )) desc;

GO

CREATE LOGIN Alexei
WITH PASSWORD = '123456';
GO
CREATE USER Alexei FOR LOGIN Alexei;