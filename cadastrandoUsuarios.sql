CREATE DATABASE cadastrandoUsuarios;
USE cadastrandoUsuarios;

CREATE TABLE userData (
    userID INT PRIMARY KEY NOT NULL,
    userName VARCHAR(128) NOT NULL,
    userBirthdate DATE NOT NULL,
    userGender CHAR(1) NOT NULL,
    userCPF CHAR(11) NOT NULL,
    userStreetname VARCHAR(255) NOT NULL,
    userCity VARCHAR(255) NOT NULL,
    userState VARCHAR(255) NOT NULL,
    userCEP CHAR(8) NOT NULL,
    userEmail VARCHAR (255) NOT NULL,
    userPassword NVARCHAR(255) NOT NULL,
    userDepartment VARCHAR (255) NOT NULL,
    userPosition VARCHAR(255) NOT NULL,
    userRegister BIT NOT NULL
);