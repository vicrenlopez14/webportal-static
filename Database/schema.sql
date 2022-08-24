DROP DATABASE IF EXISTS ProFind;
CREATE DATABASE ProFind;
USE ProFind;

################################################

CREATE TABLE Client
(
    IdC       CHAR(21) PRIMARY KEY,
    NameC     VARCHAR(50),
    EmailC    VARCHAR(50),
    PasswordC CHAR(64),
    PictureC  LONGBLOB
);

SELECT *
FROM Client;

DESCRIBE Client;

###########################################
CREATE TABLE `Rank`
(
    IdR   INT AUTO_INCREMENT PRIMARY KEY,
    NameR VARCHAR(50) UNIQUE
);

DESCRIBE `Rank`;

INSERT INTO `Rank` (NameR)
VALUES ('Principal'),
       ('Administrator');

SELECT *
FROM `Rank`;

###########################################
CREATE TABLE Admin
(
    IdA       CHAR(21) PRIMARY KEY,
    NameA     VARCHAR(50),
    EmailA    VARCHAR(50),
    TelA      VARCHAR(15),
    PasswordA CHAR(64),
    PictureA  LONGBLOB,
    IdR1      CHAR(21),
    FULLTEXT (NameA, EmailA, TelA),
    FOREIGN KEY (IdR1) REFERENCES `Rank` (IdR) ON DELETE CASCADE
);

DESCRIBE ADMIN;

SELECT *
FROM Admin;

###############################################
CREATE TABLE Tag
(
    IdT   CHAR(21) PRIMARY KEY,
    NameT VARCHAR(50),
    IdPJ1 CHAR(21),

    FOREIGN KEY (IdPJ1) REFERENCES Project (IdPJ) ON DELETE CASCADE
);

DESCRIBE Tag;

################################################
CREATE TABLE Department
(
    IdDP   INT AUTO_INCREMENT PRIMARY KEY,
    NameDP VARCHAR(30)
);

INSERT INTO Department (NameDP)
VALUES ('Ahuachapán'),
       ('Cabañas'),
       ('Chalatenango'),
       ('Cuscatlán'),
       ('La Libertad'),
       ('Morazán'),
       ('La Paz'),
       ('Santa Ana'),
       ('San Miguel'),
       ('San Salvador'),
       ('San Vicente'),
       ('Sonsonate'),
       ('La Unión'),
       ('Usulután');

SELECT *
FROM Department;
################################################

CREATE TABLE Professional
(
    IdP         CHAR(21) PRIMARY KEY,
    NameP       CHAR(50),
    DateBirthP  DATE,
    EmailP      CHAR(21),
    PasswordP   CHAR(64),
    ActiveP     BOOLEAN,
    SexP        BOOLEAN,
    DUIP        VARCHAR(15),
    AFPP        VARCHAR(50),
    ISSSP       VARCHAR(50),
    ZipCodeP    VARCHAR(10),
    SalaryP     FLOAT,
    HiringDateP DATE,
    PictureP    LONGBLOB,
    CurriculumP LONGBLOB,
    IdPFS1      INT,
    IdDP1       INT,
    IdWDT1      INT,
    FOREIGN KEY (IdPFS1) REFERENCES Profession (IdPFS) ON DELETE CASCADE,
    FOREIGN KEY (IdDP1) REFERENCES Department (IdDP) ON DELETE CASCADE,
    FOREIGN KEY (IdWDT1) REFERENCES WorkDayType (IdWDT) ON DELETE CASCADE
);
SELECT *
FROM Professional;
###############################################
CREATE TABLE WorkDayType
(
    IdWDT   INT AUTO_INCREMENT PRIMARY KEY,
    NameWDT VARCHAR(25)
);

INSERT INTO WorkDayType (NameWDT)
VALUES ('Diurnal'),
       ('Nocturnal');

SELECT *
FROM WorkDayType;

###############################################
CREATE TABLE ProjectStatus
(
    IdPS   INT AUTO_INCREMENT PRIMARY KEY,
    NamePS VARCHAR(20)
);

INSERT INTO ProjectStatus (NamePS)
VALUES ('Inactive'),
       ('Active');

SELECT *
FROM ProjectStatus;

###############################################
CREATE TABLE Project
(
    IdPJ          CHAR(21) PRIMARY KEY,
    TitlePJ       VARCHAR(50),
    DescriptionPJ VARCHAR(50),
    PicturePJ     LONGBLOB,
    TotalPricePJ  FLOAT,
    IdPS1         INT,
    IdP1          CHAR(21),
    IdC1          CHAR(21),
    FOREIGN KEY (IdPS1) REFERENCES ProjectStatus (IdPS) ON DELETE CASCADE,
    FOREIGN KEY (IdP1) REFERENCES Professional (IdP) ON DELETE CASCADE,
    FOREIGN KEY (IdC1) REFERENCES Client (IdC) ON DELETE CASCADE
);

DESCRIBE Project;

SELECT *
FROM Project;
################################################
CREATE TABLE Activity
(
    IdA            CHAR(21) PRIMARY KEY,
    TitleA         VARCHAR(50),
    DescriptionA   VARCHAR(500),
    ExpectedBeginA DATE,
    ExpectedEndA   DATE,
    PictureA       LONGBLOB,
    IdPJ1          CHAR(21),
    IdT1           CHAR(21),
    FOREIGN KEY (IdPJ1) REFERENCES Project (IdPJ) ON DELETE CASCADE,
    FOREIGN KEY (IdT1) REFERENCES Tag (IdT) ON DELETE CASCADE
);

SELECT *
FROM Activity;

################################################
CREATE TABLE Profession
(
    IdPFS   INT AUTO_INCREMENT PRIMARY KEY,
    NamePFS VARCHAR(50)
);

INSERT INTO Profession (NamePFS)
VALUES ('Law firm'),
       ('Automotive services'),
       ('General medicine');

################################################

CREATE TABLE Notification
(
    IdN             CHAR(21) PRIMARY KEY,
    TitleN          VARCHAR(50),
    DescriptionN    VARCHAR(500),
    DateTimeIssuedN DATE,
    PictureN        LONGBLOB,
    IdPJ2           CHAR(21),
    FOREIGN KEY (IdPJ2) REFERENCES Project (IdPJ) ON DELETE CASCADE
);
