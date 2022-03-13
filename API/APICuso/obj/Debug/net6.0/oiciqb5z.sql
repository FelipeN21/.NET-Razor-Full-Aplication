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

