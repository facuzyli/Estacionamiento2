CREATE TABLE [dbo].[Estacionamiento]
(
	[IdRegistro] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Patente] NVARCHAR(50) NOT NULL, 
    [Marca] NVARCHAR(50) NOT NULL, 
    [Modelo] NVARCHAR(50) NOT NULL, 
    [Color] NVARCHAR(50) NOT NULL, 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [CantHoras] INT NOT NULL, 
    [FechaRegistro] DATE NULL
)
