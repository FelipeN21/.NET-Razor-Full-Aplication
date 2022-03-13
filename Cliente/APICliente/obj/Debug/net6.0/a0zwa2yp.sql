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

CREATE TABLE [VendasClientes] (
    [Id] int NOT NULL IDENTITY,
    [CodigoDoCliente] int NOT NULL,
    [DataDaVenda] nvarchar(max) NOT NULL,
    [Valor] float NOT NULL,
    CONSTRAINT [PK_VendasClientes] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220313134225_initial', N'6.0.3');
GO

COMMIT;
GO

