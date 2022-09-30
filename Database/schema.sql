SET collation_connection = 'utf8_general_ci';
SET collation_server = 'utf8_general_ci';
SET character_set_client = 'utf8';
SET character_set_connection = 'utf8';
SET character_set_database = 'utf8';
SET character_set_results = 'utf8';
SET character_set_server = 'utf8';
SET collation_database = 'utf8_general_ci';
SET collation_server = 'utf8_general_ci';
DROP DATABASE IF EXISTS ProFind;
CREATE DATABASE ProFind;
USE ProFind;

################################################

CREATE TABLE Clients
(
    IdC               CHAR(21) PRIMARY KEY,
    NameC             VARCHAR(50),
    EmailC            VARCHAR(255),
    PasswordC         CHAR(64),
    RegistrationDateC DATETIME,
    PictureC          LONGTEXT
);

SELECT *
FROM Clients;

DESCRIBE Clients;

###########################################
CREATE TABLE Ranks
(
    IdR   INT AUTO_INCREMENT PRIMARY KEY,
    NameR VARCHAR(50) UNIQUE
);

DESCRIBE Ranks;

INSERT INTO Ranks (NameR)
VALUES ('Principal'),
       ('Administrator');

SELECT *
FROM Ranks;

###########################################
CREATE TABLE Admins
(
    IdA           CHAR(21) PRIMARY KEY,
    NameA         VARCHAR(50),
    EmailA        VARCHAR(255) UNIQUE,
    TelA          VARCHAR(15),
    PasswordA     CHAR(64),
    PictureA      LONGTEXT,
    CreationDateA DATETIME,
    IdR1          INT,
    FULLTEXT (NameA, EmailA, TelA),
    CONSTRAINT FK_Admin_Rank FOREIGN KEY (IdR1) REFERENCES Ranks (IdR) ON DELETE CASCADE
);

DESCRIBE Admins;

SELECT *
FROM Admins;

################################################
CREATE TABLE Departments
(
    IdDP   INT AUTO_INCREMENT PRIMARY KEY,
    NameDP VARCHAR(30)
);

INSERT INTO Departments (NameDP)
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
FROM Departments;

################################################
CREATE TABLE Professions
(
    IdPFS   INT AUTO_INCREMENT PRIMARY KEY,
    NamePFS VARCHAR(50)
);

INSERT INTO Professions (NamePFS)
VALUES ('Law firm'),
       ('Automotive services'),
       ('General medicine');

SELECT *
FROM Professions;

################################################
CREATE TABLE Professionals
(
    IdP               CHAR(21) PRIMARY KEY,
    NameP             CHAR(50),
    DateBirthP        DATETIME,
    EmailP            CHAR(255),
    PasswordP         CHAR(64),
    ActiveP           BOOLEAN,
    PhoneP            CHAR(15),
    SexP              BOOLEAN,
    DUIP              VARCHAR(15),
    AFPP              VARCHAR(50),
    ISSSP             VARCHAR(50),
    ZipCodeP          VARCHAR(10),
    SalaryP           FLOAT,
    HiringDateP       DATETIME,
    PictureP          LONGTEXT,
    CurriculumP       LONGBLOB,
    IdPFS1            INT,
    IdDP1             INT,
    CONSTRAINT FK_Professional_Profession FOREIGN KEY (IdPFS1) REFERENCES Professions (IdPFS) ON DELETE CASCADE,
    CONSTRAINT FK_Professional_Department FOREIGN KEY (IdDP1) REFERENCES Departments (IdDP) ON DELETE CASCADE
);

SELECT *
FROM Professionals;

###############################################

# Change password codes
CREATE TABLE ChangePasswordCodes
(
    IdCPC    CHAR(21) PRIMARY KEY,
    CodeCPC  CHAR(4),
    ValidCPC BOOLEAN,
    IdC1     CHAR(21),
    IdA1     CHAR(21),
    IdP1     CHAR(21),
    CONSTRAINT FK_Client_ChangePasswordCode FOREIGN KEY (IdC1) REFERENCES Clients (IdC) ON DELETE CASCADE,
    CONSTRAINT FK_Admin_ChangePasswordCode FOREIGN KEY (IdA1) REFERENCES Admins (IdA) ON DELETE CASCADE,
    CONSTRAINT FK_Professional_ChangePasswordCode FOREIGN KEY (IdP1) REFERENCES Professionals (IdP) ON DELETE CASCADE
);

SELECT +

###############################################
CREATE TABLE Projects
(
    IdPJ          CHAR(21) PRIMARY KEY,
    TitlePJ       VARCHAR(50),
    DescriptionPJ VARCHAR(50),
    PicturePJ     LONGTEXT,
    StartDate     DATETIME,
    EndDate       DATETIME,
    TotalPricePJ  FLOAT,
    IsPaidPJ      BOOLEAN,
    IsActive      BOOLEAN,
    Completed     BOOLEAN,
    TagDurationPJ INT,
    IdP1          CHAR(21),
    IdC1          CHAR(21),
    CONSTRAINT FK_Project_Professional FOREIGN KEY (IdP1) REFERENCES Professionals (IdP) ON DELETE CASCADE,
    CONSTRAINT FK_Project_Client FOREIGN KEY (IdC1) REFERENCES Clients (IdC) ON DELETE CASCADE
);

DESCRIBE Projects;

SELECT *
FROM Projects;

################################################
CREATE TABLE Proposals
(
    IdPP           CHAR(21) PRIMARY KEY,
    TitlePP        VARCHAR(50),
    DescriptionPP  VARCHAR(500),
    PicturePP      LONGTEXT,
    SuggestedStart DATETIME,
    SuggestedEnd   DATETIME,
    Seen           BOOLEAN,
    Accepted       BOOLEAN,
    IdP3           CHAR(21),
    IdC3           CHAR(21),
    CONSTRAINT FK_Proposal_Professional FOREIGN KEY (IdP3) REFERENCES Professionals (IdP) ON DELETE CASCADE,
    CONSTRAINT FK_Proposal_Client FOREIGN KEY (IdC3) REFERENCES Clients (IdC) ON DELETE CASCADE
);

SELECT * FROM Proposals;