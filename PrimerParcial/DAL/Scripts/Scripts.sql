CREATE DATABASE ParcialDb
GO
USE ParcialDb
GO 

create Table Vendedor
(
  Venderdor int primary key,
  Nombre var(30),
  sueldo int,
  Rotacion int,
  Retencion int
);

---Select * from Vendedor