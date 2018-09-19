CREATE DATABASE ParcialDb
GO
USE ParcialDb
GO 

create Table Vendedor
(
  VenderdorId int primary key,
  Fecha dateTime,
  Nombre varchar(30),
  Sueldo money,
  Rotacion money,
  Retencion money
);

select *from Vendedor