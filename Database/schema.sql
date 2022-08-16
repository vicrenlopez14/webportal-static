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
    IdR   CHAR(21) PRIMARY KEY,
    NameR VARCHAR(50) UNIQUE
);

DESCRIBE `Rank`;

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
FROM ADMIN;


###############################################
CREATE TABLE Tag
(
    IdT   CHAR(21) PRIMARY KEY,
    NameT VARCHAR(50),
    IdPJ1 CHAR(21),

    FOREIGN KEY (IdPJ1) REFERENCES Project (IdPJ) ON DELETE CASCADE
);

DESCRIBE Tag;

###############################################
CREATE TABLE Process
(
    IdPR          CHAR(21) PRIMARY KEY,
    TitlePR       VARCHAR(50),
    DescriptionPR VARCHAR(350),
    BeginDatePR   DATETIME,
    IdT1          CHAR(21),
    EndDatePR     DATETIME,
    FOREIGN KEY (IdT1) REFERENCES Tag (IdT) ON DELETE CASCADE
);


DESCRIBE Process;

###############################################
CREATE TABLE Curriculum
(
    IdCU          CHAR(21) PRIMARY KEY,
    StudiesCU     CHAR,
    ExperiencesCU CHAR,
    YearsCU       INT(2)
);

DESCRIBE Curriculum;

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


################################################

CREATE TABLE Professional
(
    IdP         CHAR(21) PRIMARY KEY,
    NameP       CHAR(50),
    DateBirthP  DATE,
    EmailP      CHAR(21),
    PasswordP   CHAR(64),
    SexP        BOOLEAN,
    DUIP        VARCHAR(15),
    AFPP        VARCHAR(50),
    ISSSP       VARCHAR(50),
    ZipCodeP    VARCHAR(10),
    SalaryP     FLOAT,
    HiringDateP DATE,
    PictureP    LONGBLOB,
    IdCU1       CHAR(21),
    IdPFS1      INT,
    IdDP1       INT,
    IdWDT1      INT,
    FOREIGN KEY (IdCU1) REFERENCES Curriculum (IdCU) ON DELETE CASCADE,
    FOREIGN KEY (IdPFS1) REFERENCES Profession (IdPFS) ON DELETE CASCADE,
    FOREIGN KEY (IdDP1) REFERENCES Department (IdDP) ON DELETE CASCADE,
    FOREIGN KEY (IdWDT1) REFERENCES WorkDayType (IdWDT) ON DELETE CASCADE
);

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
    IdPS1         INT,
    IdP1          CHAR(21),
    IdC1          CHAR(21),
    FOREIGN KEY (IdPS1) REFERENCES ProjectStatus (IdPS) ON DELETE CASCADE,
    FOREIGN KEY (IdP1) REFERENCES Professional (IdP) ON DELETE CASCADE,
    FOREIGN KEY (IdC1) REFERENCES Client (IdC) ON DELETE CASCADE
);

DESCRIBE Project;

################################################
CREATE TABLE Activity
(
    IdA            CHAR(21) PRIMARY KEY,
    TitleA         VARCHAR(50),
    DescriptionA   VARCHAR(500),
    ExpectedBeginA DATETIME,
    ExpectedEndA   DATETIME,
    PictureA       LONGBLOB,
    IdPJ1          CHAR(21),
    IdT1           CHAR(21),
    FOREIGN KEY (IdPJ1) REFERENCES Project (IdPJ) ON DELETE CASCADE,
    FOREIGN KEY (IdT1) REFERENCES Tag (IdT) ON DELETE CASCADE
);

################################################
CREATE TABLE Profession
(
    IdPFS   INT AUTO_INCREMENT PRIMARY KEY,
    NamePFS VARCHAR(50)
);

INSERT INTO Profession (NamePFS)
VALUES ('Bufete legal'),
       ('Servicios automotriz'),
       ('Médico general');

################################################

CREATE TABLE Notification
(
    IdN             CHAR(21) PRIMARY KEY,
    TitleN          VARCHAR(50),
    DescriptionN    VARCHAR(500),
    DateTimeIssuedN DATETIME,
    PictureN        LONGBLOB,
    IdPJ2           CHAR(21),
    FOREIGN KEY (IdPJ2) REFERENCES Project (IdPJ) ON DELETE CASCADE
);