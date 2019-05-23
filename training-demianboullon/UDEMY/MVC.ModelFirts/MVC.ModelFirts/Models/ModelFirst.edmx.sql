
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/18/2018 23:25:47
-- Generated from EDMX file: C:\Users\DemianBoullon\Work\acom-training-demianboullon\UDEMY\MVC.ModelFirts\MVC.ModelFirts\Models\ModelFirst.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EnrollmentStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Enrollments] DROP CONSTRAINT [FK_EnrollmentStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_StudentMatter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matters] DROP CONSTRAINT [FK_StudentMatter];
GO
IF OBJECT_ID(N'[dbo].[FK_TeacherMatter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matters] DROP CONSTRAINT [FK_TeacherMatter];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Enrollments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Enrollments];
GO
IF OBJECT_ID(N'[dbo].[Matters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Matters];
GO
IF OBJECT_ID(N'[dbo].[Students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO
IF OBJECT_ID(N'[dbo].[Teachers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teachers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Enrollments'
CREATE TABLE [dbo].[Enrollments] (
    [EnrollmentId] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [StudentStudentId] int  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [StudentId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [Average] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Teachers'
CREATE TABLE [dbo].[Teachers] (
    [TeacherId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Matters'
CREATE TABLE [dbo].[Matters] (
    [MatterId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [TeacherTeacherId] int  NOT NULL
);
GO

-- Creating table 'Inscriptions'
CREATE TABLE [dbo].[Inscriptions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StudentStudentId] int  NOT NULL,
    [MatterMatterId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EnrollmentId] in table 'Enrollments'
ALTER TABLE [dbo].[Enrollments]
ADD CONSTRAINT [PK_Enrollments]
    PRIMARY KEY CLUSTERED ([EnrollmentId] ASC);
GO

-- Creating primary key on [StudentId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([StudentId] ASC);
GO

-- Creating primary key on [TeacherId] in table 'Teachers'
ALTER TABLE [dbo].[Teachers]
ADD CONSTRAINT [PK_Teachers]
    PRIMARY KEY CLUSTERED ([TeacherId] ASC);
GO

-- Creating primary key on [MatterId] in table 'Matters'
ALTER TABLE [dbo].[Matters]
ADD CONSTRAINT [PK_Matters]
    PRIMARY KEY CLUSTERED ([MatterId] ASC);
GO

-- Creating primary key on [Id] in table 'Inscriptions'
ALTER TABLE [dbo].[Inscriptions]
ADD CONSTRAINT [PK_Inscriptions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentStudentId] in table 'Enrollments'
ALTER TABLE [dbo].[Enrollments]
ADD CONSTRAINT [FK_EnrollmentStudent]
    FOREIGN KEY ([StudentStudentId])
    REFERENCES [dbo].[Students]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EnrollmentStudent'
CREATE INDEX [IX_FK_EnrollmentStudent]
ON [dbo].[Enrollments]
    ([StudentStudentId]);
GO

-- Creating foreign key on [TeacherTeacherId] in table 'Matters'
ALTER TABLE [dbo].[Matters]
ADD CONSTRAINT [FK_TeacherMatter]
    FOREIGN KEY ([TeacherTeacherId])
    REFERENCES [dbo].[Teachers]
        ([TeacherId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeacherMatter'
CREATE INDEX [IX_FK_TeacherMatter]
ON [dbo].[Matters]
    ([TeacherTeacherId]);
GO

-- Creating foreign key on [StudentStudentId] in table 'Inscriptions'
ALTER TABLE [dbo].[Inscriptions]
ADD CONSTRAINT [FK_InscriptionStudent]
    FOREIGN KEY ([StudentStudentId])
    REFERENCES [dbo].[Students]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscriptionStudent'
CREATE INDEX [IX_FK_InscriptionStudent]
ON [dbo].[Inscriptions]
    ([StudentStudentId]);
GO

-- Creating foreign key on [MatterMatterId] in table 'Inscriptions'
ALTER TABLE [dbo].[Inscriptions]
ADD CONSTRAINT [FK_InscriptionMatter]
    FOREIGN KEY ([MatterMatterId])
    REFERENCES [dbo].[Matters]
        ([MatterId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscriptionMatter'
CREATE INDEX [IX_FK_InscriptionMatter]
ON [dbo].[Inscriptions]
    ([MatterMatterId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------