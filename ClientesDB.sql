CREATE DATABASE ClienteChallenge;
go
USE ClienteChallenge;
go

CREATE TABLE Clientes(
ID int Identity(1,1) primary key,
Nombres Varchar(50) not null,
Apellidos Varchar(80) not null,
FechaNacimiento Date ,
CUIT Varchar(20) not null,
Domicilio varchar(50) not null,
Celular Varchar(10) not null,
Email Varchar(30) not null
);

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Juan', 'Pérez', '1985-06-15', '20-12345678-9', 'Calle Ficticia 123', '1123456789', 'juan.perez@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Ana', 'Gómez', '1990-02-20', '27-23456789-1', 'Av. Libertad 456', '1134567890', 'ana.gomez@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Carlos', 'López', '1983-11-05', '20-34567890-2', 'Calle Siempre Viva 789', '1145678901', 'carlos.lopez@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('María', 'Martínez', '1992-08-30', '23-45678901-3', 'Calle Sol 101', '1156789012', 'maria.martinez@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Pedro', 'Sánchez', '1980-03-12', '20-56789012-4', 'Av. San Martín 202', '1167890123', 'pedro.sanchez@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Laura', 'Rodríguez', '1988-09-25', '27-67890123-5', 'Calle Río 303', '1178901234', 'laura.rodriguez@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Javier', 'González', '1987-05-10', '20-78901234-6', 'Calle del Parque 404', '1189012345', 'javier.gonzalez@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Lucía', 'Fernández', '1995-04-22', '23-89012345-7', 'Calle Luna 505', '1190123456', 'lucia.fernandez@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Fernando', 'Díaz', '1982-01-15', '20-90123456-8', 'Calle Estrella 606', '1201234567', 'fernando.diaz@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Gabriela', 'García', '1993-07-04', '27-01234567-9', 'Av. Norte 707', '1212345678', 'gabriela.garcia@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Ricardo', 'Paredes', '1984-10-10', '20-12345678-9', 'Calle del Sol 808', '1223456789', 'ricardo.paredes@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Susana', 'Ramírez', '1991-12-18', '23-23456789-0', 'Calle de la Paz 909', '1234567890', 'susana.ramirez@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Héctor', 'Jiménez', '1986-03-03', '20-34567890-1', 'Calle Mendoza 1010', '1245678901', 'hector.jimenez@mail.com');

INSERT INTO Clientes (Nombres, Apellidos, FechaNacimiento, CUIT, Domicilio, Celular, Email)
VALUES ('Claudia', 'Vázquez', '1994-11-16', '27-45678901-2', 'Av. Buenos Aires 1111', '1256789012', 'claudia.vazquez@mail.com');


