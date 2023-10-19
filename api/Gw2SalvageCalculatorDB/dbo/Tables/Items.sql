CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(150) NOT NULL, 
    [Type] INT NOT NULL, 
    [Rarity] INT NOT NULL, 
    [Level] TINYINT NOT NULL CHECK ([Level] >= 0 AND [Level] <= 80),
    [Salvage] BIT NOT NULL, 
    [Binding] BIT NOT NULL,

    CONSTRAINT [FK_Type_Id] FOREIGN KEY ([Type]) REFERENCES [Types]([Id]), 
    CONSTRAINT [FK_Rarity_Id] FOREIGN KEY ([Rarity]) REFERENCES [Rarity]([Id])
)