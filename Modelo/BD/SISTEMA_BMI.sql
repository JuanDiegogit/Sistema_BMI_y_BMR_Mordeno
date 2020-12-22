CREATE DATABASE SISTEMA_BMI
GO

USE SISTEMA_BMI
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CATEGORIA'
CREATE TABLE [dbo].[CATEGORIA] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(100)  NOT NULL,
    [Minimo] decimal(16,2)  NOT NULL,
    [Maximo] decimal(16,2)  NOT NULL
);
GO

-- Creating table 'NIVEL_ACTIVIDAD'
CREATE TABLE [dbo].[NIVEL_ACTIVIDAD] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(100)  NOT NULL,
    [Descripcion] varchar(100)  NOT NULL,
    [FactorActividad] decimal(16,2)  NOT NULL
);
GO

-- Creating table 'SEXO'
CREATE TABLE [dbo].[SEXO] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Sexo1] varchar(100)  NOT NULL
);
GO

-- Creating table 'USUARIO'
CREATE TABLE [dbo].[USUARIO] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(100)  NOT NULL,
    [Apellido] varchar(100)  NOT NULL,
    [FechaNacimiento] datetime  NULL,
    [SexoID] int  NULL,
    [Peso] decimal(16,2)  NOT NULL,
    [Estatura] decimal(16,2)  NOT NULL,
    [BMI] decimal(16,2)  NOT NULL,
    [BMR] decimal(16,2)  NOT NULL,
    [NivelActividad] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'CATEGORIA'
ALTER TABLE [dbo].[CATEGORIA]
ADD CONSTRAINT [PK_CATEGORIA]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'NIVEL_ACTIVIDAD'
ALTER TABLE [dbo].[NIVEL_ACTIVIDAD]
ADD CONSTRAINT [PK_NIVEL_ACTIVIDAD]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SEXO'
ALTER TABLE [dbo].[SEXO]
ADD CONSTRAINT [PK_SEXO]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [PK_USUARIO]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [NivelActividad] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [FK__USUARIO__NivelAc__5441852A]
    FOREIGN KEY ([NivelActividad])
    REFERENCES [dbo].[NIVEL_ACTIVIDAD]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__USUARIO__NivelAc__5441852A'
CREATE INDEX [IX_FK__USUARIO__NivelAc__5441852A]
ON [dbo].[USUARIO]
    ([NivelActividad]);
GO

-- Creating foreign key on [SexoID] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [FK__USUARIO__SexoID__534D60F1]
    FOREIGN KEY ([SexoID])
    REFERENCES [dbo].[SEXO]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__USUARIO__SexoID__534D60F1'
CREATE INDEX [IX_FK__USUARIO__SexoID__534D60F1]
ON [dbo].[USUARIO]
    ([SexoID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------