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

INSERT INTO userData (userID, userName, userBirthdate, userGender, userCPF, userStreetname, userCity, userState, userCEP, userEmail, userPassword, userDepartment, userPosition, userRegister) VALUES
(1, 'Joyce Santos Gomes', '2006-07-04', 'F', 12345678901, 'Av. Carlos Barbosa', 'São Paulo', 'Grajaú', 12345678, 'joyce@gmail.com', HASHBYTES('SHA2_256', 'senha123'), 'Estética', 'Supervisora de estética', 1),
(2, 'Claudir Santos Gomes', '2007-01-23', 'M', 12345678901, 'Rua Iguaçu', 'São Paulo', 'Embu Das Artes', 12345678, 'claudir@gmail.com', HASHBYTES('SHA2_256', 'senha123'), 'T.I', 'Engenheiro de Redes', 1);

SELECT * FROM userData