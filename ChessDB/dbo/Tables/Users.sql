CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserID] INT NOT NULL IDENTITY(1000, 1), 
    [FirstName] NCHAR(50) NOT NULL, 
    [LastName] NCHAR(50) NULL, 
    [Email] NCHAR(100) NULL, 
    [Password] NCHAR(100) NULL, 
    [Newsletter] BIT NULL DEFAULT 0, 
    [UserType] INT NULL DEFAULT 1

)
