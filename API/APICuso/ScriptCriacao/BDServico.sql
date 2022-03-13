IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [LimiteClientes] (
    [Id] int NOT NULL IDENTITY,
    [CodigoDoCliente] int NOT NULL,
    [Nome] nvarchar(max) NOT NULL,
    [Limite] float NULL,
    CONSTRAINT [PK_LimiteClientes] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220312160420_initial', N'6.0.3');
GO

COMMIT;
GO

INSERT INTO LimiteClientes (CodigoDoCliente, Nome, Limite)
VALUES (2106, 'Felipe Nepomuceno Coelho' , 600);
GO
INSERT INTO LimiteClientes (CodigoDoCliente, Nome, Limite)
VALUES (0003, 'Robert T' , 500);
GO
INSERT INTO LimiteClientes (CodigoDoCliente, Nome, Limite)
VALUES (0008, 'Julia R' , 1000);
GO
INSERT INTO LimiteClientes (CodigoDoCliente, Nome, Limite)
VALUES (0010, 'Peter P' , 300);
GO
INSERT INTO LimiteClientes (CodigoDoCliente, Nome, Limite)
VALUES (0011, 'Quebec E' , 2100);
GO
INSERT INTO LimiteClientes (CodigoDoCliente, Nome, Limite)
VALUES (0012, 'Iyan Lip' , 1700);
GO
INSERT INTO LimiteClientes (CodigoDoCliente, Nome, Limite)
VALUES (0013, 'Duda X' , 1500);
GO
INSERT INTO LimiteClientes (CodigoDoCliente, Nome, Limite)
VALUES (0014, 'Lontra T' , 1300);
GO
INSERT INTO LimiteClientes (CodigoDoCliente, Nome, Limite)
VALUES (0015, 'Rebeca J' , 1200);
GO
INSERT INTO LimiteClientes (CodigoDoCliente, Nome, Limite)
VALUES (0016, 'Pit L' , 0);