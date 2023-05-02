CREATE Table [dbo].[Pista]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [Senha] INT NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL
)
